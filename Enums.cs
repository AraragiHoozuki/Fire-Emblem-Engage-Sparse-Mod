public enum SkillData.Timings
{
	None = 0,
	Always = 1,
	BattleBefore = 2,
	BattleDetail = 3,
	BattleInvoke = 4,
	BattleStart = 5,
	OrderStart = 6,
	ActionStart = 7,
	AttackStart = 8,
	AttackBranch = 9,
	HitBefore = 10,
	HitAfter = 11,
	HitAffect = 12,
	AttackEnd = 13,
	ActionEnd = 14,
	OrderEnd = 15,
	BattleEnd = 16,
	BattleResult = 17,
	BattleAfter = 18,
	Around = 19,
	Support = 20,
	BattleCommand = 21,
	ActionCommand = 22,
	OverlapCommand = 23,
	SupportCommand = 24,
	FixedNone = 25,
	FixedDone = 26,
	PhaseStart = 27,
}

public enum SkillData.Attrs
{
	None = 0,
	Walk = 1,
	Horse = 2,
	Heavy = 4,
	Fly = 8,
	Dragon = 16,
	Evil = 32,
	Morph = 64,
	Mediuth = 128,
	Duma = 256,
	Loptous = 512,
	Veld = 1024,
	Idenn = 2048,
	Nergal = 4096,
	Fodeth = 8192,
	Ashnard = 16384,
	Astarte = 32768,
	Gimle = 65536,
	Hydra = 131072,
	Nemesis = 262144,
}

public enum SkillData.Stands
{
	None = 0,
	Offence = 1,
	Defence = 2,
}

public enum SkillData.Actions 
{
	None = 0,
	Offence = 1,
	Defence = 2,
}

public enum SkillData.Targets
{
	Target = 0,
	Enemy = 1,
	Friend = 2,
	Destroy = 3,
	Pierce = 4,
	Range = 5,
	Around = 6,
	Overlap = 7,
}

public enum SkillData.Cycles
{
	None = 0,
	Map = 1,
	PhaseBefore = 2,
	PhaseAfter = 3,
	Fixed = 4,
	Engaged = 5,
	Battled = 6,
	BattledOf = 7,
	BattledDf = 8,
}

public enum SkillData.States // TypeDefIndex: 10081
{
	None = 0,
	Poison = 1,
	DeadlyPoison = 2,
	SeverePoison = 4,
	Heal = 8,
	Sleep = 16,
	Silence = 32,
	Charm = 64,
	Confusion = 128,
	Freeze = 256,
	Weakness = 512,
	Stun = 1024,
	Interact = 2048,
	Decoy = 4096,
	NotEnhance = 8192,
	Enhance = 65536,
	Immovable = 131072,
	NotMove = 262144,
	NotWeaponWeight = 524288,
	NotChainAttacked = 1048576,
	IgnoreDebug = -2147483648,
	PoisonMask = 7,
}

public enum SkillData.GiveTargets
{
	Target = 0,
	Self = 1,
	Chain = 2,
	Around = 3,
	Dance = 4,
}

public enum SkillData.Categorys
{
	None = 0,
	Person = 1,
	Job = 2,
	Item = 3,
	Equip = 4,
	God = 5,
	Ring = 6,
	Hub = 7,
	Support = 8,
	Battle = 9,
	Private = 10,
	Inheritance = 11,
	Command = 12,
}

public enum SkillData.AroundCenters
{
	None = 0,
	Self = 1,
	Target = 2,
	Link = 3,
}

public enum SkillData.AroundTargets
{
	None = 0,
	Friend = 1,
	Enemy = 2,
	Both = 3,
}


public enum SkillData.Frequencies
{
	Every = 1,
	First = 2,
	Last = 4,
	Mask = 7,
}

public enum SkillData.Works
{
	None = 0,
	ItemHealScale = 1,
	JobGrowChange = 2,
	TotalGrowChange = 3,
}

