namespace DNF.Net.Objects.Models
{
    public partial class DnfApplicationModels
    {
        public record DnfApplicationGem(int slotNo, string itemId, string itemName, string itemRarity, string itemAbility);
        public record DnfApplicationFlag(string itemId, string itemName, int itemAvailableLevel, string itemRarity, int reinforce, string itemAbility, IList<DnfApplicationGem> gems);
        public record DnfApplicationCharacterFlag(string characterId, string characterName, int level, string jobId, string jobGrowId, string jobName, string jobGrowName, string adventureName, string guildId, string guildName, DnfApplicationFlag flag);
    }
}
