namespace DNF.Net.Enums
{
    public class DnfReinforceTypeEnum
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public DnfReinforceTypeEnum(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class DnfReinforceType
    {
        public static readonly DnfReinforceTypeEnum Reinforcement = new("reinforcement", "강화");
        public static readonly DnfReinforceTypeEnum Amplification = new("amplification", "증폭");
        public static readonly DnfReinforceTypeEnum Remodeling = new("remodeling", "개조");
    }
}
