namespace DNF.Net.Enums
{
    public class DnfJobGrowEnum(string id, string name, DnfJobEnum job)
	{
		public string Id { get; set; } = id;
		public string Name { get; set; } = name;
		public DnfJobEnum Job { get; set; } = job;
	}

    public class DnfJobGrow
    {
        #region 귀검사(남)
        /// <summary>
        /// 웨펀마스터
        /// </summary>
        public static readonly DnfJobGrowEnum BladeMaster = new("df3870efe8e8754011cd12fa03cd275f", "웨펀마스터", DnfJob.MaleSlayer);
        /// <summary>
        /// 검성
        /// </summary>
        public static readonly DnfJobGrowEnum GrandMaster = new("4ec01f4ae3728c080f28a72213b6df10", "검성", DnfJob.MaleSlayer);
        /// <summary>
        /// 검신
        /// </summary>
        public static readonly DnfJobGrowEnum Omniblade = new("80ec67d0356defa46a989914caca5820", "검신", DnfJob.MaleSlayer);
        /// <summary>
        /// 眞 웨펀마스터
        /// </summary>
        public static readonly DnfJobGrowEnum NeoBladeMaster = new("37495b941da3b1661bc900e68ef3b2c6", "眞 웨펀마스터", DnfJob.MaleSlayer);
        /// <summary>
        /// 소울브링어
        /// </summary>
        public static readonly DnfJobGrowEnum SoulBender = new("1ea78ae210f681a799feb4403a5c1e85", "소울브링어", DnfJob.MaleSlayer);
        /// <summary>
        /// 소울테이커
        /// </summary>
        public static readonly DnfJobGrowEnum SoulReaper = new("981d675414f83b926db5f54e5347eec0", "소울테이커", DnfJob.MaleSlayer);
        /// <summary>
        /// 다크로드
        /// </summary>
        public static readonly DnfJobGrowEnum DarkLord = new("8022a99e29b5e4845985fe1d79a233f3", "다크로드", DnfJob.MaleSlayer);
        /// <summary>
        /// 眞 소울브링어
        /// </summary>
        public static readonly DnfJobGrowEnum NeoSoulBender = new("618326026de1a1f1cfba5dbd0b8396e7", "眞 소울브링어", DnfJob.MaleSlayer);
        /// <summary>
        /// 버서커
        /// </summary>
        public static readonly DnfJobGrowEnum Berserker = new("a9a4ef4552d46e39cf6c874a51126410", "버서커", DnfJob.MaleSlayer);
        /// <summary>
        /// 헬벤터
        /// </summary>
        public static readonly DnfJobGrowEnum HellBringer = new("460822c3780a9bc3fbe9485cc89c44a4", "헬벤터", DnfJob.MaleSlayer);
        /// <summary>
        /// 블러드 이블
        /// </summary>
        public static readonly DnfJobGrowEnum BloodEvil = new("15ce2751ab9c8302f39636cdb7c3dcfa", "블러드 이블", DnfJob.MaleSlayer);
        /// <summary>
        /// 眞 버서커
        /// </summary>
        public static readonly DnfJobGrowEnum NeoBerserker = new("6d459bc74ba73ee4fe5cdc4655400193", "眞 버서커", DnfJob.MaleSlayer);
        /// <summary>
        /// 아수라
        /// </summary>
        public static readonly DnfJobGrowEnum Asura = new("4a1459a4fa3c7f59b6da2e43382ed0b9", "아수라", DnfJob.MaleSlayer);
        /// <summary>
        /// 대암흑천
        /// </summary>
        public static readonly DnfJobGrowEnum SilentEye = new("faf8fc6f0cd4c0f84f0035e23bd4fa19", "대암흑천", DnfJob.MaleSlayer);
        /// <summary>
        /// 인다라천
        /// </summary>
        public static readonly DnfJobGrowEnum Indra = new("64bbd751c0fcae0e74758b871a2296c1", "인다라천", DnfJob.MaleSlayer);
        /// <summary>
        /// 眞 아수라
        /// </summary>
        public static readonly DnfJobGrowEnum NeoAsura = new("c9b492038ee3ca8d27d7004cf58d59f3", "眞 아수라", DnfJob.MaleSlayer);
        /// <summary>
        /// 검귀
        /// </summary>
        public static readonly DnfJobGrowEnum Ghostblade = new("a59ba19824dc3292b6075e29b3862ad3", "검귀", DnfJob.MaleSlayer);
        /// <summary>
        /// 야차
        /// </summary>
        public static readonly DnfJobGrowEnum Yaksha = new("a427ec3e94087c64cb4144379c3a0d59", "야차", DnfJob.MaleSlayer);
        /// <summary>
        /// 악귀나찰
        /// </summary>
        public static readonly DnfJobGrowEnum Rakshasa = new("3ff5b661925ac59d1ca290b05ca914cc", "악귀나찰", DnfJob.MaleSlayer);
        /// <summary>
        /// 眞 검귀
        /// </summary>
        public static readonly DnfJobGrowEnum NeoGhostblade = new("92da05ec93fb43406e193ffb9a2a629b", "眞 검귀", DnfJob.MaleSlayer);
        #endregion

        #region 귀검사(여)
        /// <summary>
        /// 소드마스터
        /// </summary>
        public static readonly DnfJobGrowEnum SwordMaster = new("df3870efe8e8754011cd12fa03cd275f", "소드마스터", DnfJob.FemaleSlayer);
        /// <summary>
        /// 노블레스
        /// </summary>
        public static readonly DnfJobGrowEnum Noblesse = new("4ec01f4ae3728c080f28a72213b6df10", "노블레스", DnfJob.FemaleSlayer);
        /// <summary>
        /// 마제스티
        /// </summary>
        public static readonly DnfJobGrowEnum Majesty = new("80ec67d0356defa46a989914caca5820", "마제스티", DnfJob.FemaleSlayer);
        /// <summary>
        /// 眞 소드마스터
        /// </summary>
        public static readonly DnfJobGrowEnum NeoSwordMaster = new("37495b941da3b1661bc900e68ef3b2c6", "眞 소드마스터", DnfJob.FemaleSlayer);
        /// <summary>
        /// 데몬슬레이어
        /// </summary>
        public static readonly DnfJobGrowEnum DemonSlayer = new("a9a4ef4552d46e39cf6c874a51126410", "데몬슬레이어", DnfJob.FemaleSlayer);
        /// <summary>
        /// 검마
        /// </summary>
        public static readonly DnfJobGrowEnum Demonbane = new("460822c3780a9bc3fbe9485cc89c44a4", "검마", DnfJob.FemaleSlayer);
        /// <summary>
        /// 디어사이드
        /// </summary>
        public static readonly DnfJobGrowEnum Deicide = new("15ce2751ab9c8302f39636cdb7c3dcfa", "디어사이드", DnfJob.FemaleSlayer);
        /// <summary>
        /// 眞 데몬슬레이어
        /// </summary>
        public static readonly DnfJobGrowEnum NeoDemonSlayer = new("6d459bc74ba73ee4fe5cdc4655400193", "眞 데몬슬레이어", DnfJob.FemaleSlayer);
        /// <summary>
        /// 베가본드
        /// </summary>
        public static readonly DnfJobGrowEnum Vagabond = new("4a1459a4fa3c7f59b6da2e43382ed0b9", "베가본드", DnfJob.FemaleSlayer);
        /// <summary>
        /// 검호
        /// </summary>
        public static readonly DnfJobGrowEnum Dualist = new("faf8fc6f0cd4c0f84f0035e23bd4fa19", "검호", DnfJob.FemaleSlayer);
        /// <summary>
        /// 검제
        /// </summary>
        public static readonly DnfJobGrowEnum SwordDancer = new("64bbd751c0fcae0e74758b871a2296c1", "검제", DnfJob.FemaleSlayer);
        /// <summary>
        /// 眞 베가본드
        /// </summary>
        public static readonly DnfJobGrowEnum NeoVagabond = new("c9b492038ee3ca8d27d7004cf58d59f3", "眞 베가본드", DnfJob.FemaleSlayer);
        /// <summary>
        /// 다크템플러
        /// </summary>
        public static readonly DnfJobGrowEnum DarkTemplar = new("1ea78ae210f681a799feb4403a5c1e85", "다크템플러", DnfJob.FemaleSlayer);
        /// <summary>
        /// 암제
        /// </summary>
        public static readonly DnfJobGrowEnum DarkEmpress = new("981d675414f83b926db5f54e5347eec0", "암제", DnfJob.FemaleSlayer);
        /// <summary>
        /// 네메시스
        /// </summary>
        public static readonly DnfJobGrowEnum Nemesis = new("8022a99e29b5e4845985fe1d79a233f3", "네메시스", DnfJob.FemaleSlayer);
        /// <summary>
        /// 眞 다크템플러
        /// </summary>
        public static readonly DnfJobGrowEnum NeoDarkTemplar = new("618326026de1a1f1cfba5dbd0b8396e7", "眞 다크템플러", DnfJob.FemaleSlayer);
        /// <summary>
        /// 블레이드
        /// </summary>
        public static readonly DnfJobGrowEnum Spectre = new("a59ba19824dc3292b6075e29b3862ad3", "블레이드", DnfJob.FemaleSlayer);
        /// <summary>
        /// 리벨리온
        /// </summary>
        public static readonly DnfJobGrowEnum Rebellion = new("a427ec3e94087c64cb4144379c3a0d59", "리벨리온", DnfJob.FemaleSlayer);
        /// <summary>
        /// 벤데타
        /// </summary>
        public static readonly DnfJobGrowEnum Vendetta = new("3ff5b661925ac59d1ca290b05ca914cc", "벤데타", DnfJob.FemaleSlayer);
        /// <summary>
        /// 眞 블레이드
        /// </summary>
        public static readonly DnfJobGrowEnum NeoSpectre = new("92da05ec93fb43406e193ffb9a2a629b", "眞 블레이드", DnfJob.FemaleSlayer);
        #endregion

