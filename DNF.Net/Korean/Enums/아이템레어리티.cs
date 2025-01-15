using System.Drawing;

namespace DNF.Net.Korean.Enums
{
	public class 아이템레어리티구조체(string id, string name, Color color)
	{
		public string Id { get; set; } = id;
		public string Name { get; set; } = name;
		public Color Color { get; set; } = color;
	}

	public class 아이템레어리티
	{
		public static readonly 아이템레어리티구조체 커먼 = new("common", "커먼", Color.FromArgb(255, 255, 255));
		public static readonly 아이템레어리티구조체 언커먼 = new("uncommon", "언커먼", Color.FromArgb(104, 213, 237));
		public static readonly 아이템레어리티구조체 레어 = new("rare", "레어", Color.FromArgb(179, 107, 255));
		public static readonly 아이템레어리티구조체 유니크 = new("unique", "유니크", Color.FromArgb(255, 0, 255));
		public static readonly 아이템레어리티구조체 에픽 = new("epic", "에픽", Color.FromArgb(255, 180, 0));
		public static readonly 아이템레어리티구조체 크로니클 = new("chronicle", "크로니클", Color.FromArgb(255, 102, 102));
		public static readonly 아이템레어리티구조체 레전더리 = new("legendary", "레전더리", Color.FromArgb(255, 120, 0));
		public static readonly 아이템레어리티구조체 신화 = new("mythic", "신화", Color.FromArgb(0, 0, 0));
	}
}
