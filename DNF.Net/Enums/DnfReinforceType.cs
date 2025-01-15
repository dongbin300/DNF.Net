namespace DNF.Net.Enums
{
    public class DnfReinforceTypeEnum(string id, string name)
	{
		public string Id { get; set; } = id;
		public string Name { get; set; } = name;
	}

    public class DnfReinforceType
    {
        public static readonly DnfReinforceTypeEnum Reinforcement = new("reinforcement", "강화");
        public static readonly DnfReinforceTypeEnum Amplification = new("amplification", "증폭");
        public static readonly DnfReinforceTypeEnum Remodeling = new("remodeling", "개조");
    }
}