        #region 격투가(남)
        /// <summary>
        /// 넨마스터
        /// </summary>
        public static readonly DnfJobGrowEnum NenMasterMale = new("df3870efe8e8754011cd12fa03cd275f", "넨마스터", DnfJob.MaleFighter);
        /// <summary>
        /// 광호제
        /// </summary>
        public static readonly DnfJobGrowEnum RadiantLion = new("4ec01f4ae3728c080f28a72213b6df10", "광호제", DnfJob.MaleFighter);
        /// <summary>
        /// 염황 광풍제월
        /// </summary>
        public static readonly DnfJobGrowEnum NenEmperor = new("80ec67d0356defa46a989914caca5820", "염황 광풍제월", DnfJob.MaleFighter);
        /// <summary>
        /// 眞 넨마스터
        /// </summary>
        public static readonly DnfJobGrowEnum NeoNenMasterMale = new("37495b941da3b1661bc900e68ef3b2c6", "眞 넨마스터", DnfJob.MaleFighter);
        /// <summary>
        /// 스트라이커
        /// </summary>
        public static readonly DnfJobGrowEnum StrikerMale = new("1ea78ae210f681a799feb4403a5c1e85", "스트라이커", DnfJob.MaleFighter);
        /// <summary>
        /// 무극
        /// </summary>
        public static readonly DnfJobGrowEnum DragonFist = new("981d675414f83b926db5f54e5347eec0", "무극", DnfJob.MaleFighter);
        /// <summary>
        /// 패황
        /// </summary>
        public static readonly DnfJobGrowEnum Tyrant = new("8022a99e29b5e4845985fe1d79a233f3", "패황", DnfJob.MaleFighter);
        /// <summary>
        /// 眞 스트라이커
        /// </summary>
        public static readonly DnfJobGrowEnum NeoStrikerMale = new("618326026de1a1f1cfba5dbd0b8396e7", "眞 스트라이커", DnfJob.MaleFighter);
        /// <summary>
        /// 스트리트파이터
        /// </summary>
        public static readonly DnfJobGrowEnum BrawlerMale = new("a9a4ef4552d46e39cf6c874a51126410", "스트리트파이터", DnfJob.MaleFighter);
        /// <summary>
        /// 천수나한
        /// </summary>
        public static readonly DnfJobGrowEnum Rampager = new("460822c3780a9bc3fbe9485cc89c44a4", "천수나한", DnfJob.MaleFighter);
        /// <summary>
        /// 명왕
        /// </summary>
        public static readonly DnfJobGrowEnum Hades = new("15ce2751ab9c8302f39636cdb7c3dcfa", "명왕", DnfJob.MaleFighter);
        /// <summary>
        /// 眞 스트리트파이터
        /// </summary>
        public static readonly DnfJobGrowEnum NeoBrawlerMale = new("6d459bc74ba73ee4fe5cdc4655400193", "眞 스트리트파이터", DnfJob.MaleFighter);
        /// <summary>
        /// 그래플러
        /// </summary>
        public static readonly DnfJobGrowEnum GrapplerMale = new("4a1459a4fa3c7f59b6da2e43382ed0b9", "그래플러", DnfJob.MaleFighter);
        /// <summary>
        /// 자이언트
        /// </summary>
        public static readonly DnfJobGrowEnum Juggernaut = new("faf8fc6f0cd4c0f84f0035e23bd4fa19", "자이언트", DnfJob.MaleFighter);
        /// <summary>
        /// 그랜드 마스터
        /// </summary>
        public static readonly DnfJobGrowEnum Titan = new("64bbd751c0fcae0e74758b871a2296c1", "그랜드 마스터", DnfJob.MaleFighter);
        /// <summary>
        /// 眞 그래플러
        /// </summary>
        public static readonly DnfJobGrowEnum NeoGrapplerMale = new("c9b492038ee3ca8d27d7004cf58d59f3", "그래플러", DnfJob.MaleFighter);
        #endregion

