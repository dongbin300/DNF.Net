namespace DNF.Net.Objects.Models
{
    public partial class DnfApplicationModels
    {
        public record DnfApplicationServerCharacter(string serverId, string characterId, string characterName, int level, string jobId, string jobGrowId, string jobName, string jobGrowName);
        public record DnfApplicationCharacterBasic(string characterId, string characterName, int level, string jobId, string jobGrowId, string jobName, string jobGrowName, string adventureName, string guildId, string guildName);
        public record DnfApplicationCharacterStatusInfo(string characterId, string characterName, int level, string jobId, string jobGrowId, string jobName, string jobGrowName, string adventureName, string guildId, string guildName, IList<DnfApplicationCharacterEquipmentBuff> buff, IList<DnfApplicationValue> status);
    }
}
