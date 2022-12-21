namespace DNF.Net.Objects.Models
{
    public partial class DnfApplicationModels
    {
        public record DnfApplicationSetItem(string setItemId, string setItemName, IList<DnfApplicationSlot> slotInfo, int activeSetNo);
        public record DnfApplicationSetItemDetail(string setItemId, string setItemName, IList<DnfApplicationSlot> setItems, IList<DnfApplicaationSetItemOption> setItemOption);
        public record DnfApplicaationSetItemBuff(string explain, IList<object> reinforceSkill);
        public record DnfApplicaationSetItemOption(int optionNo, string explain, string detailExplain, IList<DnfApplicationValue> status, DnfApplicaationSetItemBuff itemBuff);
        public record DnfApplicationEquipmentSetItemActivationInfo(IList<DnfApplicationEquipment> equipment, IList<DnfApplicationSetItem> setItemInfo);
    }
}