        #region 격투가(여)
        /// <summary>
        /// 넨마스터
        /// </summary>
        public static readonly DnfJobGrowEnum NenMasterFemale = new("df3870efe8e8754011cd12fa03cd275f", "넨마스터", DnfJob.FemaleFighter);
        /// <summary>
        /// 백화요란
        /// </summary>
        public static readonly DnfJobGrowEnum BlazingFlower = new("4ec01f4ae3728c080f28a72213b6df10", "백화요란", DnfJob.FemaleFighter);
        /// <summary>
        /// 염제 폐월수화
        /// </summary>
        public static readonly DnfJobGrowEnum NenEmpress = new("80ec67d0356defa46a989914caca5820", "염제 폐월수화", DnfJob.FemaleFighter);
        /// <summary>
        /// 眞 넨마스터
        /// </summary>
        public static readonly DnfJobGrowEnum NeoNenMasterFemale = new("37495b941da3b1661bc900e68ef3b2c6", "眞 넨마스터", DnfJob.FemaleFighter);
        /// <summary>
        /// 스트라이커
        /// </summary>
        public static readonly DnfJobGrowEnum StrikerFemale = new("1ea78ae210f681a799feb4403a5c1e85", "스트라이커", DnfJob.FemaleFighter);
        /// <summary>
        /// 챔피언
        /// </summary>
        public static readonly DnfJobGrowEnum Champion = new("981d675414f83b926db5f54e5347eec0", "챔피언", DnfJob.FemaleFighter);
        /// <summary>
        /// 카이저
        /// </summary>
        public static readonly DnfJobGrowEnum Kaiser = new("8022a99e29b5e4845985fe1d79a233f3", "카이저", DnfJob.FemaleFighter);
        /// <summary>
        /// 眞 스트라이커
        /// </summary>
        public static readonly DnfJobGrowEnum NeoStrikerFemale = new("618326026de1a1f1cfba5dbd0b8396e7", "眞 스트라이커", DnfJob.FemaleFighter);
        /// <summary>
        /// 스트리트파이터
        /// </summary>
        public static readonly DnfJobGrowEnum BrawlerFemale = new("a9a4ef4552d46e39cf6c874a51126410", "스트리트파이터", DnfJob.FemaleFighter);
        /// <summary>
        /// 독왕
        /// </summary>
        public static readonly DnfJobGrowEnum Hellcat = new("460822c3780a9bc3fbe9485cc89c44a4", "독왕", DnfJob.FemaleFighter);
        /// <summary>
        /// 용독문주
        /// </summary>
        public static readonly DnfJobGrowEnum BlackWidow = new("15ce2751ab9c8302f39636cdb7c3dcfa", "용독문주", DnfJob.FemaleFighter);
        /// <summary>
        /// 眞 스트리트파이터
        /// </summary>
        public static readonly DnfJobGrowEnum NeoBrawlerFemale = new("6d459bc74ba73ee4fe5cdc4655400193", "眞 스트리트파이터", DnfJob.FemaleFighter);
        /// <summary>
        /// 그래플러
        /// </summary>
        public static readonly DnfJobGrowEnum GrapplerFemale = new("4a1459a4fa3c7f59b6da2e43382ed0b9", "그래플러", DnfJob.FemaleFighter);
        /// <summary>
        /// 토네이도
        /// </summary>
        public static readonly DnfJobGrowEnum Dervish = new("faf8fc6f0cd4c0f84f0035e23bd4fa19", "토네이도", DnfJob.FemaleFighter);
        /// <summary>
        /// 얼티밋 디바
        /// </summary>
        public static readonly DnfJobGrowEnum UltimateDiva = new("64bbd751c0fcae0e74758b871a2296c1", "얼티밋 디바", DnfJob.FemaleFighter);
        /// <summary>
        /// 眞 그래플러
        /// </summary>
        public static readonly DnfJobGrowEnum NeoGrapplerFemale = new("c9b492038ee3ca8d27d7004cf58d59f3", "眞 그래플러", DnfJob.FemaleFighter);
        #endregion

        #region 거너(남)
        /// <summary>
        /// 레인저
        /// </summary>
        public static readonly DnfJobGrowEnum RangerMale = new("df3870efe8e8754011cd12fa03cd275f", "레인저", DnfJob.MaleGunner);
        /// <summary>
        /// 데스페라도
        /// </summary>
        public static readonly DnfJobGrowEnum Desperado = new("4ec01f4ae3728c080f28a72213b6df10", "데스페라도", DnfJob.MaleGunner);
        /// <summary>
        /// 레이븐
        /// </summary>
        public static readonly DnfJobGrowEnum Raven = new("80ec67d0356defa46a989914caca5820", "레이븐", DnfJob.MaleGunner);
        /// <summary>
        /// 眞 레인저
        /// </summary>
        public static readonly DnfJobGrowEnum NeoRangerMale = new("37495b941da3b1661bc900e68ef3b2c6", "眞 레인저", DnfJob.MaleGunner);
        /// <summary>
        /// 런처
        /// </summary>
        public static readonly DnfJobGrowEnum LauncherMale = new("1ea78ae210f681a799feb4403a5c1e85", "런처", DnfJob.MaleGunner);
        /// <summary>
        /// 블래스터
        /// </summary>
        public static readonly DnfJobGrowEnum WreckingBall = new("981d675414f83b926db5f54e5347eec0", "블래스터", DnfJob.MaleGunner);
        /// <summary>
        /// 디스트로이어
        /// </summary>
        public static readonly DnfJobGrowEnum Destroyer = new("8022a99e29b5e4845985fe1d79a233f3", "디스트로이어", DnfJob.MaleGunner);
        /// <summary>
        /// 眞 런처
        /// </summary>
        public static readonly DnfJobGrowEnum NeoLauncherMale = new("618326026de1a1f1cfba5dbd0b8396e7", "眞 런처", DnfJob.MaleGunner);
        /// <summary>
        /// 메카닉
        /// </summary>
        public static readonly DnfJobGrowEnum MechanicMale = new("a9a4ef4552d46e39cf6c874a51126410", "메카닉", DnfJob.MaleGunner);
        /// <summary>
        /// 마이스터
        /// </summary>
        public static readonly DnfJobGrowEnum Machinist = new("460822c3780a9bc3fbe9485cc89c44a4", "마이스터", DnfJob.MaleGunner);
        /// <summary>
        /// 프라임
        /// </summary>
        public static readonly DnfJobGrowEnum Prime = new("15ce2751ab9c8302f39636cdb7c3dcfa", "프라임", DnfJob.MaleGunner);
        /// <summary>
        /// 眞 메카닉
        /// </summary>
        public static readonly DnfJobGrowEnum NeoMechanicMale = new("6d459bc74ba73ee4fe5cdc4655400193", "眞 메카닉", DnfJob.MaleGunner);
        /// <summary>
        /// 스핏파이어
        /// </summary>
        public static readonly DnfJobGrowEnum SpitfireMale = new("4a1459a4fa3c7f59b6da2e43382ed0b9", "스핏파이어", DnfJob.MaleGunner);
        /// <summary>
        /// 제네럴
        /// </summary>
        public static readonly DnfJobGrowEnum General = new("faf8fc6f0cd4c0f84f0035e23bd4fa19", "제네럴", DnfJob.MaleGunner);
        /// <summary>
        /// 커맨더
        /// </summary>
        public static readonly DnfJobGrowEnum Marshal = new("64bbd751c0fcae0e74758b871a2296c1", "커맨더", DnfJob.MaleGunner);
        /// <summary>
        /// 眞 스핏파이어
        /// </summary>
        public static readonly DnfJobGrowEnum NeoSpitfireMale = new("c9b492038ee3ca8d27d7004cf58d59f3", "眞 스핏파이어", DnfJob.MaleGunner);
        /// <summary>
        /// 어썰트
        /// </summary>
        public static readonly DnfJobGrowEnum Blitz = new("a59ba19824dc3292b6075e29b3862ad3", "어썰트", DnfJob.MaleGunner);
        /// <summary>
        /// 인트루더
        /// </summary>
        public static readonly DnfJobGrowEnum Infiltrator = new("a427ec3e94087c64cb4144379c3a0d59", "인트루더", DnfJob.MaleGunner);
        /// <summary>
        /// 엑스마키나
        /// </summary>
        public static readonly DnfJobGrowEnum Armada = new("3ff5b661925ac59d1ca290b05ca914cc", "엑스마키나", DnfJob.MaleGunner);
        /// <summary>
        /// 眞 어썰트
        /// </summary>
        public static readonly DnfJobGrowEnum NeoBlitz = new("92da05ec93fb43406e193ffb9a2a629b", "眞 어썰트", DnfJob.MaleGunner);
        #endregion

