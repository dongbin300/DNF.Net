using DNF.Net.Korean.Enums;
using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Korean.Applications.Apis
{
	public class 아바타마켓API(string apiKey)
	{
		private readonly HttpClient client = new();
		private readonly string _baseUrl = "https://api.neople.co.kr/df/avatar-market";

		public async Task<DnfApplicationRecords<DnfApplicationAvatarMarketItemSearch>?> 아바타_마켓_상품_검색(string title = "", IList<string>? hashtags = null, 검색타입 wordType = 검색타입.동일단어, string jobId = "", 아바타마켓엠블렘 emblemCode = 아바타마켓엠블렘.없음, bool? avatarSet = null, string avatarRarity = "", int? minPrice = null, int? maxPrice = null, int? minAvatarCount = null, int? maxAvatarCount = null, 정렬? price = null, 정렬? goodsNo = null, int limit = 10)
		{
			var parameters = new Dictionary<string, string?>
			{
				{ "title", title },
				{ "hashtag", GetSerializedValues(hashtags) },
				{ "wordType", wordType.ToString() },
				{ "q",
					GetSerializedSubParameters(new Dictionary<string, string?>
					{
						{"jobId", jobId },
						{"emblemCode", ((int)emblemCode).ToString() },
						{"avatarSet", avatarSet?.ToString() },
						{"avatarRarity", avatarRarity },
						{"minPrice", minPrice?.ToString() },
						{"maxPrice", maxPrice?.ToString() },
						{"minAvatarCount", minAvatarCount?.ToString() },
						{"maxAvatarCount", maxAvatarCount?.ToString() }
					})
				},
				{ "sort",
					GetSerializedSubParameters(new Dictionary<string, string?>
					{
						{ "price", price.ToString() },
						{ "goodsNo", goodsNo.ToString() }
					})
				},
				{ "limit", limit.ToString() }
			};

			var url = GetDnfApplicationUrl($"{_baseUrl}/sale", apiKey, parameters);

			try
			{
				return await RequestAsync<DnfApplicationRecords<DnfApplicationAvatarMarketItemSearch>>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationAvatarMarketItemSearch?> 아바타_마켓_상품_조회(int goodsNo)
		{
			var url = GetDnfApplicationUrl($"{_baseUrl}/sale/{goodsNo}", apiKey);

			try
			{
				return await RequestAsync<DnfApplicationAvatarMarketItemSearch>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationRecords<DnfApplicationAvatarMarketItemSearch>?> 아바타_마켓_상품_시세_검색(string title = "", IList<string>? hashtags = null, 검색타입 wordType = 검색타입.동일단어, string jobId = "", 아바타마켓엠블렘 emblemCode = 아바타마켓엠블렘.없음, bool? avatarSet = null, string avatarRarity = "", int? minPrice = null, int? maxPrice = null, int? minAvatarCount = null, int? maxAvatarCount = null, 정렬? price = null, 정렬? goodsNo = null, int limit = 10)
		{
			var parameters = new Dictionary<string, string?>
			{
				{ "title", title },
				{ "hashtag", GetSerializedValues(hashtags) },
				{ "wordType", wordType.ToString() },
				{ "q",
					GetSerializedSubParameters(new Dictionary<string, string?>
					{
						{"jobId", jobId },
						{"emblemCode", ((int)emblemCode).ToString() },
						{"avatarSet", avatarSet?.ToString() },
						{"avatarRarity", avatarRarity },
						{"minPrice", minPrice?.ToString() },
						{"maxPrice", maxPrice?.ToString() },
						{"minAvatarCount", minAvatarCount?.ToString() },
						{"maxAvatarCount", maxAvatarCount?.ToString() }
					})
				},
				{ "sort",
					GetSerializedSubParameters(new Dictionary<string, string?>
					{
						{ "price", price.ToString() },
						{ "goodsNo", goodsNo.ToString() }
					})
				},
				{ "limit", limit.ToString() }
			};

			var url = GetDnfApplicationUrl($"{_baseUrl}/sold", apiKey, parameters);

			try
			{
				return await RequestAsync<DnfApplicationRecords<DnfApplicationAvatarMarketItemSearch>>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationAvatarMarketItemSearch?> 아바타_마켓_상품_시세_조회(int goodsNo)
		{
			var url = GetDnfApplicationUrl($"{_baseUrl}/sold/{goodsNo}", apiKey);

			try
			{
				return await RequestAsync<DnfApplicationAvatarMarketItemSearch>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationRecords<string>?> 아바타_마켓_해시태그_조회()
		{
			var url = GetDnfApplicationUrl($"{_baseUrl}/hashtag", apiKey);

			try
			{
				return await RequestAsync<DnfApplicationRecords<string>>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}
	}
}
