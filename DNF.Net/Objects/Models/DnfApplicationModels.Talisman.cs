namespace DNF.Net.Objects.Models
{
    public partial class DnfApplicationModels
    {
        public record DnfApplicationTalisman(int slotNo, string itemId, string itemName, IList<string> runeTypes);
        public record DnfApplicationRune(int slotNo, string itemId, string itemName);
        public record DnfApplicationTalismanDetail(string skillId, string skillName, string explain, string explainDetail);
        public record DnfApplicationRuneDetail(string skillId, string skillName, string runeType);
        public record DnfApplicationTalismans(DnfApplicationTalisman talisman, IList<DnfApplicationRune> runes);
        public record DnfApplicationCharacterTalismans(string characterId, string characterName, int level, string jobId, string jobGrowId, string jobName, string jobGrowName, string adventureName, string guildId, string guildName, IList<DnfApplicationTalismans> talismans);
    }
}
