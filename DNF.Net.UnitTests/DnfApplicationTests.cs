using DNF.Net.Applications;
using DNF.Net.Enums;

using NUnit.Framework;

namespace DNF.Net.UnitTests
{
    public class Tests
    {
        DnfApplication app;
        const DnfServer server = DnfServer.hilder;
        const string characterName1 = "귀수는너에게";
        const string characterName2 = "지기서2";
        const string characterName3 = "사타타틔탑";
        const string characterId1 = "ceabe206a3fded6c03d4ba2b75e3c7ae";
        const string characterId2 = "50acec5558e03ec80d40b51d58dc690d";
        const string characterId3 = "505f0c9ff017d91c9a5122e93120e6fa";
        const string itemName01 = "무색 큐브 조각";
        const string itemName02 = "고농축 힘의 비약";
        const string itemName03 = "웨더스푼 디스크";
        const string itemName04 = "이계 기운의 정화서";
        const string itemName05 = "최상급 경화제";
        const string itemName06 = "스카디 여왕의 씰";
        const string itemName07 = "에픽 소울";
        const string itemName08 = "검은 밤의 잔재";
        const string itemName09 = "마력 결정";
        const string itemName10 = "칼레이도 박스";
        const string itemName11 = "찬란한 붉은빛 엠블렘[힘]";
        const string itemName12 = "카펠라의 성흔 : 피의 축제";
        const string itemId01 = "785e56a0ed4e3efd573da1f56a45217d";
        const string itemId02 = "fabcf062052d30ae8709ec3b51d040bb";
        const string itemId03 = "5c2319dab4779e7c42eded087fd42ecd";
        const string itemId04 = "0507e1440ba4d8b69652c7229b6b156a";
        const string itemId05 = "41a42bdb5b09b0a6e2fbae237cf39b85";
        const string itemId06 = "ee9655a1d62dc8549fca8fbc15dc3897";
        const string itemId07 = "4932a263ba449568a9e60e59e4374314";
        const string itemId08 = "ac6a251540d74be600621fb519f86acf";
        const string itemId09 = "15162c9cfb07a537c797b1d84f54e08f";
        const string itemId10 = "10b83e647715c551f81c1e51d7c2b281";
        const string itemId11 = "61327a4507e1c5b33fe5dfee397a23c6";
        const string itemId12 = "41d1f65c50b7bb5f48ea6eeda230c3e2";
        const string setItemName1 = "찬란한 자 : 영광 세트";
        const string setItemId1 = "ddaa9c29eb95033a772f40c48b6f429e";

        #region Setup
        [SetUp]
        public void Setup()
        {
            string apiKey = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "dnf_key.txt"));

