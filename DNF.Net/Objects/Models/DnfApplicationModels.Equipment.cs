namespace DNF.Net.Objects.Models
{
    public partial class DnfApplicationModels
    {
        public record DnfApplicationEquipment(string slotId, string slotName, string itemId, string itemName, string itemType, string itemTypeDetail, int itemAvailableLevel, string itemRarity, object setItemId, object setItemName, DnfApplicationItem skin, int reinforce, string itemGradeName, DnfApplicationEnchant enchant, string amplificationName, int refine, DnfApplicationGrowInfo growInfo);
        public record DnfApplicationCharacterEquipment(string characterId, string characterName, int level, string jobId, string jobGrowId, string jobName, string jobGrowName, string adventureName, string guildId, string guildName, IList<DnfApplicationEquipment> equipment, IList<object> setItemInfo);
        public record DnfApplicationBuffSkillEquipment(string slotId, string slotName, string itemId, string itemName, string itemType, string itemTypeDetail, int itemAvailableLevel, string itemRarity, string setItemId, string setItemName, int reinforce, object amplificationName, int refine, DnfApplicationBuffSkillEnchant enchant);
        public record DnfApplicationCharacterEquipmentBuff(DnfApplicationSkillInfo skillInfo, IList<DnfApplicationBuffSkillEquipment> equipment);
        public record DnfApplicationCharacterEquipmentBuffSkill(DnfApplicationCharacterEquipmentBuff buff);
        public record DnfApplicationCharacterBuffSkillEquipment(string characterId, string characterName, int level, string jobId, string jobGrowId, string jobName, string jobGrowName, string adventureName, string guildId, string guildName, DnfApplicationCharacterEquipmentBuffSkill skill);
    }
}
