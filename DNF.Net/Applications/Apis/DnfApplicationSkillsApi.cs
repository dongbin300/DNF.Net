using DNF.Net.Enums;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Applications.Apis
{
    public class DnfApplicationSkillsApi
    {
        private readonly HttpClient client = new();
        private readonly string _baseUrl = "https://api.neople.co.kr/df/skills";
        private string apiKey;

        public DnfApplicationSkillsApi(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<DnfApplicationSkills?> GetSkillListByJobGrowAsync(DnfJobGrowEnum jobGrow)
        {
            var jobId = jobGrow.Job.Id;

            var parameters = new Dictionary<string, string?>
            {
                { "jobGrowId", jobGrow.Id }
            };

            var url = GetDnfApplicationUrl($"{_baseUrl}/{jobId}", apiKey, parameters);

            try
            {
                return await RequestAsync<DnfApplicationSkills>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }

        public async Task<DnfApplicationSkills?> GetSkillInfoByJobAsync(DnfJobEnum job, string skillId)
        {
            var jobId = job.Id;

            var url = GetDnfApplicationUrl($"{_baseUrl}/{jobId}/{skillId}", apiKey);

            try
            {
                return await RequestAsync<DnfApplicationSkills>(client, url).ConfigureAwait(false);
            }
            catch
            {
                throw;
            }
        }
    }
}
