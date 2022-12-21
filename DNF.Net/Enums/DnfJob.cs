namespace DNF.Net.Enums
{
    public class DnfJobEnum
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public DnfJobEnum(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class DnfJob
    {
        /// <summary>
        /// 귀검사(남)
        /// </summary>
        public static readonly DnfJobEnum MaleSlayer = new("41f1cdc2ff58bb5fdc287be0db2a8df3", "귀검사(남)");

        /// <summary>
        /// 귀검사(여)
        /// </summary>
        public static readonly DnfJobEnum FemaleSlayer = new("1645c45aabb008c98406b3a16447040d", "귀검사(여)");

        /// <summary>
        /// 격투가(남)
        /// </summary>
        public static readonly DnfJobEnum MaleFighter = new("ca0f0e0e9e1d55b5f9955b03d9dd213c", "격투가(남)");

        /// <summary>
        /// 격투가(여)
        /// </summary>
        public static readonly DnfJobEnum FemaleFighter = new("a7a059ebe9e6054c0644b40ef316d6e9", "격투가(여)");

        /// <summary>
        /// 거너(남)
        /// </summary>
        public static readonly DnfJobEnum MaleGunner = new("afdf3b989339de478e85b614d274d1ef", "거너(남)");

        /// <summary>
        /// 거너(여)
        /// </summary>
        public static readonly DnfJobEnum FemaleGunner = new("944b9aab492c15a8474f96947ceeb9e4", "거너(여)");

        /// <summary>
        /// 마법사(남)
        /// </summary>
        public static readonly DnfJobEnum MaleMage = new("a5ccbaf5538981c6ef99b236c0a60b73", "마법사(남)");

        /// <summary>
        /// 마법사(여)
        /// </summary>
        public static readonly DnfJobEnum FemaleMage = new("3909d0b188e9c95311399f776e331da5", "마법사(여)");

        /// <summary>
        /// 프리스트(남)
        /// </summary>
        public static readonly DnfJobEnum MalePriest = new("f6a4ad30555b99b499c07835f87ce522", "프리스트(남)");

        /// <summary>
        /// 프리스트(여)
        /// </summary>
        public static readonly DnfJobEnum FemalePriest = new("0c1b401bb09241570d364420b3ba3fd7", "프리스트(여)");

        /// <summary>
        /// 도적
        /// </summary>
        public static readonly DnfJobEnum Thief = new("ddc49e9ad1ff72a00b53c6cff5b1e920", "도적");

        /// <summary>
        /// 나이트
        /// </summary>
        public static readonly DnfJobEnum Knight = new("0ee8fa5dc525c1a1f23fc6911e921e4a", "나이트");

        /// <summary>
        /// 마창사
        /// </summary>
        public static readonly DnfJobEnum DemonicLancer = new("3deb7be5f01953ac8b1ecaa1e25e0420", "마창사");

        /// <summary>
        /// 총검사
        /// </summary>
        public static readonly DnfJobEnum Agent = new("986c2b3d72ee0e4a0b7fcfbe786d4e02", "총검사");

        /// <summary>
        /// 크리에이터
        /// </summary>
        public static readonly DnfJobEnum Creator = new("b522a95d819a5559b775deb9a490e49a", "크리에이터");

        /// <summary>
        /// 다크나이트
        /// </summary>
        public static readonly DnfJobEnum DarkKnight = new("17e417b31686389eebff6d754c3401ea", "다크나이트");
    }
}