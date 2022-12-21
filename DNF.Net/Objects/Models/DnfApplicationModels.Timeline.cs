namespace DNF.Net.Objects.Models
{
    public partial class DnfApplicationModels
    {
        public record DnfApplicationTimelineData(string itemId, string itemName, string itemRarity, string channelName, int channelNo, string dungeonName);
        public record DnfApplicationTimelineRow(int code, string name, string date, DnfApplicationTimelineData data);
        public record DnfApplicationTimeline(DnfApplicationDate date, string next, IList<DnfApplicationTimelineRow> rows);
        public record DnfApplicationCharacterTimeline(string characterId, string characterName, int level, string jobId, string jobGrowId, string jobName, string jobGrowName, string adventureName, string guildId, string guildName, DnfApplicationTimeline timeline);
    }
}
