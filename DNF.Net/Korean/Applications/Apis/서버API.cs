using DNF.Net.Korean.Enums;
using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Korean.Applications.Apis
{
	public class 서버API(string apiKey)
	{
		private readonly HttpClient client = new();
		private readonly string _baseUrl = "https://api.neople.co.kr/df/servers";

		public async Task<DnfApplicationRecords<DnfApplicationServer>?> 서버_정보()
		{
			var url = GetDnfApplicationUrl(_baseUrl, apiKey);
			return await RequestAsync<DnfApplicationRecords<DnfApplicationServer>>(client, url).ConfigureAwait(false);
		}

		public async Task<DnfApplicationRecords<DnfApplicationServerCharacter>?> 캐릭터_검색(서버 server, string characterName, 직업구조체? job = null, 각성직업구조체? jobGrow = null, 검색타입 wordType = 검색타입.동일단어, int limit = 10)
		{
			var parameters = new Dictionary<string, string?>
			{
				{ "characterName", characterName },
				{ "jobId", job?.Id },
				{ "jobGrowId", jobGrow?.Id },
				{ "wordType", wordType.ToString() },
				{ "limit", limit.ToString() }
			};

			var url = GetDnfApplicationUrl($"{_baseUrl}/{server}/characters", apiKey, parameters);

			try
			{
				return await RequestAsync<DnfApplicationRecords<DnfApplicationServerCharacter>>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationCharacterBasic?> 캐릭터_기본_정보_조회(서버 server, string characterId)
		{
			var url = GetDnfApplicationUrl($"{_baseUrl}/{server}/characters/{characterId}", apiKey);

			try
			{
				return await RequestAsync<DnfApplicationCharacterBasic>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationCharacterTimeline?> 캐릭터_타임라인_정보_조회(서버 server, string characterId, DateTime? startDate = null, DateTime? endDate = null, IList<타임라인>? timelines = null, int limit = 10, string next = "")
		{
			var parameters = new Dictionary<string, string?>
			{
				{ "startDate", startDate?.ToString("yyyy-MM-dd HH:mm") },
				{ "endDate", endDate?.ToString("yyyy-MM-dd HH:mm") },
				{ "code", GetSerializedValues(timelines?.Cast<int>().Select(x => x.ToString())) },
				{ "limit", limit.ToString() },
				{ "next", next }
			};

			var url = GetDnfApplicationUrl($"{_baseUrl}/{server}/characters/{characterId}/timeline", apiKey, parameters);

			try
			{
				return await RequestAsync<DnfApplicationCharacterTimeline>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationCharacterStatusInfo?> 캐릭터_능력치_정보_조회(서버 server, string characterId)
		{
			var url = GetDnfApplicationUrl($"{_baseUrl}/{server}/characters/{characterId}/status", apiKey);

			try
			{
				return await RequestAsync<DnfApplicationCharacterStatusInfo>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationCharacterEquipment?> 캐릭터_장착_장비_조회(서버 server, string characterId)
		{
			var url = GetDnfApplicationUrl($"{_baseUrl}/{server}/characters/{characterId}/equip/equipment", apiKey);

			try
			{
				return await RequestAsync<DnfApplicationCharacterEquipment>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationCharacterAvatar?> 캐릭터_장착_아바타_조회(서버 server, string characterId)
		{
			var url = GetDnfApplicationUrl($"{_baseUrl}/{server}/characters/{characterId}/equip/avatar", apiKey);

			try
			{
				return await RequestAsync<DnfApplicationCharacterAvatar>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationCharacterCreature?> 캐릭터_장착_크리쳐_조회(서버 server, string characterId)
		{
			var url = GetDnfApplicationUrl($"{_baseUrl}/{server}/characters/{characterId}/equip/creature", apiKey);

			try
			{
				return await RequestAsync<DnfApplicationCharacterCreature>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationCharacterFlag?> 캐릭터_장착_휘장_조회(서버 server, string characterId)
		{
			var url = GetDnfApplicationUrl($"{_baseUrl}/{server}/characters/{characterId}/equip/flag", apiKey);

			try
			{
				return await RequestAsync<DnfApplicationCharacterFlag>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationCharacterTalismans?> 캐릭터_장착_탈리스만_조회(서버 server, string characterId)
		{
			var url = GetDnfApplicationUrl($"{_baseUrl}/{server}/characters/{characterId}/equip/talisman", apiKey);

			try
			{
				return await RequestAsync<DnfApplicationCharacterTalismans>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationCharacterSkillStyle?> 캐릭터_스킬_스타일_조회(서버 server, string characterId)
		{
			var url = GetDnfApplicationUrl($"{_baseUrl}/{server}/characters/{characterId}/skill/style", apiKey);

			try
			{
				return await RequestAsync<DnfApplicationCharacterSkillStyle>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationCharacterBuffSkillEquipment?> 캐릭터_버프_스킬_강화_장착_장비_조회(서버 server, string characterId)
		{
			var url = GetDnfApplicationUrl($"{_baseUrl}/{server}/characters/{characterId}/skill/buff/equip/equipment", apiKey);

			try
			{
				return await RequestAsync<DnfApplicationCharacterBuffSkillEquipment>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationCharacterBuffSkillAvatar?> 캐릭터_버프_스킬_강화_장착_아바타_조회(서버 server, string characterId)
		{
			var url = GetDnfApplicationUrl($"{_baseUrl}/{server}/characters/{characterId}/skill/buff/equip/avatar", apiKey);

			try
			{
				return await RequestAsync<DnfApplicationCharacterBuffSkillAvatar>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}

		public async Task<DnfApplicationCharacterBuffSkillCreature?> 캐릭터_버프_스킬_강화_장착_크리쳐_조회(서버 server, string characterId)
		{
			var url = GetDnfApplicationUrl($"{_baseUrl}/{server}/characters/{characterId}/skill/buff/equip/creature", apiKey);

			try
			{
				return await RequestAsync<DnfApplicationCharacterBuffSkillCreature>(client, url).ConfigureAwait(false);
			}
			catch
			{
				throw;
			}
		}
	}
}