        #region 거너(여)
        /// <summary>
        /// 레인저
        /// </summary>
        public static readonly DnfJobGrowEnum RangerFemale = new("df3870efe8e8754011cd12fa03cd275f", "레인저", DnfJob.FemaleGunner);
        /// <summary>
        /// 블러디아
        /// </summary>
        public static readonly DnfJobGrowEnum Bloodia = new("4ec01f4ae3728c080f28a72213b6df10", "블러디아", DnfJob.FemaleGunner);
        /// <summary>
        /// 크림슨로제
        /// </summary>
        public static readonly DnfJobGrowEnum CrimsonRose = new("80ec67d0356defa46a989914caca5820", "크림슨로제", DnfJob.FemaleGunner);
        /// <summary>
        /// 眞 레인저
        /// </summary>
        public static readonly DnfJobGrowEnum NeoRangerFemale = new("37495b941da3b1661bc900e68ef3b2c6", "眞 레인저", DnfJob.FemaleGunner);
        /// <summary>
        /// 런처
        /// </summary>
        public static readonly DnfJobGrowEnum LauncherFemale = new("1ea78ae210f681a799feb4403a5c1e85", "런처", DnfJob.FemaleGunner);
        /// <summary>
        /// 헤비배럴
        /// </summary>
        public static readonly DnfJobGrowEnum Demolitionist = new("981d675414f83b926db5f54e5347eec0", "헤비배럴", DnfJob.FemaleGunner);
        /// <summary>
        /// 스톰트루퍼
        /// </summary>
        public static readonly DnfJobGrowEnum StormBringer = new("8022a99e29b5e4845985fe1d79a233f3", "스톰트루퍼", DnfJob.FemaleGunner);
        /// <summary>
        /// 眞 런처
        /// </summary>
        public static readonly DnfJobGrowEnum NeoLauncherFemale = new("618326026de1a1f1cfba5dbd0b8396e7", "眞 런처", DnfJob.FemaleGunner);
        /// <summary>
        /// 메카닉
        /// </summary>
        public static readonly DnfJobGrowEnum MechanicFemale = new("a9a4ef4552d46e39cf6c874a51126410", "메카닉", DnfJob.FemaleGunner);
        /// <summary>
        /// 메탈하트
        /// </summary>
        public static readonly DnfJobGrowEnum Metalheart = new("460822c3780a9bc3fbe9485cc89c44a4", "메탈하트", DnfJob.FemaleGunner);
        /// <summary>
        /// 옵티머스
        /// </summary>
        public static readonly DnfJobGrowEnum Optimus = new("15ce2751ab9c8302f39636cdb7c3dcfa", "옵티머스", DnfJob.FemaleGunner);
        /// <summary>
        /// 眞 메카닉
        /// </summary>
        public static readonly DnfJobGrowEnum NeoMechanicFemale = new("6d459bc74ba73ee4fe5cdc4655400193", "眞 메카닉", DnfJob.FemaleGunner);
        /// <summary>
        /// 스핏파이어
        /// </summary>
        public static readonly DnfJobGrowEnum SpitfireFemale = new("4a1459a4fa3c7f59b6da2e43382ed0b9", "스핏파이어", DnfJob.FemaleGunner);
        /// <summary>
        /// 발키리
        /// </summary>
        public static readonly DnfJobGrowEnum Valkyrie = new("faf8fc6f0cd4c0f84f0035e23bd4fa19", "발키리", DnfJob.FemaleGunner);
        /// <summary>
        /// 프레이야
        /// </summary>
        public static readonly DnfJobGrowEnum Freyja = new("64bbd751c0fcae0e74758b871a2296c1", "프레이야", DnfJob.FemaleGunner);
        /// <summary>
        /// 眞 스핏파이어
        /// </summary>
        public static readonly DnfJobGrowEnum NeoSpitfireFemale = new("c9b492038ee3ca8d27d7004cf58d59f3", "眞 스핏파이어", DnfJob.FemaleGunner);
        #endregion

        #region 마법사(남)
        /// <summary>
        /// 엘레멘탈 바머
        /// </summary>
        public static readonly DnfJobGrowEnum ElementalBomber = new("df3870efe8e8754011cd12fa03cd275f", "엘레멘탈 바머", DnfJob.MaleMage);
        /// <summary>
        /// 워록
        /// </summary>
        public static readonly DnfJobGrowEnum WarlockBomber = new("4ec01f4ae3728c080f28a72213b6df10", "워록", DnfJob.MaleMage);
        /// <summary>
        /// 오블리비언
        /// </summary>
        public static readonly DnfJobGrowEnum OblivionBomber = new("80ec67d0356defa46a989914caca5820", "오블리비언", DnfJob.MaleMage);
        /// <summary>
        /// 眞 엘레멘탈 바머
        /// </summary>
        public static readonly DnfJobGrowEnum NeoElementalBomber = new("37495b941da3b1661bc900e68ef3b2c6", "眞 엘레멘탈 바머", DnfJob.MaleMage);
        /// <summary>
        /// 빙결사
        /// </summary>
        public static readonly DnfJobGrowEnum GlacialMaster = new("1ea78ae210f681a799feb4403a5c1e85", "빙결사", DnfJob.MaleMage);
        /// <summary>
        /// 프로즌하트
        /// </summary>
        public static readonly DnfJobGrowEnum HellFreezer = new("981d675414f83b926db5f54e5347eec0", "프로즌하트", DnfJob.MaleMage);
        /// <summary>
        /// 이터널
        /// </summary>
        public static readonly DnfJobGrowEnum Eternal = new("8022a99e29b5e4845985fe1d79a233f3", "이터널", DnfJob.MaleMage);
        /// <summary>
        /// 眞 빙결사
        /// </summary>
        public static readonly DnfJobGrowEnum NeoGlacialMaster = new("618326026de1a1f1cfba5dbd0b8396e7", "眞 빙결사", DnfJob.MaleMage);
        /// <summary>
        /// 블러드 메이지
        /// </summary>
        public static readonly DnfJobGrowEnum BloodMage = new("a9a4ef4552d46e39cf6c874a51126410", "블러드 메이지", DnfJob.MaleMage);
        /// <summary>
        /// 뱀파이어
        /// </summary>
        public static readonly DnfJobGrowEnum Bloodseeker = new("460822c3780a9bc3fbe9485cc89c44a4", "뱀파이어", DnfJob.MaleMage);
        /// <summary>
        /// 뱀파이어 로드
        /// </summary>
        public static readonly DnfJobGrowEnum VampireLord = new("15ce2751ab9c8302f39636cdb7c3dcfa", "뱀파이어 로드", DnfJob.MaleMage);
        /// <summary>
        /// 眞 블러드 메이지
        /// </summary>
        public static readonly DnfJobGrowEnum NeoBloodMage = new("6d459bc74ba73ee4fe5cdc4655400193", "眞 블러드 메이지", DnfJob.MaleMage);
        /// <summary>
        /// 스위프트 마스터
        /// </summary>
        public static readonly DnfJobGrowEnum SwiftMaster = new("4a1459a4fa3c7f59b6da2e43382ed0b9", "스위프트 마스터", DnfJob.MaleMage);
        /// <summary>
        /// 스톰브링어
        /// </summary>
        public static readonly DnfJobGrowEnum Tempest = new("faf8fc6f0cd4c0f84f0035e23bd4fa19", "스톰브링어", DnfJob.MaleMage);
        /// <summary>
        /// 아이올로스
        /// </summary>
        public static readonly DnfJobGrowEnum Aiolos = new("64bbd751c0fcae0e74758b871a2296c1", "아이올로스", DnfJob.MaleMage);
        /// <summary>
        /// 眞 스위프트 마스터
        /// </summary>
        public static readonly DnfJobGrowEnum NeoSwiftMaster = new("c9b492038ee3ca8d27d7004cf58d59f3", "眞 스위프트 마스터", DnfJob.MaleMage);
        /// <summary>
        /// 디멘션워커
        /// </summary>
        public static readonly DnfJobGrowEnum DimensionWalker = new("a59ba19824dc3292b6075e29b3862ad3", "디멘션워커", DnfJob.MaleMage);
        /// <summary>
        /// 이레귤러
        /// </summary>
        public static readonly DnfJobGrowEnum Divergent = new("a427ec3e94087c64cb4144379c3a0d59", "이레귤러", DnfJob.MaleMage);
        /// <summary>
        /// 어센션
        /// </summary>
        public static readonly DnfJobGrowEnum Ascendant = new("3ff5b661925ac59d1ca290b05ca914cc", "어센션", DnfJob.MaleMage);
        /// <summary>
        /// 眞 디멘션워커
        /// </summary>
        public static readonly DnfJobGrowEnum NeoDimensionWalker = new("92da05ec93fb43406e193ffb9a2a629b", "眞 디멘션워커", DnfJob.MaleMage);
        #endregion

