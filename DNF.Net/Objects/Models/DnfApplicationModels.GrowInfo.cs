namespace DNF.Net.Objects.Models
{
    public partial class DnfApplicationModels
    {
        public record DnfApplicationGrowInfoTotal(int damage, int buff, int level);
        public record DnfApplicationGrowInfoOption(int level, decimal expRate, string explain, string explainDetail, int damage, int buff);
        public record DnfApplicationGrowInfo(DnfApplicationGrowInfoTotal total, IList<DnfApplicationGrowInfoOption> options);
    }
}
