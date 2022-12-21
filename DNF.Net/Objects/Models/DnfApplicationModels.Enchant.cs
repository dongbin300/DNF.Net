namespace DNF.Net.Objects.Models
{
    public partial class DnfApplicationModels
    {
        public record DnfApplicationEnchant(IList<DnfApplicationValue> status, string explain);
        public record DnfApplicationBuffSkillEnchant(IList<DnfApplicationReinforceSkill> reinforceSkill);
    }
}