        #region 마법사(여)
        /// <summary>
        /// 엘레멘탈마스터
        /// </summary>
        public static readonly DnfJobGrowEnum Elementalist = new("df3870efe8e8754011cd12fa03cd275f", "엘레멘탈마스터", DnfJob.FemaleMage);
        /// <summary>
        /// 아크메이지
        /// </summary>
        public static readonly DnfJobGrowEnum Archmage = new("4ec01f4ae3728c080f28a72213b6df10", "아크메이지", DnfJob.FemaleMage);
        /// <summary>
        /// 오버마인드
        /// </summary>
        public static readonly DnfJobGrowEnum Overmind = new("80ec67d0356defa46a989914caca5820", "오버마인드", DnfJob.FemaleMage);
        /// <summary>
        /// 眞 엘레멘탈마스터
        /// </summary>
        public static readonly DnfJobGrowEnum NeoElementalist = new("37495b941da3b1661bc900e68ef3b2c6", "眞 엘레멘탈마스터", DnfJob.FemaleMage);
        /// <summary>
        /// 소환사
        /// </summary>
        public static readonly DnfJobGrowEnum Summoner = new("1ea78ae210f681a799feb4403a5c1e85", "소환사", DnfJob.FemaleMage);
        /// <summary>
        /// 문 엠프레스
        /// </summary>
        public static readonly DnfJobGrowEnum LunarPrincess = new("981d675414f83b926db5f54e5347eec0", "문 엠프레스", DnfJob.FemaleMage);
        /// <summary>
        /// 이클립스
        /// </summary>
        public static readonly DnfJobGrowEnum Eclipse = new("8022a99e29b5e4845985fe1d79a233f3", "이클립스", DnfJob.FemaleMage);
        /// <summary>
        /// 眞 소환사
        /// </summary>
        public static readonly DnfJobGrowEnum NeoSummoner = new("618326026de1a1f1cfba5dbd0b8396e7", "眞 소환사", DnfJob.FemaleMage);
        /// <summary>
        /// 배틀메이지
        /// </summary>
        public static readonly DnfJobGrowEnum BattleMage = new("a9a4ef4552d46e39cf6c874a51126410", "배틀메이지", DnfJob.FemaleMage);
        /// <summary>
        /// 벨라트릭스
        /// </summary>
        public static readonly DnfJobGrowEnum Bellatrix = new("460822c3780a9bc3fbe9485cc89c44a4", "벨라트릭스", DnfJob.FemaleMage);
        /// <summary>
        /// 아슈타르테
        /// </summary>
        public static readonly DnfJobGrowEnum Astarte = new("15ce2751ab9c8302f39636cdb7c3dcfa", "아슈타르테", DnfJob.FemaleMage);
        /// <summary>
        /// 眞 배틀메이지
        /// </summary>
        public static readonly DnfJobGrowEnum NeoBattleMage = new("6d459bc74ba73ee4fe5cdc4655400193", "眞 배틀메이지", DnfJob.FemaleMage);
        /// <summary>
        /// 마도학자
        /// </summary>
        public static readonly DnfJobGrowEnum Witch = new("4a1459a4fa3c7f59b6da2e43382ed0b9", "마도학자", DnfJob.FemaleMage);
        /// <summary>
        /// 트릭스터
        /// </summary>
        public static readonly DnfJobGrowEnum Trickster = new("faf8fc6f0cd4c0f84f0035e23bd4fa19", "트릭스터", DnfJob.FemaleMage);
        /// <summary>
        /// 지니위즈
        /// </summary>
        public static readonly DnfJobGrowEnum Geniewiz = new("64bbd751c0fcae0e74758b871a2296c1", "지니위즈", DnfJob.FemaleMage);
        /// <summary>
        /// 眞 마도학자
        /// </summary>
        public static readonly DnfJobGrowEnum NeoWitch = new("c9b492038ee3ca8d27d7004cf58d59f3", "眞 마도학자", DnfJob.FemaleMage);
        /// <summary>
        /// 인챈트리스
        /// </summary>
        public static readonly DnfJobGrowEnum Enchantress = new("a59ba19824dc3292b6075e29b3862ad3", "인챈트리스", DnfJob.FemaleMage);
        /// <summary>
        /// 블랙 메이든
        /// </summary>
        public static readonly DnfJobGrowEnum BlackMaiden = new("a427ec3e94087c64cb4144379c3a0d59", "블랙 메이든", DnfJob.FemaleMage);
        /// <summary>
        /// 헤카테
        /// </summary>
        public static readonly DnfJobGrowEnum Hekate = new("3ff5b661925ac59d1ca290b05ca914cc", "헤카테", DnfJob.FemaleMage);
        /// <summary>
        /// 眞 인챈트리스
        /// </summary>
        public static readonly DnfJobGrowEnum NeoEnchantress = new("92da05ec93fb43406e193ffb9a2a629b", "眞 인챈트리스", DnfJob.FemaleMage);
        #endregion

