namespace IdCard.Hanel.Models
{

    public enum GroupByData
    {
        Day,
        Month
    }

    public class Filter
    {
        public int Skip { set; get; }
        public int Limit { set; get; }
    }

    public class FilterByTime : Filter
    {
        public DateTime? From { set; get; }
        public DateTime? To { set; get; }
    }

    public class DataWCount<T>
    {
        public int Total { get; set; } = 0;
        public List<T> Data = new();

        public DataWCount()
        {

        }

        public DataWCount(int total, List<T> data)
        {
            this.Total = total;
            this.Data = data ?? new List<T>();
        }
    }
}