            app = new DnfApplication(apiKey);
        }
        #endregion

        #region Image API
        [TestCase(server, characterId1)]
        [TestCase(server, characterId2, DnfCharacterImageZoom.X2)]
        [TestCase(server, characterId3, DnfCharacterImageZoom.X3)]
        public async Task GetCharacterImageAsync(DnfServer server, string characterId, DnfCharacterImageZoom zoom = DnfCharacterImageZoom.X1)
        {
            try
            {
                Assert.That(await app.ImageApi.GetCharacterImageAsync(server, characterId, zoom), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(itemId01)]
        [TestCase(itemId02)]
        [TestCase(itemId03)]
        [TestCase(itemId04)]
        [TestCase(itemId05)]
        [TestCase(itemId06)]
        [TestCase(itemId07)]
        [TestCase(itemId08)]
        [TestCase(itemId09)]
        [TestCase(itemId10)]
        [TestCase(itemId11)]
        [TestCase(itemId12)]
        public async Task GetItemImageAsync(string itemId)
        {
            try
            {
                Assert.That(await app.ImageApi.GetItemImageAsync(itemId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion

        #region Servers API
        [Test]
        public async Task GetServerInfoAsync()
        {
            try
            {
                Assert.That(await app.ServersApi.GetServerInfoAsync(), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(server, characterName1)]
        [TestCase(server, characterName2)]
        [TestCase(server, characterName3)]
        public async Task GetCharacterInfoAsync(DnfServer server, string characterName)
        {
            try
            {
                Assert.That(await app.ServersApi.GetCharacterInfoAsync(server, characterName), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(server, characterId1)]
        [TestCase(server, characterId2)]
        [TestCase(server, characterId3)]
        public async Task GetCharacterBasicInfoAsync(DnfServer server, string characterId)
        {
            try
            {
                Assert.That(await app.ServersApi.GetCharacterBasicInfoAsync(server, characterId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(server, characterId1)]
        [TestCase(server, characterId2)]
        [TestCase(server, characterId3)]
        public async Task GetCharacterStatusInfoAsync(DnfServer server, string characterId)
        {
            try
            {
                Assert.That(await app.ServersApi.GetCharacterStatusInfoAsync(server, characterId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(server, characterId1)]
        [TestCase(server, characterId2)]
        [TestCase(server, characterId3)]
        public async Task GetCharacterAvatarAsync(DnfServer server, string characterId)
        {
            try
            {
                Assert.That(await app.ServersApi.GetCharacterAvatarAsync(server, characterId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(server, characterId1)]
        [TestCase(server, characterId2)]
        [TestCase(server, characterId3)]
        public async Task GetCharacterEquipmentAsync(DnfServer server, string characterId)
        {
            try
            {
                Assert.That(await app.ServersApi.GetCharacterEquipmentAsync(server, characterId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(server, characterId1)]
        [TestCase(server, characterId2)]
        [TestCase(server, characterId3)]
        public async Task GetCharacterCreatureAsync(DnfServer server, string characterId)
        {
            try
            {
                Assert.That(await app.ServersApi.GetCharacterCreatureAsync(server, characterId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(server, characterId1)]
        [TestCase(server, characterId2)]
        [TestCase(server, characterId3)]
        public async Task GetCharacterFlagAsync(DnfServer server, string characterId)
        {
            try
            {
                Assert.That(await app.ServersApi.GetCharacterFlagAsync(server, characterId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(server, characterId1)]
        [TestCase(server, characterId2)]
        [TestCase(server, characterId3)]
        public async Task GetCharacterTalismanAsync(DnfServer server, string characterId)
        {
            try
            {
                Assert.That(await app.ServersApi.GetCharacterTalismanAsync(server, characterId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(server, characterId1, "12/01/2022", "12/10/2022")]
        [TestCase(server, characterId2, "12/01/2022", "12/12/2022")]
        [TestCase(server, characterId3, "12/01/2022", "12/07/2022")]
        public async Task GetCharacterTimelineInfoAsync(DnfServer server, string characterId, DateTime startDate, DateTime endDate)
        {
            try
            {
                Assert.That(await app.ServersApi.GetCharacterTimelineInfoAsync(server, characterId, startDate, endDate), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(server, characterId1)]
        [TestCase(server, characterId2)]
        [TestCase(server, characterId3)]
        public async Task GetCharacterSkillStyleAsync(DnfServer server, string characterId)
        {
            try
            {
                Assert.That(await app.ServersApi.GetCharacterSkillStyleAsync(server, characterId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(server, characterId1)]
        [TestCase(server, characterId2)]
        [TestCase(server, characterId3)]
        public async Task GetCharacterBuffSkillAvatarAsync(DnfServer server, string characterId)
        {
            try
            {
                Assert.That(await app.ServersApi.GetCharacterBuffSkillAvatarAsync(server, characterId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(server, characterId1)]
        [TestCase(server, characterId2)]
        [TestCase(server, characterId3)]
        public async Task GetCharacterBuffSkillCreatureAsync(DnfServer server, string characterId)
        {
            try
            {
                Assert.That(await app.ServersApi.GetCharacterBuffSkillCreatureAsync(server, characterId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(server, characterId1)]
        [TestCase(server, characterId2)]
        [TestCase(server, characterId3)]
        public async Task GetCharacterBuffSkillEquipmentAsync(DnfServer server, string characterId)
        {
            try
            {
                Assert.That(await app.ServersApi.GetCharacterBuffSkillEquipmentAsync(server, characterId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion

        #region Auction API
        [TestCase(itemName01)]
        [TestCase(itemName02, itemId02)]
        [TestCase(itemName03, itemId03)]
        [TestCase(itemName04)]
        [TestCase(itemName05, itemId05)]
        [TestCase(itemName06)]
        [TestCase(itemName07, itemId07)]
        [TestCase(itemName08)]
        [TestCase(itemName09, itemId09)]
        [TestCase(itemName10)]
        [TestCase(itemName11, itemId11)]
        [TestCase(itemName12, itemId12)]
        public async Task GetAuctionItemSearchAsync(string itemName, string itemId = "")
        {
            try
            {
                Assert.That(await app.AuctionApi.GetAuctionItemSearchAsync(itemName, itemId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(itemName01)]
        [TestCase(itemName02, itemId02)]
        [TestCase(itemName04)]
        [TestCase(itemName05, itemId05)]
        [TestCase(itemName06)]
        [TestCase(itemName09, itemId09)]
        public async Task GetAuctionItemAsync(string itemName, string itemId = "")
        {
            try
            {
                var result = await app.AuctionApi.GetAuctionItemSearchAsync(itemName, itemId);
                Assert.That(await app.AuctionApi.GetAuctionItemAsync(result?.rows[0].auctionNo ?? 0), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(itemName01)]
        [TestCase(itemName02, itemId02)]
        [TestCase(itemName03, itemId03)]
        [TestCase(itemName04)]
        [TestCase(itemName05, itemId05)]
        [TestCase(itemName06)]
        [TestCase(itemName07, itemId07)]
        [TestCase(itemName08)]
        [TestCase(itemName09, itemId09)]
        [TestCase(itemName10)]
        [TestCase(itemName11, itemId11)]
        [TestCase(itemName12, itemId12)]
        public async Task GetAuctionQuoteSearchAsync(string itemName, string itemId = "")
        {
            try
            {
                Assert.That(await app.AuctionApi.GetAuctionQuoteSearchAsync(itemName, itemId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion

        #region Avatar Market API
        [Test]
        public async Task GetAvatarMarketItemSearchAsync()
        {
            try
            {
                Assert.That(await app.AvatarMarketApi.GetAvatarMarketItemSearchAsync(), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public async Task GetAvatarMarketItemAsync()
        {
            try
            {
                var goodsNo = (await app.AvatarMarketApi.GetAvatarMarketItemSearchAsync())?.rows[0].goodsNo;
                if (goodsNo == null)
                {
                    throw new Exception("goodsNo Null");
                }
                Assert.That(await app.AvatarMarketApi.GetAvatarMarketItemAsync(goodsNo.Value), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public async Task GetAvatarMarketQuoteSearchAsync()
        {
            try
            {
                Assert.That(await app.AvatarMarketApi.GetAvatarMarketQuoteSearchAsync(), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public async Task GetAvatarMarketQuoteAsync()
        {
            try
            {
                var goodsNo = (await app.AvatarMarketApi.GetAvatarMarketQuoteSearchAsync())?.rows[0].goodsNo;
                if (goodsNo == null)
                {
                    throw new Exception("goodsNo Null");
                }
                Assert.That(await app.AvatarMarketApi.GetAvatarMarketQuoteAsync(goodsNo.Value), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public async Task GetAvatarMarketHashtagAsync()
        {
            try
            {
                Assert.That(await app.AvatarMarketApi.GetAvatarMarketHashtagAsync(), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion

        #region Items API
        [TestCase(itemName01)]
        [TestCase(itemName02)]
        [TestCase(itemName03)]
        [TestCase(itemName04)]
        [TestCase(itemName05)]
        [TestCase(itemName06)]
        [TestCase(itemName07)]
        [TestCase(itemName08)]
        [TestCase(itemName09)]
        [TestCase(itemName10)]
        [TestCase(itemName11)]
        [TestCase(itemName12)]
        public async Task GetItemSearchAsync(string itemName = "")
        {
            try
            {
                Assert.That(await app.ItemsApi.GetItemSearchAsync(itemName), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(itemId01)]
        [TestCase(itemId02)]
        [TestCase(itemId03)]
        [TestCase(itemId04)]
        [TestCase(itemId05)]
        [TestCase(itemId06)]
        [TestCase(itemId07)]
        [TestCase(itemId08)]
        [TestCase(itemId09)]
        [TestCase(itemId10)]
        [TestCase(itemId11)]
        [TestCase(itemId12)]
        public async Task GetItemDetailAsync(string itemId)
        {
            try
            {
                Assert.That(await app.ItemsApi.GetItemDetailAsync(itemId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase("근원을 삼킨 도")]
        [TestCase("억제된 마력의 팔찌")]
        [TestCase("스톰라이더")]
        public async Task GetItemShopSalesInfoAsync(string itemName)
        {
            try
            {
                var result = await app.ItemsApi.GetItemSearchAsync(itemName);
                Assert.That(await app.ItemsApi.GetItemShopSalesInfoAsync(result.rows[0].itemId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion

        #region Item Hashtag API
        [Test]
        public async Task GetItemHashtagAsync()
        {
            try
            {
                Assert.That(await app.ItemHashtagApi.GetItemHashtagAsync(), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion

        #region Set Items API
        [TestCase(setItemName1)]
        public async Task GetSetItemSearchAsync(string setItemName)
        {
            try
            {
                Assert.That(await app.SetItemsApi.GetSetItemSearchAsync(setItemName), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase(setItemId1)]
        public async Task GetSetItemDetailAsync(string setItemId)
        {
            try
            {
                Assert.That(await app.SetItemsApi.GetSetItemDetailAsync(setItemId), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion

        #region Custom API
        [TestCase("e1e12366bb4e3d171c308fa539ede0d5", "74d036a7d6227d43ea6b9aa65611d408")]
        public async Task GetEquipmentSetItemActivationInfoAsync(string id1, string id2)
        {
            try
            {
                var setItemIds = new List<string>() { id1, id2 };
                Assert.That(await app.CustomApi.GetEquipmentSetItemActivationInfoAsync(setItemIds), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion

        #region Multi API
        [TestCase("6ed94ca4a1c10af06f5c79969a1d30e8", "2dfaf59a126c85104771d33ecf099e6f")]
        public async Task GetSetItemDetailAsync(string id1, string id2)
        {
            try
            {
                var itemIds = new List<string>() { id1, id2 };
                Assert.That(await app.MultiApi.GetMultiItemSearchAsync(itemIds), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestCase("ddaa9c29eb95033a772f40c48b6f429e", "861e52afdbbcbcc015188a5d77f30dc1")]
        public async Task GetMultiSetItemSearchAsync(string id1, string id2)
        {
            try
            {
                var setItemIds = new List<string>() { id1, id2 };
                Assert.That(await app.MultiApi.GetMultiSetItemSearchAsync(setItemIds), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion

        #region Jobs API
        [Test]
        public async Task GetJobInfoAsync()
        {
            try
            {
                Assert.That(await app.JobsApi.GetJobInfoAsync(), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion

        #region Skills API
        [Test]
        public async Task GetSkillListByJobGrowAsync()
        {
            try
            {
                Assert.That(await app.SkillsApi.GetSkillListByJobGrowAsync(DnfJobGrow.Asura), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public async Task GetSkillInfoByJobAsync()
        {
            try
            {
                Assert.That(await app.SkillsApi.GetSkillInfoByJobAsync(DnfJob.MaleSlayer, "eb71e1d82d92c7e1d40500a0dcd77aa6"), Is.Not.Null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        #endregion
    }
}