using System.Drawing;

namespace DNF.Net.Enums
{
    public class DnfItemRarityEnum(string id, string name, Color color)
	{
		public string Id { get; set; } = id;
		public string Name { get; set; } = name;
		public Color Color { get; set; } = color;
	}

    public class DnfItemRarity
    {
        /// <summary>
        /// 커먼
        /// </summary>
        public static readonly DnfItemRarityEnum Common = new("common", "커먼", Color.FromArgb(255, 255, 255));

        /// <summary>
        /// 언커먼
        /// </summary>
        public static readonly DnfItemRarityEnum Uncommon = new("uncommon", "언커먼", Color.FromArgb(104, 213, 237));

        /// <summary>
        /// 레어
        /// </summary>
        public static readonly DnfItemRarityEnum Rare = new("rare", "레어", Color.FromArgb(179, 107, 255));

        /// <summary>
        /// 유니크
        /// </summary>
        public static readonly DnfItemRarityEnum Unique = new("unique", "유니크", Color.FromArgb(255, 0, 255));

        /// <summary>
        /// 에픽
        /// </summary>
        public static readonly DnfItemRarityEnum Epic = new("epic", "에픽", Color.FromArgb(255, 180, 0));

        /// <summary>
        /// 크로니클
        /// </summary>
        public static readonly DnfItemRarityEnum Chronicle = new("chronicle", "크로니클", Color.FromArgb(255, 102, 102));

        /// <summary>
        /// 레전더리
        /// </summary>
        public static readonly DnfItemRarityEnum Legendary = new("legendary", "레전더리", Color.FromArgb(255, 120, 0));

        /// <summary>
        /// 신화
        /// </summary>
        public static readonly DnfItemRarityEnum Mythic = new("mythic", "신화", Color.FromArgb(0, 0, 0));
    }
}