        #region 프리스트(남)
        /// <summary>
        /// 크루세이더
        /// </summary>
        public static readonly DnfJobGrowEnum CrusaderMale = new("df3870efe8e8754011cd12fa03cd275f", "크루세이더", DnfJob.MalePriest);
        /// <summary>
        /// 홀리오더
        /// </summary>
        public static readonly DnfJobGrowEnum Paladin = new("4ec01f4ae3728c080f28a72213b6df10", "홀리오더", DnfJob.MalePriest);
        /// <summary>
        /// 세인트
        /// </summary>
        public static readonly DnfJobGrowEnum Saint = new("80ec67d0356defa46a989914caca5820", "세인트", DnfJob.MalePriest);
        /// <summary>
        /// 眞 크루세이더
        /// </summary>
        public static readonly DnfJobGrowEnum NeoCrusaderMale = new("37495b941da3b1661bc900e68ef3b2c6", "眞 크루세이더", DnfJob.MalePriest);
        /// <summary>
        /// 인파이터
        /// </summary>
        public static readonly DnfJobGrowEnum Monk = new("1ea78ae210f681a799feb4403a5c1e85", "인파이터", DnfJob.MalePriest);
        /// <summary>
        /// 갓핸드
        /// </summary>
        public static readonly DnfJobGrowEnum Templar = new("981d675414f83b926db5f54e5347eec0", "갓핸드", DnfJob.MalePriest);
        /// <summary>
        /// 저스티스
        /// </summary>
        public static readonly DnfJobGrowEnum Justice = new("8022a99e29b5e4845985fe1d79a233f3", "저스티스", DnfJob.MalePriest);
        /// <summary>
        /// 眞 인파이터
        /// </summary>
        public static readonly DnfJobGrowEnum NeoMonk = new("618326026de1a1f1cfba5dbd0b8396e7", "眞 인파이터", DnfJob.MalePriest);
        /// <summary>
        /// 퇴마사
        /// </summary>
        public static readonly DnfJobGrowEnum Exorcist = new("a9a4ef4552d46e39cf6c874a51126410", "퇴마사", DnfJob.MalePriest);
        /// <summary>
        /// 용투사
        /// </summary>
        public static readonly DnfJobGrowEnum Hyperion = new("460822c3780a9bc3fbe9485cc89c44a4", "용투사", DnfJob.MalePriest);
        /// <summary>
        /// 태을선인
        /// </summary>
        public static readonly DnfJobGrowEnum Draconid = new("15ce2751ab9c8302f39636cdb7c3dcfa", "태을선인", DnfJob.MalePriest);
        /// <summary>
        /// 眞 퇴마사
        /// </summary>
        public static readonly DnfJobGrowEnum NeoExorcist = new("6d459bc74ba73ee4fe5cdc4655400193", "眞 퇴마사", DnfJob.MalePriest);
        /// <summary>
        /// 어벤저
        /// </summary>
        public static readonly DnfJobGrowEnum Avenger = new("4a1459a4fa3c7f59b6da2e43382ed0b9", "어벤저", DnfJob.MalePriest);
        /// <summary>
        /// 둠스가디언
        /// </summary>
        public static readonly DnfJobGrowEnum DoomGuardian = new("faf8fc6f0cd4c0f84f0035e23bd4fa19", "둠스가디언", DnfJob.MalePriest);
        /// <summary>
        /// 이모탈
        /// </summary>
        public static readonly DnfJobGrowEnum Immortal = new("64bbd751c0fcae0e74758b871a2296c1", "이모탈", DnfJob.MalePriest);
        /// <summary>
        /// 眞 어벤저
        /// </summary>
        public static readonly DnfJobGrowEnum NeoAvenger = new("c9b492038ee3ca8d27d7004cf58d59f3", "眞 어벤저", DnfJob.MalePriest);
        #endregion

        #region 프리스트(여)
        /// <summary>
        /// 크루세이더
        /// </summary>
        public static readonly DnfJobGrowEnum CrusaderFemale = new("df3870efe8e8754011cd12fa03cd275f", "크루세이더", DnfJob.FemalePriest);
        /// <summary>
        /// 에반젤리스트
        /// </summary>
        public static readonly DnfJobGrowEnum Evangelist = new("4ec01f4ae3728c080f28a72213b6df10", "에반젤리스트", DnfJob.FemalePriest);
        /// <summary>
        /// 세라핌
        /// </summary>
        public static readonly DnfJobGrowEnum Seraph = new("80ec67d0356defa46a989914caca5820", "세라핌", DnfJob.FemalePriest);
        /// <summary>
        /// 眞 크루세이더
        /// </summary>
        public static readonly DnfJobGrowEnum NeoCrusaderFemale = new("37495b941da3b1661bc900e68ef3b2c6", "眞 크루세이더", DnfJob.FemalePriest);
        /// <summary>
        /// 이단심판관
        /// </summary>
        public static readonly DnfJobGrowEnum Inquisitor = new("1ea78ae210f681a799feb4403a5c1e85", "이단심판관", DnfJob.FemalePriest);
        /// <summary>
        /// 헬카이트
        /// </summary>
        public static readonly DnfJobGrowEnum Hellkite = new("981d675414f83b926db5f54e5347eec0", "헬카이트", DnfJob.FemalePriest);
        /// <summary>
        /// 인페르노
        /// </summary>
        public static readonly DnfJobGrowEnum Inferno = new("8022a99e29b5e4845985fe1d79a233f3", "인페르노", DnfJob.FemalePriest);
        /// <summary>
        /// 眞 이단심판관
        /// </summary>
        public static readonly DnfJobGrowEnum NeoInquisitor = new("618326026de1a1f1cfba5dbd0b8396e7", "眞 이단심판관", DnfJob.FemalePriest);
        /// <summary>
        /// 무녀
        /// </summary>
        public static readonly DnfJobGrowEnum Shaman = new("a9a4ef4552d46e39cf6c874a51126410", "무녀", DnfJob.FemalePriest);
        /// <summary>
        /// 신녀
        /// </summary>
        public static readonly DnfJobGrowEnum Oracle = new("460822c3780a9bc3fbe9485cc89c44a4", "신녀", DnfJob.FemalePriest);
        /// <summary>
        /// 천선낭랑
        /// </summary>
        public static readonly DnfJobGrowEnum Divineress = new("15ce2751ab9c8302f39636cdb7c3dcfa", "천선낭랑", DnfJob.FemalePriest);
        /// <summary>
        /// 眞 무녀
        /// </summary>
        public static readonly DnfJobGrowEnum NeoShaman = new("6d459bc74ba73ee4fe5cdc4655400193", "眞 무녀", DnfJob.FemalePriest);
        /// <summary>
        /// 미스트리스
        /// </summary>
        public static readonly DnfJobGrowEnum Mistress = new("4a1459a4fa3c7f59b6da2e43382ed0b9", "미스트리스", DnfJob.FemalePriest);
        /// <summary>
        /// 신세이어
        /// </summary>
        public static readonly DnfJobGrowEnum SinSayer = new("faf8fc6f0cd4c0f84f0035e23bd4fa19", "신세이어", DnfJob.FemalePriest);
        /// <summary>
        /// 리디머
        /// </summary>
        public static readonly DnfJobGrowEnum Redeemer = new("64bbd751c0fcae0e74758b871a2296c1", "리디머", DnfJob.FemalePriest);
        /// <summary>
        /// 眞 미스트리스
        /// </summary>
        public static readonly DnfJobGrowEnum NeoMistress = new("c9b492038ee3ca8d27d7004cf58d59f3", "眞 미스트리스", DnfJob.FemalePriest);
        #endregion

