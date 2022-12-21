namespace DNF.Net.Objects.Models
{
    public partial class DnfApplicationModels
    {
        public record DnfApplicationJobInfo(string jobId, string jobName, IList<DnfApplicationJob> rows);
        public record DnfApplicationJob(string jobGrowId, string jobGrowName, DnfApplicationJob next);
        public record DnfApplicationJobGrowLevel(string jobGrowId, string jobGrowName, int masterLevel);
    }
}
