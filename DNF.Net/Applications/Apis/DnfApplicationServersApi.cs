using DNF.Net.Enums;
using DNF.Net.Objects.Models;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Applications.Apis
{
    public class DnfApplicationServersApi(string apiKey)
	{
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/servers";

		public async Task<DnfApplicationRecords<DnfApplicationServer>?> GetServerInfoAsync()
        {
            var url = GetDnfApplicationUrl(_baseUrl, apiKey);
            return await RequestAsync<DnfApplicationRecords<DnfApplicationServer>>(client, url).ConfigureAwait(false);
        }

        public async Task<DnfApplicationRecords<DnfApplicationServerCharacter>?> GetCharacterInfoAsync(DnfServer server, string characterName, DnfJobEnum? job = null, DnfJobGrowEnum? jobGrow = null, WordType wordType = WordType.Match, int limit = 10)
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

        public async Task<DnfApplicationCharacterBasic?> GetCharacterBasicInfoAsync(DnfServer server, string characterId)
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

        public async Task<DnfApplicationCharacterTimeline?> GetCharacterTimelineInfoAsync(DnfServer server, string characterId, DateTime? startDate = null, DateTime? endDate = null, IList<DnfTimeline>? timelines = null, int limit = 10, string next = "")
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

        public async Task<DnfApplicationCharacterStatusInfo?> GetCharacterStatusInfoAsync(DnfServer server, string characterId)
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

        public async Task<DnfApplicationCharacterEquipment?> GetCharacterEquipmentAsync(DnfServer server, string characterId)
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

        public async Task<DnfApplicationCharacterAvatar?> GetCharacterAvatarAsync(DnfServer server, string characterId)
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

        public async Task<DnfApplicationCharacterCreature?> GetCharacterCreatureAsync(DnfServer server, string characterId)
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

        public async Task<DnfApplicationCharacterFlag?> GetCharacterFlagAsync(DnfServer server, string characterId)
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

        public async Task<DnfApplicationCharacterTalismans?> GetCharacterTalismanAsync(DnfServer server, string characterId)
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

        public async Task<DnfApplicationCharacterSkillStyle?> GetCharacterSkillStyleAsync(DnfServer server, string characterId)
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

        public async Task<DnfApplicationCharacterBuffSkillEquipment?> GetCharacterBuffSkillEquipmentAsync(DnfServer server, string characterId)
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

        public async Task<DnfApplicationCharacterBuffSkillAvatar?> GetCharacterBuffSkillAvatarAsync(DnfServer server, string characterId)
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

        public async Task<DnfApplicationCharacterBuffSkillCreature?> GetCharacterBuffSkillCreatureAsync(DnfServer server, string characterId)
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
