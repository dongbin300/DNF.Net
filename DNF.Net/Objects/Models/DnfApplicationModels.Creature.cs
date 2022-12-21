namespace DNF.Net.Objects.Models
{
    public partial class DnfApplicationModels
    {
        public record DnfApplicationCreature(string itemId, string itemName, string itemRarity, DnfApplicationItem clone, IList<DnfApplicationArtifact> artifact);
        public record DnfApplicationArtifact(string slotColor, string itemName, int itemAvailableLevel, string itemRarity);
        public record DnfApplicationBuffSkillCreature(string itemId, string itemName, string itemRarity, object enchant);
        public record DnfApplicationCharacterCreature(string characterId, string characterName, int level, string jobId, string jobGrowId, string jobName, string jobGrowName, string adventureName, string guildId, string guildName, DnfApplicationCreature creature);
        public record DnfApplicationCharacterCreatureBuff(DnfApplicationSkillInfo skillInfo, IList<DnfApplicationBuffSkillCreature> creature);
        public record DnfApplicationCharacterCreatureBuffSkill(DnfApplicationCharacterCreatureBuff buff);
        public record DnfApplicationCharacterBuffSkillCreature(string characterId, string characterName, int level, string jobId, string jobGrowId, string jobName, string jobGrowName, string adventureName, string guildId, string guildName, DnfApplicationCharacterCreatureBuffSkill skill);
    }
}
