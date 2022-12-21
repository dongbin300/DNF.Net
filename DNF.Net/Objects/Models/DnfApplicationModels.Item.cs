namespace DNF.Net.Objects.Models
{
    public partial class DnfApplicationModels
    {
        public record DnfApplicationItem(string itemId, string itemName, string itemRarity);
        public record DnfApplicationAuctionItemSearch(int auctionNo, string regDate, string expireDate, string itemId, string itemName, int itemAvailableLevel, string itemRarity, string itemType, string itemTypeDetail, int refine, int reinforce, object amplificationName, int adventureFame, int count, int price, int currentPrice, int unitPrice, int averagePrice);
        public record DnfApplicationAuctionQuoteSearch(string soldDate, string itemId, string itemName, int itemAvailableLevel, string itemRarity, string itemType, string itemTypeDetail, int refine, int reinforce, object amplificationName, int count, int price, int unitPrice);
        public record DnfApplicationItemSearch(string itemId, string itemName, string itemRarity, string itemType, string itemTypeDetail, int itemAvailableLevel);
        public record DnfApplicationItemDetail(string itemId, string itemName, string itemRarity, string itemType, string itemTypeDetail, int itemAvailableLevel, string itemObtainInfo, string itemExplain, string itemExplainDetail, string itemFlavorText, object setItemId, object setItemName, DnfApplicationTalismanDetail talismanInfo, DnfApplicationRuneDetail runeInfo);
        public record DnfApplicationItemShopSales(string itemId, string itemName, string itemGradeName, int itemGradeValue, IList<DnfApplicationValue> itemStatus);
    }
}
