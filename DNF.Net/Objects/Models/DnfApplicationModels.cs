namespace DNF.Net.Objects.Models
{
    public partial class DnfApplicationModels
    {
        public record DnfApplicationValue(string name, object value);
        public record DnfApplicationServer(string serverId, string serverName);
        public record DnfApplicationDate(string start, string end);
        public record DnfApplicationSlot(string slotId, string slotName, string itemId, string itemName, string itemRarity);
    }
}
