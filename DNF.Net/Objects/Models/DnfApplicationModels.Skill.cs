namespace DNF.Net.Objects.Models
{
    public partial class DnfApplicationModels
    {
        public record DnfApplicationSkill(string skillId, string name, int level, int requiredLevel, string type, string costType);
        public record DnfApplicationSkillDetail(string name, string type, string costType, string desc, string descDetail, object consumeItem, int maxLevel, int requiredLevel, int requiredLevelRange, IList<DnfApplicationSkill> preRequiredSkill, string jobId, string jobName, IList<DnfApplicationJobGrowLevel> jobGrowLevel, DnfApplicationSkillLevelInfo levelInfo);
        public record DnfApplicationSkillLevel(int level, object consumeMp, object coolTime, object castingTime, object optionValue);
        public record DnfApplicationSkillLevelInfo(object optionDesc, IList<DnfApplicationSkillLevel> rows);
        public record DnfApplicationSkills(IList<DnfApplicationSkill> active, IList<DnfApplicationSkill> passive, IList<DnfApplicationSkill> skills);
        public record DnfApplicationCharacterSkill(DnfApplicationSkills style);
        public record DnfApplicationCharacterSkillStyle(string characterId, string characterName, int level, string jobId, string jobGrowId, string jobName, string jobGrowName, string adventureName, string guildId, string guildName, DnfApplicationCharacterSkill skill);
        public record DnfApplicationSkillOption(int level, string desc, IList<string> values);
        public record DnfApplicationSkillInfo(string skillId, string name, DnfApplicationSkillOption option);
        public record DnfApplicationReinforceSkill(string skillId, string name, int value);
    }
}
