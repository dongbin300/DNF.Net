namespace DNF.Net.Objects.Models
{
    public class DnfApplicationRecords<T>
    {
        public IList<T> rows { get; set; } = Array.Empty<T>();
    }
}
