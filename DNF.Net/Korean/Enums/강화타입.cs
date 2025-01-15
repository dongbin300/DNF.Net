namespace DNF.Net.Korean.Enums
{
	public class 강화타입구조체(string id, string name)
	{
		public string Id { get; set; } = id;
		public string Name { get; set; } = name;
	}

	public class 강화타입
	{
		public static readonly 강화타입구조체 강화 = new("reinforcement", "강화");
		public static readonly 강화타입구조체 증폭 = new("amplification", "증폭");
		public static readonly 강화타입구조체 개조 = new("remodeling", "개조");
	}
}
