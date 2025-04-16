using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using System.Text.Json;

namespace IdCard.Hanel.Models
{

    public enum IOStatus
    {
        None = 0,
        SignIn,
        SignOut,
    }

    public class InOutLogRepository
    {
        private readonly AuthenCardDbContext _context;

        public InOutLogRepository(AuthenCardDbContext context)
        {
            _context = context;
        }

        // Insert a new InOutLog
        public void Insert(InOutLog log)
        {
            log.Id = Guid.NewGuid().ToString();
            _context.InOutLogs.Add(log);
            _context.SaveChanges();
        }

        // Get a paginated list of InOutLogs filtered by date range and CCCD
        public DataWCount<InOutLog> GetList(DateTime? from, DateTime? to, int skip, int limit, string? cccd = null, IOStatus? status = null, string? hoTen = null)
        {
            // Check if the date range is valid
            if (from.HasValue && to.HasValue && from.Value > to.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new DataWCount<InOutLog> { Total = 0, Data = new List<InOutLog>() };
            }

            // Build the query with filtering and pagination
            var query = _context.InOutLogs
                .Include(log => log.Customer) // Include Customer in the query
                .Where(log => (!from.HasValue || log.CheckInTime >= from.Value)
                           && (!to.HasValue || log.CheckInTime <= to.Value)
                           && (string.IsNullOrEmpty(cccd) || log.CustomerId == cccd) &&
                           (string.IsNullOrEmpty(hoTen) || (log.Customer != null && log.Customer.HoTen != null && log.Customer.HoTen.Contains(hoTen))) &&
                           (!status.HasValue || (status == IOStatus.SignIn && log.CheckOutTime == null) ||
                            (status == IOStatus.SignOut && log.CheckOutTime != null)));

            var totalCount = query.Count();
            var data = query
                .OrderByDescending(log => log.CheckInTime)
                .Skip(skip)
                .Take(limit)
                .ToList();

            return new DataWCount<InOutLog>
            {
                Total = totalCount,
                Data = data
            };
        }



        // Get an InOutLog by ID
        public InOutLog? GetById(string logId)
        {
            try
            {
                return _context.InOutLogs.Include(log => log.Customer).First(log => log.Id == logId);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public InOutLog? DetectLatestCheckIn(string cccd, bool manualSignOut)
        {
            var to = DateTime.Now;
            var from = manualSignOut ? DateTime.Now.Date.AddDays(-30) : DateTime.Now.Date;
            var status = IOStatus.SignIn;

            var latest = GetList(from, to, 0, 2, cccd, status);
            if (latest == null || latest.Data.Count == 0)
                return null;

            var rs = latest.Data[0];
            rs.CheckOutTime = DateTime.Now;
            return rs;
        }

        // Get recent InOutLogs by CCCD
        public List<InOutLog> GetByCCCD(DateTime? from, DateTime? to, string cccd)
        {
            return _context.InOutLogs
                .Where(log => log.CustomerId == cccd && (!from.HasValue || log.CheckInTime >= from.Value) &&
                (!to.HasValue || log.CheckInTime <= to.Value)
                )
                .OrderByDescending(log => log.CheckInTime)
                .ToList();
        }

        // Update CheckOutTime for a specific InOutLog
        public void UpdateCheckOutTime(string logId, DateTime checkOutTime, int manualSignOut)
        {
            var log = _context.InOutLogs.FirstOrDefault(l => l.Id == logId);
            if (log != null)
            {
                log.CheckOutTime = checkOutTime;
                log.ManualSignOut = manualSignOut;
                _context.SaveChanges();
            }
        }


        // Update CheckOutTime for a specific InOutLog
        public void UpdateInfo(string logId, Dictionary<string, string> additionFields, string inImg)
        {
            var log = _context.InOutLogs.FirstOrDefault(l => l.Id == logId);
            if (log != null)
            {
                log.InImg = inImg;
                log.AdditionFields = additionFields;
                log.AdditionFieldsJson = JsonSerializer.Serialize(additionFields);
                _context.SaveChanges();
            }
        }

        // Aggregate InOutLogs by date
        public List<(DateTime Date, int Count)> AggregateByDate(DateTime from, DateTime to, GroupByData groupBy = GroupByData.Day)
        {
            var query = _context.InOutLogs
                .Where(log => log.CheckInTime >= from && log.CheckInTime <= to);

            if (groupBy == GroupByData.Month)
            {
                return query
                    .GroupBy(log => new DateTime(log.CheckInTime.Year, log.CheckInTime.Month, 1))
                    .Select(g => new { Date = g.Key, Count = g.Count() })
                    .OrderByDescending(result => result.Date)
                    .ToList()
                    .Select(result => (result.Date, result.Count))
                    .ToList();
            }
            else // Default to grouping by day
            {
                return query
                    .GroupBy(log => log.CheckInTime.Date)
                    .Select(g => new { Date = g.Key, Count = g.Count() })
                    .OrderByDescending(result => result.Date)
                    .ToList()
                    .Select(result => (result.Date, result.Count))
                    .ToList();
            }
        }

    }
}