public enum SkillData.Flags
{
    Invisible = 0x1,
    EngageAttack = 0x2,
    EngageCharge = 0x4,
    EngageLink = 0x8,
    EngageWait = 0x10,
    EngageSummon = 0x20,
    IgnoreEngageAttacking = 0x40,
    IgnoreNoEngageAttacking = 0x80,
    EnableChaining = 0x100,
    EnableDestory = 0x200,
    EnableCannon = 0x400,
    EnableRod = 0x800,
    IgnoreAlone = 0x1000,
    IgnoreMultiAttacking = 0x2000,
    IgnoreTraining = 0x4000,
    IgnoreTraial = 0x8000,
    IgnoreSimulation = 0x10000,
    ExclusiveDance = 0x20000,
    RevengeAutoEquip = 0x40000,
    SwapOrder = 0x80000,
    InterruptOrder = 0x100000,
    ContinueBattle = 0x200000,
    ForceLateOrder = 0x400000,
    EachSupport = 0x800000,
    Reactable = 0x1000000,
    Remagicable = 0x2000000,
    BeforeMove = 0x4000000,
    AllowChainAttack = 0x8000000,
    AllowChainGuard = 0x10000000,
    AllowEngageGuard = 0x20000000,
    ForceChainAttack = 0x40000000,
    JoinChainAttack = 0x80000000,
    RangeReliance = 0x100000000,
    PickupReliance = 0x200000000,
    MoveCostFree = 0x400000000,
    MoveEnemyPass = 0x800000000,
    ResetDisorder = 0x1000000000,
    ItemHealAround = 0x2000000000,
    ItemHealGive = 0x4000000000,
    SelfHealRod = 0x8000000000,
    OnlyRecvoerRod = 0x10000000000,
    DecayEnhance = 0x20000000000,
    SubEngageCountLimit = 0x40000000000,
    ReverseCount = 0x80000000000,
    ReCooking = 0x100000000000,
    BasisSkill = 0x200000000000,
    Unstoppable = 0x400000000000,
    HideChangeGod = 0x800000000000,
    OverExpChange = 0x1000000000000,
    MoveFly = 0x2000000000000,
    ViewRestriction = 0x4000000000000,
    HasIconBmap = 0x20000000000000,
    HasContract = 0x40000000000000,
    HauntChainAttack = 0x80000000000000,
    HasRootCommand = 0x100000000000000,
    HasZOC = 0x200000000000000,
    HasWork = 0x400000000000000,
    HasVision = 0x800000000000000,
    NotCondition = 0x1000000000000000,
    HasCondition = 0x2000000000000000,
    HasEnhance = 0x4000000000000000,
    HasRangeTarget = -0x8000000000000000,
    IgnoreMask = 0x1F0C0,
}


public enum ItemData.Flags
{
	Rarity = 1,
	NotTrade = 2,
	CanUse = 4,
	OnlyChapter = 8,
	OnlyEnemy = 16,
	OnlyMale = 32,
	OnlyFemale = 64,
	Engage = 128,
	IgnoreWeaponLevel = 256,
	Unpublic = 512,
	NotEntrust = 1024,
	InvertInteract = 2048,
	Download = 4096,
	KeyDoor = 8192,
	KeyTreasureBox = 16384,
	AIUnequipable = 32768,
	ReverseAttribute = 65536,
	LunchBox = 131072,
	SimpleHelp = 262144,
	RangeTarget = 524288,
	IgnoreCombat = 1048576,
	ForcedCombat = 2097152,
	Bless = 16777216,
	Breath = 33554432,
	Dragon = 67108864,
	Bullet = 134217728,
}

//for range type
public enum ItemData.Kinds
{
	None = 0,
	Sword = 1,
	Lance = 2,
	Axe = 3,
	Bow = 4,
	Dagger = 5,
	Magic = 6,
	Rod = 7,
	Fist = 8,
	Special = 9,
	Tool = 10,
	Shield = 11,
	Accessory = 12,
	Precious = 13,
	RefineIron = 14,
	RefineSteel = 15,
	RefineSilver = 16,
	PieceOfBond = 17,
	Gold = 18,
	Num = 19,
	WeaponNum = 10,
}

