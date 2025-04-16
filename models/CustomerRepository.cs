using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LibUsbDotNetF;

namespace IdCard.Hanel.Models
{
    public class CustomerRepository
    {
        private readonly AuthenCardDbContext _context;

        public CustomerRepository(AuthenCardDbContext context)
        {
            _context = context;
        }

        public void AddCustomer(Customer customer)
        {
            _context.Set<Customer>().Add(customer);
            _context.SaveChanges();
        }

        public Customer? GetCustomerById(string id)
        {
            return _context.Set<Customer>().FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Customer> GetCustomersByPage(int pageNumber, int pageSize)
        {
            return _context.Set<Customer>()
                           .Skip((pageNumber - 1) * pageSize)
                           .Take(pageSize)
                           .ToList();
        }

        public Customer FirstOrDefault(string id, Customer newCustomer)
        {
            var customer = _context.Set<Customer>().FirstOrDefault(c => c.Id == id);
            if (customer == null)
            {
                _context.Set<Customer>().Add(newCustomer);
                _context.SaveChanges();
                return newCustomer;
            }
            return customer;
        }

        public DataWCount<CustomerExtend> GetCustomers(DateTime? from, DateTime? to, int skip = 0, int limit = 10, string? search = null)
        {
            var query = _context.Set<Customer>()
                                .Include(c => c.InOutLogs) // Assuming InOutLogs is a navigation property
                                .AsQueryable();

            if (from.HasValue)
            {
                query = query.Where(c => c.InOutLogs != null && c.InOutLogs.Any(log => log.CheckInTime >= from.Value));
            }

            if (to.HasValue)
            {
                query = query.Where(c => c.InOutLogs != null && c.InOutLogs.Any(log => log.CheckInTime <= to.Value));
            }

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(c => c.HoTen != null && c.HoTen.Contains(search));
            }

            var totalCount = query.Count();

            var customers = query.Skip(skip)
                                 .Take(limit)
                                 .Select(c => new CustomerExtend(c, c.InOutLogs != null ? c.InOutLogs.Count : 0))
                                 .ToList();

            return new DataWCount<CustomerExtend>
            {
                Total = totalCount,
                Data = customers
            };
        }
    }
    public class CustomerExtend : Customer
    {
        public int InOutLogCount { get; set; }

        public CustomerExtend()
        {
            InOutLogCount = 0;
        }

        public CustomerExtend(Customer customer, int inOutLogCount)
        {
            Id = customer.Id;
            HoTen = customer.HoTen;
            NgayCap = customer.NgayCap;
            NgaySinh = customer.NgaySinh;
            DiaChi = customer.DiaChi;
            InOutLogCount = inOutLogCount;
        }
    }

}