        #region 도적
        /// <summary>
        /// 로그
        /// </summary>
        public static readonly DnfJobGrowEnum Rogue = new("df3870efe8e8754011cd12fa03cd275f", "로그", DnfJob.Thief);
        /// <summary>
        /// 실버문
        /// </summary>
        public static readonly DnfJobGrowEnum SilverMoon = new("4ec01f4ae3728c080f28a72213b6df10", "실버문", DnfJob.Thief);
        /// <summary>
        /// 알키오네
        /// </summary>
        public static readonly DnfJobGrowEnum Alcyone = new("80ec67d0356defa46a989914caca5820", "알키오네", DnfJob.Thief);
        /// <summary>
        /// 眞 로그
        /// </summary>
        public static readonly DnfJobGrowEnum NeoRogue = new("37495b941da3b1661bc900e68ef3b2c6", "眞 로그", DnfJob.Thief);
        /// <summary>
        /// 사령술사
        /// </summary>
        public static readonly DnfJobGrowEnum Necromancer = new("1ea78ae210f681a799feb4403a5c1e85", "사령술사", DnfJob.Thief);
        /// <summary>
        /// 데스브링어
        /// </summary>
        public static readonly DnfJobGrowEnum Defiler = new("981d675414f83b926db5f54e5347eec0", "데스브링어", DnfJob.Thief);
        /// <summary>
        /// 타나토스
        /// </summary>
        public static readonly DnfJobGrowEnum Thanatos = new("8022a99e29b5e4845985fe1d79a233f3", "타나토스", DnfJob.Thief);
        /// <summary>
        /// 眞 사령술사
        /// </summary>
        public static readonly DnfJobGrowEnum NeoNecromancer = new("618326026de1a1f1cfba5dbd0b8396e7", "眞 사령술사", DnfJob.Thief);
        /// <summary>
        /// 쿠노이치
        /// </summary>
        public static readonly DnfJobGrowEnum Kunoichi = new("a9a4ef4552d46e39cf6c874a51126410", "쿠노이치", DnfJob.Thief);
        /// <summary>
        /// 이즈나비
        /// </summary>
        public static readonly DnfJobGrowEnum Izunabi = new("460822c3780a9bc3fbe9485cc89c44a4", "이즈나비", DnfJob.Thief);
        /// <summary>
        /// 시라누이
        /// </summary>
        public static readonly DnfJobGrowEnum Shiranui = new("15ce2751ab9c8302f39636cdb7c3dcfa", "시라누이", DnfJob.Thief);
        /// <summary>
        /// 眞 쿠노이치
        /// </summary>
        public static readonly DnfJobGrowEnum NeoKunoichi = new("6d459bc74ba73ee4fe5cdc4655400193", "眞 쿠노이치", DnfJob.Thief);
        /// <summary>
        /// 섀도우댄서
        /// </summary>
        public static readonly DnfJobGrowEnum ShadowDancer = new("4a1459a4fa3c7f59b6da2e43382ed0b9", "섀도우댄서", DnfJob.Thief);
        /// <summary>
        /// 나이트메어
        /// </summary>
        public static readonly DnfJobGrowEnum Nightmare = new("faf8fc6f0cd4c0f84f0035e23bd4fa19", "나이트메어", DnfJob.Thief);
        /// <summary>
        /// 그림리퍼
        /// </summary>
        public static readonly DnfJobGrowEnum GrimReaper = new("64bbd751c0fcae0e74758b871a2296c1", "그림리퍼", DnfJob.Thief);
        /// <summary>
        /// 眞 섀도우댄서
        /// </summary>
        public static readonly DnfJobGrowEnum NeoShadowDancer = new("c9b492038ee3ca8d27d7004cf58d59f3", "眞 섀도우댄서", DnfJob.Thief);
        #endregion

        #region 나이트
        /// <summary>
        /// 엘븐나이트
        /// </summary>
        public static readonly DnfJobGrowEnum ElvenKnight = new("df3870efe8e8754011cd12fa03cd275f", "엘븐나이트", DnfJob.Knight);
        /// <summary>
        /// 피스메이커
        /// </summary>
        public static readonly DnfJobGrowEnum Peacemaker = new("4ec01f4ae3728c080f28a72213b6df10", "피스메이커", DnfJob.Knight);
        /// <summary>
        /// 가이아
        /// </summary>
        public static readonly DnfJobGrowEnum Gaia = new("80ec67d0356defa46a989914caca5820", "가이아", DnfJob.Knight);
        /// <summary>
        /// 眞 엘븐나이트
        /// </summary>
        public static readonly DnfJobGrowEnum NeoElvenKnight = new("37495b941da3b1661bc900e68ef3b2c6", "眞 엘븐나이트", DnfJob.Knight);
        /// <summary>
        /// 카오스
        /// </summary>
        public static readonly DnfJobGrowEnum Chaos = new("1ea78ae210f681a799feb4403a5c1e85", "카오스", DnfJob.Knight);
        /// <summary>
        /// 마왕
        /// </summary>
        public static readonly DnfJobGrowEnum DemonQueen = new("981d675414f83b926db5f54e5347eec0", "마왕", DnfJob.Knight);
        /// <summary>
        /// 마신
        /// </summary>
        public static readonly DnfJobGrowEnum DemonGod = new("8022a99e29b5e4845985fe1d79a233f3", "마신", DnfJob.Knight);
        /// <summary>
        /// 眞 카오스
        /// </summary>
        public static readonly DnfJobGrowEnum NeoChaos = new("618326026de1a1f1cfba5dbd0b8396e7", "眞 카오스", DnfJob.Knight);
        /// <summary>
        /// 팔라딘
        /// </summary>
        public static readonly DnfJobGrowEnum Lightbringer = new("a9a4ef4552d46e39cf6c874a51126410", "팔라딘", DnfJob.Knight);
        /// <summary>
        /// 센티넬
        /// </summary>
        public static readonly DnfJobGrowEnum Archangel = new("460822c3780a9bc3fbe9485cc89c44a4", "센티넬", DnfJob.Knight);
        /// <summary>
        /// 세이비어
        /// </summary>
        public static readonly DnfJobGrowEnum Savior = new("15ce2751ab9c8302f39636cdb7c3dcfa", "세이비어", DnfJob.Knight);
        /// <summary>
        /// 眞 팔라딘
        /// </summary>
        public static readonly DnfJobGrowEnum NeoLightbringer = new("6d459bc74ba73ee4fe5cdc4655400193", "眞 팔라딘", DnfJob.Knight);
        /// <summary>
        /// 드래곤나이트
        /// </summary>
        public static readonly DnfJobGrowEnum DragonKnight = new("4a1459a4fa3c7f59b6da2e43382ed0b9", "드래곤나이트", DnfJob.Knight);
        /// <summary>
        /// 타이런트
        /// </summary>
        public static readonly DnfJobGrowEnum Braveheart = new("faf8fc6f0cd4c0f84f0035e23bd4fa19", "타이런트", DnfJob.Knight);
        /// <summary>
        /// 드레드노트
        /// </summary>
        public static readonly DnfJobGrowEnum Dreadnought = new("64bbd751c0fcae0e74758b871a2296c1", "드레드노트", DnfJob.Knight);
        /// <summary>
        /// 眞 드래곤나이트
        /// </summary>
        public static readonly DnfJobGrowEnum NeoDragonKnight = new("c9b492038ee3ca8d27d7004cf58d59f3", "眞 드래곤나이트", DnfJob.Knight);
        #endregion

