using DNF.Net.Korean.Enums;

using static DNF.Net.Applications.BaseApplication;
using static DNF.Net.Applications.DnfApplication;
using static DNF.Net.Objects.Models.DnfApplicationModels;

namespace DNF.Net.Korean.Applications.Apis
{
	public class 스킬API(string apiKey)
	{
		private readonly HttpClient client = new();
		private readonly string _baseUrl = "https://api.neople.co.kr/df/skills";

		public async Task<DnfApplicationSkills?> 직업별_스킬_리스트(각성직업구조체 jobGrow)
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

		public async Task<DnfApplicationSkills?> 직업별_스킬_상세_정보_조회(직업구조체 job, string skillId)
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
