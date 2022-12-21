namespace DNF.Net.Objects.Models
{
    public partial class DnfApplicationModels
    {
        public record DnfApplicationAvatar(string slotId, string slotName, string itemId, string itemName, string itemRarity, DnfApplicationItem clone, DnfApplicationItem random, string optionAbility, IList<DnfApplicationEmblem> emblems);
        public record DnfApplicationEmblem(int slotNo, string slotColor, string itemName, string itemRarity);
        public record DnfApplicationBuffSkillAvatar(string slotId, string slotName, string itemId, string itemName, string itemRarity, object cloneAvatarName, string optionAbility, IList<DnfApplicationEmblem> emblems);
        public record DnfApplicationCharacterAvatar(string characterId, string characterName, int level, string jobId, string jobGrowId, string jobName, string jobGrowName, string adventureName, string guildId, string guildName, IList<DnfApplicationAvatar> avatar);
        public record DnfApplicationCharacterAvatarBuff(DnfApplicationSkillInfo skillInfo, IList<DnfApplicationBuffSkillAvatar> avatar);
        public record DnfApplicationCharacterAvatarBuffSkill(DnfApplicationCharacterAvatarBuff buff);
        public record DnfApplicationCharacterBuffSkillAvatar(string characterId, string characterName, int level, string jobId, string jobGrowId, string jobName, string jobGrowName, string adventureName, string guildId, string guildName, DnfApplicationCharacterAvatarBuffSkill skill);
        public record DnfApplicationAvatarMarketItemEmblem(int code, string name);
        public record DnfApplicationAvatarMarketItemSearch(int goodsNo, string title, int price, string jobId, string jobName, object soldDate, IList<object> hashtag, DnfApplicationAvatarMarketItemEmblem emblem, bool avatarSet, string avatarRarity, int avatarCount, IList<DnfApplicationAvatar> avatar);

    }
}