//for aptitud
public enum WeaponMask.Flag 
{
	None = 1,
	Sword = 2,
	Lance = 4,
	Axe = 8,GainSkillPoint
	Bow = 16,
	Dagger = 32,
	Magic = 64,
	Rod = 128,
	Fist = 256,
	Special = 512,
}

public enum ItemData.UseTypes
{
	None = 0,
	Attack = 1,
	Heal = 2,
	RestHeal = 3,
	Revive = 4,
	Warp = 5,
	Rescue = 6,
	EngageAdd = 7,
	Rewarp = 8,
	Freeze = 9,
	Sleep = 10,
	Silence = 11,
	Charm = 12,
	Berserk = 13,
	Weakness = 14,
	Again = 15,
	Torch = 16,
	Food = 17,
	Rest = 18,
	SightUp = 19,
	WeaponLevelUp = 20,
	GrowUp = 21,
	Enhance = 22,
	CCMaster = 23,
	CCChange = 24,
	CCExtra = 25,
	Creation = 26,
	Draw = 27,
	GainExp = 28,
	Stun = 29,
	Detox = 30,
	GiveSkill = 31,
	Foodstuff = 32,
	Gift = 33,
	Material = 34,
	FishingRod = 35,
	Bless = 36,
	BlessRest = 37,
	BlessPlus = 38,
	BlessRestPlus = 39,
	CCEnchant = 40,
	CCGunner = 41,
	GainSkillPoint = 42,
}

public enum JobData.Flags // TypeDefIndex: 9965
{
	CanCC = 1,
	AnyoneCC = 2,
	FemaleOnly = 4,
	EncountMap = 8,
}



public enum ChapterData.Flags // TypeDefIndex: 9837
{
	// Fields
	public int value__; // 0x0
	public const ChapterData.Flags Sally = 1;
	public const ChapterData.Flags CanBack = 2;
	public const ChapterData.Flags Sight = 4;
	public const ChapterData.Flags Kizuna = 8;
	public const ChapterData.Flags Hub = 16;
	public const ChapterData.Flags Gmap = 32;
	public const ChapterData.Flags Continue = 64;
	public const ChapterData.Flags Serious = 128;
	public const ChapterData.Flags Casual = 256;
	public const ChapterData.Flags Challenge = 512;
	public const ChapterData.Flags Relay = 1024;
	public const ChapterData.Flags Versus = 2048;
	public const ChapterData.Flags TestMap = 4096;
	public const ChapterData.Flags Opposition = 8192;
	public const ChapterData.Flags HighRankItem = 16384;
	public const ChapterData.Flags CanSlope = 32768;
	public const ChapterData.Flags SideStory = 1073741824;
	public const ChapterData.Flags Scenario = -2147483648;
}

public enum DisposData.Flags // TypeDefIndex: 9868
{
	// Fields
	public int value__; // 0x0
	public const DisposData.Flags Normal = 1;
	public const DisposData.Flags Hard = 2;
	public const DisposData.Flags Lunatic = 4;
	public const DisposData.Flags Create = 8;
	public const DisposData.Flags Leader = 16;
	public const DisposData.Flags NotMove = 32;
	public const DisposData.Flags Edge = 64;
	public const DisposData.Flags Pos = 128;
	public const DisposData.Flags Must = 256;
	public const DisposData.Flags Fix = 512;
	public const DisposData.Flags Guest = 1024;
	public const DisposData.Flags MaskSortie = 896;
	public const DisposData.Flags MaskDifficulty = 7;
}

public enum DisposData.AIFlags // TypeDefIndex: 9870
{
	// Fields
	public int value__; // 0x0
	public const DisposData.AIFlags NotActivateByAttacked = 1;
	public const DisposData.AIFlags Dummy = 2;
	public const DisposData.AIFlags ZeroAttack = 4;
	public const DisposData.AIFlags Heal = 8;
	public const DisposData.AIFlags Break = 16;
	public const DisposData.AIFlags Chain = 32;
	public const DisposData.AIFlags EquipShortAfterLongRange = 64;
	public const DisposData.AIFlags MoveBreak = 128;
	public const DisposData.AIFlags EngageAttackOnce = 256;
}