namespace DNF.Net.Korean.Enums
{
    public class 직업구조체
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public 직업구조체(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class 직업
    {
        public static readonly 직업구조체 남귀검사 = new ("41f1cdc2ff58bb5fdc287be0db2a8df3", "귀검사(남)");
        public static readonly 직업구조체 여귀검사 = new("1645c45aabb008c98406b3a16447040d", "귀검사(여)");
        public static readonly 직업구조체 남격투가 = new("ca0f0e0e9e1d55b5f9955b03d9dd213c", "격투가(남)");
        public static readonly 직업구조체 여격투가 = new("a7a059ebe9e6054c0644b40ef316d6e9", "격투가(여)");
        public static readonly 직업구조체 남거너 = new("afdf3b989339de478e85b614d274d1ef", "거너(남)");
        public static readonly 직업구조체 여거너 = new("944b9aab492c15a8474f96947ceeb9e4", "거너(여)");
        public static readonly 직업구조체 남마법사 = new("a5ccbaf5538981c6ef99b236c0a60b73", "마법사(남)");
        public static readonly 직업구조체 여마법사 = new("3909d0b188e9c95311399f776e331da5", "마법사(여)");
        public static readonly 직업구조체 남프리스트 = new("f6a4ad30555b99b499c07835f87ce522", "프리스트(남)");
        public static readonly 직업구조체 여프리스트 = new("0c1b401bb09241570d364420b3ba3fd7", "프리스트(여)");
        public static readonly 직업구조체 도적 = new("ddc49e9ad1ff72a00b53c6cff5b1e920", "도적");
        public static readonly 직업구조체 나이트 = new("0ee8fa5dc525c1a1f23fc6911e921e4a", "나이트");
        public static readonly 직업구조체 마창사 = new("3deb7be5f01953ac8b1ecaa1e25e0420", "마창사");
        public static readonly 직업구조체 총검사 = new("986c2b3d72ee0e4a0b7fcfbe786d4e02", "총검사");
        public static readonly 직업구조체 크리에이터 = new("b522a95d819a5559b775deb9a490e49a", "크리에이터");
        public static readonly 직업구조체 다크나이트 = new("17e417b31686389eebff6d754c3401ea", "다크나이트");
    }
}