        #region 마창사
        /// <summary>
        /// 뱅가드
        /// </summary>
        public static readonly DnfJobGrowEnum Vanguard = new("df3870efe8e8754011cd12fa03cd275f", "뱅가드", DnfJob.DemonicLancer);
        /// <summary>
        /// 레버넌트
        /// </summary>
        public static readonly DnfJobGrowEnum Revenant = new("4ec01f4ae3728c080f28a72213b6df10", "레버넌트", DnfJob.DemonicLancer);
        /// <summary>
        /// 워로드
        /// </summary>
        public static readonly DnfJobGrowEnum Warlord = new("80ec67d0356defa46a989914caca5820", "워로드", DnfJob.DemonicLancer);
        /// <summary>
        /// 眞 뱅가드
        /// </summary>
        public static readonly DnfJobGrowEnum NeoVanguard = new("37495b941da3b1661bc900e68ef3b2c6", "眞 뱅가드", DnfJob.DemonicLancer);
        /// <summary>
        /// 듀얼리스트
        /// </summary>
        public static readonly DnfJobGrowEnum Skirmisher = new("1ea78ae210f681a799feb4403a5c1e85", "듀얼리스트", DnfJob.DemonicLancer);
        /// <summary>
        /// 하이랜더
        /// </summary>
        public static readonly DnfJobGrowEnum Highlander = new("981d675414f83b926db5f54e5347eec0", "하이랜더", DnfJob.DemonicLancer);
        /// <summary>
        /// 듀란달
        /// </summary>
        public static readonly DnfJobGrowEnum Durandal = new("8022a99e29b5e4845985fe1d79a233f3", "듀란달", DnfJob.DemonicLancer);
        /// <summary>
        /// 眞 듀얼리스트
        /// </summary>
        public static readonly DnfJobGrowEnum NeoSkirmisher = new("618326026de1a1f1cfba5dbd0b8396e7", "眞 듀얼리스트", DnfJob.DemonicLancer);
        /// <summary>
        /// 드래고니안 랜서
        /// </summary>
        public static readonly DnfJobGrowEnum Dragoon = new("a9a4ef4552d46e39cf6c874a51126410", "드래고니안 랜서", DnfJob.DemonicLancer);
        /// <summary>
        /// 레비아탄
        /// </summary>
        public static readonly DnfJobGrowEnum Leviathan = new("460822c3780a9bc3fbe9485cc89c44a4", "레비아탄", DnfJob.DemonicLancer);
        /// <summary>
        /// 제노사이더
        /// </summary>
        public static readonly DnfJobGrowEnum Deimos = new("15ce2751ab9c8302f39636cdb7c3dcfa", "제노사이더", DnfJob.DemonicLancer);
        /// <summary>
        /// 眞 드래고니안 랜서
        /// </summary>
        public static readonly DnfJobGrowEnum NeoDragoon = new("6d459bc74ba73ee4fe5cdc4655400193", "眞 드래고니안 랜서", DnfJob.DemonicLancer);
        /// <summary>
        /// 다크 랜서
        /// </summary>
        public static readonly DnfJobGrowEnum Impaler = new("4a1459a4fa3c7f59b6da2e43382ed0b9", "다크 랜서", DnfJob.DemonicLancer);
        /// <summary>
        /// 램페이저
        /// </summary>
        public static readonly DnfJobGrowEnum Abbadon = new("faf8fc6f0cd4c0f84f0035e23bd4fa19", "램페이저", DnfJob.DemonicLancer);
        /// <summary>
        /// 에레보스
        /// </summary>
        public static readonly DnfJobGrowEnum Erebus = new("64bbd751c0fcae0e74758b871a2296c1", "에레보스", DnfJob.DemonicLancer);
        /// <summary>
        /// 眞 다크 랜서
        /// </summary>
        public static readonly DnfJobGrowEnum NeoImpaler = new("c9b492038ee3ca8d27d7004cf58d59f3", "眞 다크 랜서", DnfJob.DemonicLancer);
        #endregion

        #region 총검사
        /// <summary>
        /// 히트맨
        /// </summary>
        public static readonly DnfJobGrowEnum Hitman = new("df3870efe8e8754011cd12fa03cd275f", "히트맨", DnfJob.Agent);
        /// <summary>
        /// 빅보스
        /// </summary>
        public static readonly DnfJobGrowEnum BigBoss = new("4ec01f4ae3728c080f28a72213b6df10", "빅보스", DnfJob.Agent);
        /// <summary>
        /// 갓파더
        /// </summary>
        public static readonly DnfJobGrowEnum Godfather = new("80ec67d0356defa46a989914caca5820", "갓파더", DnfJob.Agent);
        /// <summary>
        /// 眞 히트맨
        /// </summary>
        public static readonly DnfJobGrowEnum NeoHitman = new("37495b941da3b1661bc900e68ef3b2c6", "眞 히트맨", DnfJob.Agent);
        /// <summary>
        /// 요원
        /// </summary>
        public static readonly DnfJobGrowEnum SecretAgent = new("1ea78ae210f681a799feb4403a5c1e85", "요원", DnfJob.Agent);
        /// <summary>
        /// 인포서
        /// </summary>
        public static readonly DnfJobGrowEnum Enforcer = new("981d675414f83b926db5f54e5347eec0", "인포서", DnfJob.Agent);
        /// <summary>
        /// 레퀴엠
        /// </summary>
        public static readonly DnfJobGrowEnum Executioner = new("8022a99e29b5e4845985fe1d79a233f3", "레퀴엠", DnfJob.Agent);
        /// <summary>
        /// 眞 요원
        /// </summary>
        public static readonly DnfJobGrowEnum NeoSecretAgent = new("618326026de1a1f1cfba5dbd0b8396e7", "眞 요원", DnfJob.Agent);
        /// <summary>
        /// 트러블 슈터
        /// </summary>
        public static readonly DnfJobGrowEnum Troubleshooter = new("a9a4ef4552d46e39cf6c874a51126410", "트러블 슈터", DnfJob.Agent);
        /// <summary>
        /// 와일드 카드
        /// </summary>
        public static readonly DnfJobGrowEnum WildCard = new("460822c3780a9bc3fbe9485cc89c44a4", "와일드 카드", DnfJob.Agent);
        /// <summary>
        /// 언터처블
        /// </summary>
        public static readonly DnfJobGrowEnum Renegade = new("15ce2751ab9c8302f39636cdb7c3dcfa", "언터처블", DnfJob.Agent);
        /// <summary>
        /// 眞 트러블 슈터
        /// </summary>
        public static readonly DnfJobGrowEnum NeoTroubleshooter = new("6d459bc74ba73ee4fe5cdc4655400193", "眞 트러블 슈터", DnfJob.Agent);
        /// <summary>
        /// 스페셜리스트
        /// </summary>
        public static readonly DnfJobGrowEnum Specialist = new("4a1459a4fa3c7f59b6da2e43382ed0b9", "스페셜리스트", DnfJob.Agent);
        /// <summary>
        /// 코어 마스터
        /// </summary>
        public static readonly DnfJobGrowEnum CoreMaster = new("faf8fc6f0cd4c0f84f0035e23bd4fa19", "코어 마스터", DnfJob.Agent);
        /// <summary>
        /// 패스파인더
        /// </summary>
        public static readonly DnfJobGrowEnum Pathfinder = new("64bbd751c0fcae0e74758b871a2296c1", "패스파인더", DnfJob.Agent);
        /// <summary>
        /// 眞 스페셜리스트
        /// </summary>
        public static readonly DnfJobGrowEnum NeoSpecialist = new("c9b492038ee3ca8d27d7004cf58d59f3", "眞 스페셜리스트", DnfJob.Agent);
        #endregion

        #region 다크나이트
        /// <summary>
        /// 다크나이트 자각1
        /// </summary>
        public static readonly DnfJobGrowEnum DarkKnight1 = new("4fdee159d5aa8874a1459861ced676ec", "자각1", DnfJob.DarkKnight);
        /// <summary>
        /// 다크나이트 자각2
        /// </summary>
        public static readonly DnfJobGrowEnum DarkKnight2 = new("da6a126f45370e1a4cbbe8823c6c35be", "자각2", DnfJob.DarkKnight);
        /// <summary>
        /// 眞 다크나이트
        /// </summary>
        public static readonly DnfJobGrowEnum NeoDarkKnight = new("0a49d9c8b5e1358efff324e5cb11d41e", "眞 다크나이트", DnfJob.DarkKnight);
        #endregion

        #region 크리에이터
        /// <summary>
        /// 크리에이터 자각1
        /// </summary>
        public static readonly DnfJobGrowEnum Creator1 = new("4fdee159d5aa8874a1459861ced676ec", "자각1", DnfJob.Creator);
        /// <summary>
        /// 크리에이터 자각2
        /// </summary>
        public static readonly DnfJobGrowEnum Creator2 = new("da6a126f45370e1a4cbbe8823c6c35be", "자각2", DnfJob.Creator);
        /// <summary>
        /// 眞 크리에이터
        /// </summary>
        public static readonly DnfJobGrowEnum NeoCreator = new("0a49d9c8b5e1358efff324e5cb11d41e", "眞 크리에이터", DnfJob.Creator);
        #endregion
    }
}
