using System;
using System.Collections.Generic;
using ProtoBuf;

namespace AngryBirdsEpicAllStarsSaveEditor
{
    [ProtoContract]
    public class TimingData
    {
        [ProtoMember(1)]
        public int ServerSyncTime;

        [ProtoMember(2)]
        public int ClientSyncTime;

        [ProtoMember(3)]
        public int LatestClientTimeReturned;
    }

    public enum HotspotUnlockState
    {
        Unknown,
        Hidden,
        Active,
        ResolvedNew = 10,
        Resolved,
        ResolvedBetter
    }

    public enum HotspotAnimationState
    {
        None,
        Inactive = 5,
        Active = 10,
        Open = 15
    }

    [ProtoContract]
    public class HotspotData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public HotspotUnlockState UnlockState { get; set; }

        [ProtoMember(3)]
        public int StarCount { get; set; }

        [ProtoMember(4)]
        public DateTime LastVisitDateTime { get; set; }

        [ProtoMember(5)]
        public bool Looted { get; set; }

        [ProtoMember(6)]
        public int Score { get; set; }

        [ProtoMember(7)]
        public int RandomSeed { get; set; }

        [ProtoMember(8)]
        public HotspotAnimationState AnimationState { get; set; }

        [ProtoMember(9)]
        public int CompletionPlayerLevel { get; set; }
    }

    [ProtoContract]
    public class BasicItemData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Level { get; set; }

        [ProtoMember(3)]
        public int Value { get; set; }

        [ProtoMember(4)]
        public int Quality { get; set; }

        [ProtoMember(5)]
        public bool IsNew { get; set; }

        [ProtoMember(6)]
        public int IsNewInShop { get; set; }
    }

    [ProtoContract]
    public class WorldData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public List<HotspotData> HotSpotInstances { get; set; }

        [ProtoMember(3)]
        public HotspotData CurrentHotSpotInstance { get; set; }

        [ProtoMember(4)]
        public HotspotData DailyHotspotInstance { get; set; }
    }

    [ProtoContract]
    public class ClassItemData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Level { get; set; }

        [ProtoMember(3)]
        public int Value { get; set; }

        [ProtoMember(4)]
        public int Quality { get; set; }

        [ProtoMember(5)]
        public bool IsNew { get; set; }

        [ProtoMember(6)]
        public float ExperienceForNextLevel { get; set; }
    }

    public enum EquipmentSource
    {
        Loot,
        Crafting,
        Gatcha,
        SetItem,
        LootBird,
        DailyGift
    }

    [ProtoContract]
    public class EquipmentData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Level { get; set; }

        [ProtoMember(3)]
        public int Value { get; set; }

        [ProtoMember(4)]
        public int Quality { get; set; }

        [ProtoMember(5)]
        public Dictionary<string, int> ScrapLoot { get; set; }

        [ProtoMember(6)]
        public bool IsNew { get; set; }

        [ProtoMember(7)]
        public EquipmentSource ItemSource { get; set; }

        [ProtoMember(8)]
        public int EnchantmentLevel { get; set; }

        [ProtoMember(9)]
        public float EnchantmentProgress { get; set; }

        [ProtoMember(10)]
        public bool IsAncient { get; set; }
    }

    [ProtoContract]
    public class CraftingItemData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Level { get; set; }

        [ProtoMember(3)]
        public int Value { get; set; }

        [ProtoMember(4)]
        public int Quality { get; set; }

        [ProtoMember(5)]
        public bool IsNew { get; set; }
    }

    [ProtoContract]
    public class ConsumableItemData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Level { get; set; }

        [ProtoMember(3)]
        public int Value { get; set; }

        [ProtoMember(4)]
        public int Quality { get; set; }

        [ProtoMember(5)]
        public bool IsNew { get; set; }
    }

    [ProtoContract]
    public class CraftingRecipeData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Level { get; set; }

        [ProtoMember(3)]
        public int Value { get; set; }

        [ProtoMember(4)]
        public int Quality { get; set; }

        [ProtoMember(5)]
        public bool IsNew { get; set; }

        [ProtoMember(6)]
        public bool IsNewInShop { get; set; }
    }

    [ProtoContract]
    public class EventItemData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Level { get; set; }

        [ProtoMember(3)]
        public int Value { get; set; }

        [ProtoMember(4)]
        public int Quality { get; set; }

        [ProtoMember(5)]
        public bool IsNew { get; set; }

        [ProtoMember(6)]
        public string PositionId { get; set; }
    }

    [ProtoContract]
    public class MasteryItemData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Level { get; set; }

        [ProtoMember(3)]
        public int Value { get; set; }

        [ProtoMember(4)]
        public int Quality { get; set; }

        [ProtoMember(5)]
        public bool IsNew { get; set; }
    }

    [ProtoContract]
    public class BannerItemData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Level { get; set; }

        [ProtoMember(3)]
        public int Value { get; set; }

        [ProtoMember(4)]
        public int Quality { get; set; }

        [ProtoMember(5)]
        public bool IsNew { get; set; }

        [ProtoMember(6)]
        public EquipmentSource ItemSource { get; set; }

        [ProtoMember(7)]
        public int EnchantmentLevel { get; set; }

        [ProtoMember(8)]
        public float EnchantmentProgress { get; set; }

        [ProtoMember(9)]
        public int Stars { get; set; }

        [ProtoMember(10)]
        public bool IsAncient { get; set; }
    }

    [ProtoContract]
    public class SkinItemData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Level { get; set; }

        [ProtoMember(3)]
        public int Value { get; set; }

        [ProtoMember(4)]
        public int Quality { get; set; }

        [ProtoMember(5)]
        public bool IsNew { get; set; }
    }

    [ProtoContract]
    public class InventoryData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public List<BasicItemData> StoryItems { get; set; }

        [ProtoMember(3)]
        public List<BasicItemData> PlayerStats { get; set; }

        [ProtoMember(4)]
        public List<ClassItemData> ClassItems { get; set; }

        [ProtoMember(5)]
        public List<EquipmentData> MainHandItems { get; set; }

        [ProtoMember(6)]
        public List<EquipmentData> OffHandItems { get; set; }

        [ProtoMember(7)]
        public List<CraftingItemData> CraftingResourceItems { get; set; }

        [ProtoMember(8)]
        public List<CraftingItemData> CraftingIngredientItems { get; set; }

        [ProtoMember(9)]
        public List<ConsumableItemData> ConsumableItems { get; set; }

        [ProtoMember(10)]
        public List<CraftingRecipeData> CraftingRecipesItems { get; set; }

        [ProtoMember(11)]
        public Dictionary<string, int> DelayedRewards { get; set; }

        [ProtoMember(12)]
        public List<EventItemData> EventItems { get; set; }

        [ProtoMember(13)]
        public List<MasteryItemData> MasteryItems { get; set; }

        [ProtoMember(14)]
        public List<BannerItemData> BannerItems { get; set; }

        [ProtoMember(15)]
        public List<BasicItemData> TrophyItems { get; set; }

        [ProtoMember(16)]
        public List<BasicItemData> CollectionComponents { get; set; }

        [ProtoMember(17)]
        public List<SkinItemData> SkinItems { get; set; }
    }

    [ProtoContract]
    public class BirdData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Level { get; set; }

        [ProtoMember(3)]
        public InventoryData Inventory { get; set; }

        [ProtoMember(4)]
        public bool IsUnavaliable { get; set; }
    }

    [ProtoContract]
    public class ChronicleCaveData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public List<ChronicleCaveFloorData> CronicleCaveFloors { get; set; }

        [ProtoMember(3)]
        public int CurrentFloorIndex { get; set; }

        [ProtoMember(4)]
        public HotspotData CurrentHotSpotInstance { get; set; }

        [ProtoMember(5)]
        public int CurrentBirdFloorIndex { get; set; }

        [ProtoMember(6)]
        public uint VisitedDailyTreasureTimestamp { get; set; }
    }

    [ProtoContract]
    public class ChronicleCaveFloorData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int FloorId { get; set; }

        [ProtoMember(3)]
        public List<HotspotData> HotSpotInstances { get; set; }

        [ProtoMember(4)]
        public int FloorBaseLevel { get; set; }
    }

    public enum LocationType
    {
        World,
        ChronicleCave,
        EventCampaign
    }

    [ProtoContract]
    public class BannerData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Level { get; set; }

        [ProtoMember(3)]
        public InventoryData Inventory { get; set; }
    }

    [ProtoContract]
    public class TrophyData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Seasonid { get; set; }

        [ProtoMember(3)]
        public int FinishedLeagueId { get; set; }
    }

    [ProtoContract]
    public class WorldBossTeamData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int TeamColor { get; set; }

        [ProtoMember(3)]
        public List<float> TeamPlayerSeeds { get; set; }

        [ProtoMember(4)]
        public float ScorePenalty { get; set; }

        [ProtoMember(5)]
        public List<string> TeamPlayerIds { get; set; }

        [ProtoMember(6)]
        public uint LastProcessedBossDefeat { get; set; }
    }

    public enum EventCampaignRewardStatus
    {
        locked,
        unlocked_new,
        unlocked,
        unlocked_new_fallback,
        unlocked_fallback,
        chest_claimed
    }

    [ProtoContract]
    public class WorldEventBossData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public List<uint> DefeatedTimestamp { get; set; }

        [ProtoMember(3)]
        public WorldBossTeamData Team1 { get; set; }

        [ProtoMember(4)]
        public WorldBossTeamData Team2 { get; set; }

        [ProtoMember(5)]
        public int OwnTeamId { get; set; }

        [ProtoMember(6)]
        public int NumberOfAttacks { get; set; }

        [ProtoMember(7)]
        public int DeathCount { get; set; }

        [ProtoMember(8)]
        public int VictoryCount { get; set; }

        [ProtoMember(9)]
        public EventCampaignRewardStatus RewardStatus { get; set; }

        [ProtoMember(10)]
        public float LastDisplayedBossHealth { get; set; }

        [ProtoMember(11)]
        public List<KeyValuePair<string, uint>> DefeatsToProcess { get; set; }
    }

    [ProtoContract]
    public class PublicPlayerData
    {
        [ProtoMember(1)]
        public string SocialId { get; set; }

        [ProtoMember(2)]
        public InventoryData Inventory { get; set; }

        [ProtoMember(3)]
        public List<BirdData> Birds { get; set; }

        [ProtoMember(4)]
        public ChronicleCaveData ChronicleCave { get; set; }

        [ProtoMember(5)]
        public Dictionary<LocationType, int> LocationProgress { get; set; }

        [ProtoMember(6)]
        public uint LastSaveTime { get; set; }

        [ProtoMember(7)]
        public int Level { get; set; }

        [ProtoMember(8)]
        public string SocialPlayerName { get; set; }

        [ProtoMember(9)]
        public string SocialAvatarUrl { get; set; }

        [ProtoMember(10)]
        public string EventPlayerName { get; set; }

        [ProtoMember(11)]
        public BannerData Banner { get; set; }

        [ProtoMember(12)]
        public List<int> PvPIndices { get; set; }

        [ProtoMember(13)]
        public int PvPRank { get; set; }

        [ProtoMember(14)]
        public int League { get; set; }

        [ProtoMember(15)]
        public TrophyData Trophy { get; set; }

        [ProtoMember(16)]
        public WorldEventBossData WorldBoss { get; set; }

        [ProtoMember(17)]
        public float RandomDecisionSeed { get; set; }
    }

    public enum MessageType
    {
        None,
        RequestInvitationMessage,
        RequestFriendshipEssenceMessage,
        RequestFriendshipGateMessage,
        ResponseFriendshipEssenceMessage,
        ResponseFriendshipGateMessage,
        ResponseBirdBorrowMessage,
        ResponseInvitationMessage,
        ResponseSpecialUnlockMessage,
        ResponseGachaUseMessage,
        CustomMessageGameData,
        DefeatedFriendMessage,
        DefeatedByFriendMessage,
        ResponsePvpGachaUseMessage,
        WonInPvpChallengeMessage
    }

    [ProtoContract]
    public class FriendData
    {
        [ProtoMember(1)]
        public string FirstName { get; set; }

        [ProtoMember(2)]
        public string Id { get; set; }

        [ProtoMember(3)]
        public string PictureUrl { get; set; }

        [ProtoMember(4)]
        public bool IsSilhouettePicture { get; set; }

        [ProtoMember(5)]
        public bool HasBonus { get; set; }

        [ProtoMember(6)]
        public int Level { get; set; }

        [ProtoMember(7)]
        public bool IsNPC { get; set; }

        [ProtoMember(8)]
        public bool IsInstalled { get; set; }

        [ProtoMember(9)]
        public bool NeedsPayment { get; set; }

        [ProtoMember(10)]
        public int PvpRank { get; set; }

        [ProtoMember(11)]
        public int PvpLeague { get; set; }
    }

    [ProtoContract]
    public class MessageDataIncoming
    {
        [ProtoMember(1)]
        public string Id { get; set; }

        [ProtoMember(2)]
        public MessageType MessageType { get; set; }

        [ProtoMember(3)]
        public FriendData Sender { get; set; }

        [ProtoMember(4)]
        public uint ReceivedAt { get; set; }

        [ProtoMember(5)]
        public uint UsedAt { get; set; }

        [ProtoMember(6)]
        public uint ViewedAt { get; set; }

        [ProtoMember(7)]
        public uint SentAt { get; set; }

        [ProtoMember(8)]
        public string Parameter1 { get; set; }

        [ProtoMember(9)]
        public int Parameter2 { get; set; }
    }

    [ProtoContract]
    public class SocialEnvironmentData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public string SocialId { get; set; }

        [ProtoMember(3)]
        public List<string> InvitedFriendIds { get; set; }

        [ProtoMember(4)]
        public List<string> AcceptedFriendIds { get; set; }

        [ProtoMember(5)]
        public Dictionary<string, uint> GetBirdCooldowns { get; set; }

        [ProtoMember(6)]
        public Dictionary<string, uint> GetFreeGachaRollCooldowns { get; set; }

        [ProtoMember(7)]
        public List<string> FreeGachaRollFriendIds { get; set; }

        [ProtoMember(8)]
        public uint LastGachaFreeRollSpawn { get; set; }

        [ProtoMember(9)]
        public List<PublicPlayerData> PublicPlayerInstances { get; set; }

        [ProtoMember(10)]
        public Dictionary<string, List<string>> FriendShipGateUnlocks { get; set; }

        [ProtoMember(11)]
        public List<MessageDataIncoming> Messages { get; set; }

        [ProtoMember(12)]
        public Dictionary<LocationType, int> LocationProgress { get; set; }

        [ProtoMember(13)]
        public string SocialPictureUrl { get; set; }

        [ProtoMember(14)]
        public string SocialPlayerName { get; set; }

        [ProtoMember(15)]
        public string IdLoginEmail { get; set; }

        [ProtoMember(16)]
        public string IdPassword { get; set; }

        [ProtoMember(17)]
        public Dictionary<string, List<string>> NewFriendShipGateUnlocks { get; set; }

        [ProtoMember(18)]
        public List<string> PendingFriendIds { get; set; }

        [ProtoMember(19)]
        public string LastMessagingCursor { get; set; }

        [ProtoMember(20)]
        public Dictionary<string, uint> FriendShipGateHelpCooldowns { get; set; }

        [ProtoMember(21)]
        public uint FriendShipEssenceCooldown { get; set; }

        [ProtoMember(22)]
        public bool FetchedMessagesOnce { get; set; }

        [ProtoMember(23)]
        public uint FirstMessageFetchTime { get; set; }

        [ProtoMember(24)]
        public uint FriendShipEssenceMessageCapResetTime { get; set; }

        [ProtoMember(25)]
        public int FriendShipEssenceMessageCapCount { get; set; }

        [ProtoMember(26)]
        public List<MessageDataIncoming> ResendMessages { get; set; }

        [ProtoMember(27)]
        public string MatchmakingPlayerName { get; set; }

        [ProtoMember(28)]
        public string EventPlayerName { get; set; }

        [ProtoMember(29)]
        public uint McCoolVisitsGachaTimestamp { get; set; }

        [ProtoMember(30)]
        public uint McCoolLendsBirdTimestamp { get; set; }

        [ProtoMember(31)]
        public uint McCoolSendsEssenceTimestamp { get; set; }

        [ProtoMember(32)]
        public List<string> FreePvpGachaRollFriendIds { get; set; }

        [ProtoMember(33)]
        public Dictionary<string, uint> GetFreePvpGachaRollCooldowns { get; set; }

        [ProtoMember(34)]
        public uint LastPvpGachaFreeRollSpawn { get; set; }

        [ProtoMember(35)]
        public uint McCoolVisitsPvpGachaTimestamp { get; set; }

        [ProtoMember(36)]
        public int FriendShipEssenceMessageByBirdCapCount { get; set; }
    }

    [ProtoContract]
    public class CustomMessage
    {
        [ProtoMember(1)]
        public string Key;

        [ProtoMember(2)]
        public string NameId;
    }

    [ProtoContract]
    public class EventData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }
    }

    public enum EventManagerState
    {
        Invalid = -1,
        Teasing,
        Running,
        Finished,
        FinishedWithoutPoints,
        FinishedAndResultIsValid,
        FinishedAndConfirmed
    }

    [ProtoContract]
    public class EventCampaignData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public HotspotData CurrentHotSpotInstance { get; set; }

        [ProtoMember(3)]
        public List<HotspotData> HotSpotInstances { get; set; }

        [ProtoMember(4)]
        public EventCampaignRewardStatus RewardStatus { get; set; }
    }

    [ProtoContract]
    public class BossData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Level { get; set; }

        [ProtoMember(3)]
        public InventoryData Inventory { get; set; }

        [ProtoMember(4)]
        public bool IsUnavaliable { get; set; }

        [ProtoMember(5)]
        public string EventNodeId { get; set; }

        [ProtoMember(6)]
        public int LastPositionSwapOnDefeat { get; set; }
    }

    [ProtoContract]
    public class EventManagerData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public EventData CurentEventInstance { get; set; }

        [ProtoMember(3)]
        public uint CurrentScore { get; set; }

        [ProtoMember(4)]
        public EventManagerState CurrentState { get; set; }

        [ProtoMember(5)]
        public bool MatchmakingScoreSubmitted { get; set; }

        [ProtoMember(6)]
        public List<string> CurrentOpponents { get; set; }

        [ProtoMember(7)]
        public long MatchmakingScore { get; set; }

        [ProtoMember(8)]
        public int MatchmakingScoreOffset { get; set; }

        [ProtoMember(9)]
        public int CachedRolledResultWheelIndex { get; set; }

        [ProtoMember(10)]
        public uint LastEncounterSpawnTime { get; set; }

        [ProtoMember(11)]
        public uint WatchedDailyEventRewardTimestamp { get; set; }

        [ProtoMember(12)]
        public uint LastCollectibleSpawnTime { get; set; }

        [ProtoMember(13)]
        public EventCampaignData EventCampaignData { get; set; }

        [ProtoMember(14)]
        public BossData EventBossData { get; set; }

        [ProtoMember(15)]
        public bool PopupTeaserShown { get; set; }

        [ProtoMember(16)]
        public string LeaderboardId { get; set; }

        [ProtoMember(17)]
        public List<string> CheatingOpponents { get; set; }

        [ProtoMember(18)]
        public int StartingPlayerLevel { get; set; }

        [ProtoMember(19)]
        public string ConfirmedChestLootId { get; set; }
    }

    public enum PvPSeasonState
    {
        Invalid = -1,
        Pending,
        Running,
        Finished,
        FinishedWithoutPoints,
        FinishedAndResultIsValid,
        FinishedAndConfirmed
    }

    [ProtoContract]
    public class PvPTurnManagerData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int CurrentSeason { get; set; }

        [ProtoMember(3)]
        public uint CurrentScore { get; set; }

        [ProtoMember(4)]
        public EventManagerState CurrentState { get; set; }

        [ProtoMember(5)]
        public bool MatchmakingScoreSubmitted { get; set; }

        [ProtoMember(6)]
        public List<string> CurrentOpponents { get; set; }

        [ProtoMember(7)]
        public long MatchmakingScore { get; set; }

        [ProtoMember(8)]
        public int MatchmakingScoreOffset { get; set; }

        [ProtoMember(9)]
        public int CachedRolledResultWheelIndex { get; set; }

        [ProtoMember(10)]
        public uint LastUsedPvpEnergy { get; set; }

        [ProtoMember(11)]
        public int CurrentMatchingDifficulty { get; set; }

        [ProtoMember(12)]
        public string LeaderboardId { get; set; }

        [ProtoMember(13)]
        public List<string> CheatingOpponents { get; set; }

        [ProtoMember(14)]
        public int StartingPlayerLevel { get; set; }
    }

    [ProtoContract]
    public class PvPSeasonManagerData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int CurrentLeague { get; set; }

        [ProtoMember(3)]
        public int CurrentSeason { get; set; }

        [ProtoMember(4)]
        public PvPSeasonState CurrentSeasonState { get; set; }

        [ProtoMember(5)]
        public PvPTurnManagerData CurrentSeasonTurn { get; set; }

        [ProtoMember(6)]
        public bool HasPendingDemotionPopup { get; set; }

        [ProtoMember(7)]
        public int CurrentRank { get; set; }

        [ProtoMember(8)]
        public int HighestLeagueRecord { get; set; }
    }

    [ProtoContract]
    public class PvPObjectiveData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Progress { get; set; }

        [ProtoMember(3)]
        public bool Solved { get; set; }

        [ProtoMember(4)]
        public string Difficulty { get; set; }

        [ProtoMember(5)]
        public List<string> ProgressList { get; set; }
    }

    [ProtoContract]
    public class AchievementData
    {
        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int PvpfightsWon { get; set; }

        [ProtoMember(3)]
        public int MaxLeagueReached { get; set; }

        [ProtoMember(4)]
        public int ObjectivesCompleted { get; set; }

        [ProtoMember(5)]
        public List<string> DefeatedClasses { get; set; }

        [ProtoMember(6)]
        public List<string> PlayedClasses { get; set; }

        [ProtoMember(7)]
        public bool BannerSetCompleted { get; set; }

        [ProtoMember(8)]
        public bool Pvpunlocked { get; set; }

        [ProtoMember(9)]
        public bool ReachedTopSpotAnyLeague { get; set; }

        [ProtoMember(10)]
        public bool EventCompletedZombie { get; set; }

        [ProtoMember(11)]
        public bool EventCompletedPirate { get; set; }

        [ProtoMember(12)]
        public bool EventCompletedNinja { get; set; }

        [ProtoMember(13)]
        public bool ReachedTopSpotEvent { get; set; }

        [ProtoMember(14)]
        public bool ReachedTopSpotDiamondLeague { get; set; }

        [ProtoMember(15)]
        public bool PvpfightsWonAchieved { get; set; }

        [ProtoMember(16)]
        public bool ObjectivesCompletedAchieved { get; set; }

        [ProtoMember(17)]
        public bool ChronicleCavesCompletedAchieved { get; set; }
    }

    [ProtoContract]
    public class PlayerData
    {

        [ProtoMember(1)]
        public string NameId { get; set; }

        [ProtoMember(2)]
        public int Level { get; set; }

        [ProtoMember(3)]
        public WorldData World { get; set; }

        [ProtoMember(4)]
        public InventoryData Inventory { get; set; }

        [ProtoMember(5)]
        public List<BirdData> Birds { get; set; }

        [ProtoMember(6)]
        public string ParserVersion { get; set; }

        [ProtoMember(7)]
        public uint LastSaveTimestamp { get; set; }

        [ProtoMember(8)]
        public string DeviceName { get; set; }

        [ProtoMember(9)]
        public float Experience { get; set; }

        [ProtoMember(10)]
        public Dictionary<string, int> TutorialTracks { get; set; }

        [ProtoMember(11)]
        public string GoldenPigHotspotId { get; set; }

        [ProtoMember(12)]
        public uint LastGoldenPigSpawnTime { get; set; }

        [ProtoMember(13)]
        public uint LastGoldenPigFailTime { get; set; }

        [ProtoMember(14)]
        public bool IsMusicMuted { get; set; }

        [ProtoMember(15)]
        public bool IsSoundMuted { get; set; }

        [ProtoMember(16)]
        public List<string> CurrentClassUpgradeShopOffers { get; set; }

        [ProtoMember(17)]
        public List<string> NextClassUpgradeShopOffers { get; set; }

        [ProtoMember(18)]
        public uint LastClassSwitchTime { get; set; }

        [ProtoMember(19)]
        public List<int> SelectedBirdIndices { get; set; }

        [ProtoMember(20)]
        public List<string> PendingFeatureUnlocks { get; set; }

        [ProtoMember(21)]
        public ChronicleCaveData ChronicleCave { get; set; }

        [ProtoMember(22)]
        public string IdentityAccessToken { get; set; }

        [ProtoMember(23)]
        public SocialEnvironmentData SocialEnvironment { get; set; }

        [ProtoMember(24)]
        public Dictionary<string, DateTime> CurrentSpecialShopOffers { get; set; }

        [ProtoMember(25)]
        public string ClientVersion { get; set; }

        [ProtoMember(26)]
        public string UserToken { get; set; }

        [ProtoMember(27)]
        public uint LastResourceNodeSpawnTime { get; set; }

        [ProtoMember(28)]
        public List<string> TemporaryOpenHotspots { get; set; }

        [ProtoMember(29)]
        public Dictionary<string, bool> ShopOffersNew { get; set; }

        [ProtoMember(30)]
        public List<string> DungeonsAlreadyPlayedToday { get; set; }

        [ProtoMember(31)]
        public uint SkynestAnalyticsSessionId { get; set; }

        [ProtoMember(32)]
        public int NotificationUsageState { get; set; }

        [ProtoMember(33)]
        public bool IsUserConverted { get; set; }

        [ProtoMember(34)]
        public uint LastInventoryBalanceTime { get; set; }

        [ProtoMember(35)]
        public bool HasNewOnWorlmap { get; set; }

        [ProtoMember(36)]
        public uint CreationDate { get; set; }

        [ProtoMember(37)]
        public uint LastAdShownTime { get; set; }

        [ProtoMember(38)]
        public List<string> UniqueSpecialShopOffers { get; set; }

        [ProtoMember(39)]
        public Dictionary<string, uint> SponsoredAdUses { get; set; }

        [ProtoMember(40)]
        public string CurrentSponsoredBuff { get; set; }

        [ProtoMember(41)]
        public bool RovioIdRegisterOnce { get; set; }

        [ProtoMember(42)]
        public uint LastGoldenPigDefeatedTime { get; set; }

        [ProtoMember(43)]
        public uint RestedBonusLastPauseTimeStart { get; set; }

        [ProtoMember(44)]
        public uint RestedBonusPauseTimeSum { get; set; }

        [ProtoMember(45)]
        public int RestedBonusBattles { get; set; }

        [ProtoMember(46)]
        public bool RestedBonusUIShowenOnes { get; set; }

        [ProtoMember(47)]
        public bool RestedBonusExhaustedShowenOnes { get; set; }

        [ProtoMember(48)]
        public List<CustomMessage> AcknowledgedCustomMessages { get; set; }

        [ProtoMember(49)]
        public uint LastRainbowRiotTime { get; set; }

        [ProtoMember(50)]
        public EventManagerData CurrentEventManager { get; set; }

        [ProtoMember(51)]
        public EventManagerData LastFinishedEventManager { get; set; }

        [ProtoMember(52)]
        public int ActivityIndicator { get; set; }

        [ProtoMember(53)]
        public List<int> EventFinishStatistic { get; set; }

        [ProtoMember(54)]
        public Dictionary<string, int> PendingClassRankUps { get; set; }

        [ProtoMember(55)]
        public uint LastEnergyAddTime { get; set; }

        [ProtoMember(56)]
        public int DojoOffersBought { get; set; }

        [ProtoMember(57)]
        public bool RestedBonusPopupDisplayed { get; set; }

        [ProtoMember(58)]
        public BannerData PvPBanner { get; set; }

        [ProtoMember(59)]
        public PvPSeasonManagerData PvpSeasonManager { get; set; }

        [ProtoMember(60)]
        public List<PvPObjectiveData> PvpObjectives { get; set; }

        [ProtoMember(61)]
        public List<int> SelectedPvPBirdIndices { get; set; }

        [ProtoMember(62)]
        public bool WonAvengerByStars { get; set; }

        [ProtoMember(63)]
        public bool HasPendingSeasonendPopup { get; set; }

        [ProtoMember(64)]
        public string m_CachedSeasonName { get; set; }

        [ProtoMember(65)]
        public int UtcOffset { get; set; }

        [ProtoMember(66)]
        public uint LastTimezonePersistTimestamp { get; set; }

        [ProtoMember(67)]
        public bool IsDaylightSavingTime { get; set; }

        [ProtoMember(68)]
        public AchievementData AchievementTracking { get; set; }

        [ProtoMember(69)]
        public uint EnterNicknameTutorialDone { get; set; }

        [ProtoMember(70)]
        public TrophyData PvPTrophy { get; set; }

        [ProtoMember(71)]
        public int HighestFinishedLeague { get; set; }

        [ProtoMember(72)]
        public int HardCurrencySpent { get; set; }

        [ProtoMember(73)]
        public Dictionary<string, int> OverAllSeasonPvpPoints { get; set; }

        [ProtoMember(74)]
        public bool EventEnergyTutorialDisplayed { get; set; }

        [ProtoMember(75)]
        public uint PvPTutorialDisplayState { get; set; }

        [ProtoMember(76)]
        public uint LastDailyGiftClaimedTime { get; set; }

        [ProtoMember(77)]
        public uint GiftsClaimedThisMonth { get; set; }

        [ProtoMember(78)]
        public float CoinFlipLoseChance { get; set; }

        [ProtoMember(79)]
        public int NextGoldenPigSpawnOffset { get; set; }

        [ProtoMember(80)]
        public bool SetInfoDisplayed { get; set; }

        [ProtoMember(81)]
        public List<string> BossIntrosPlayed { get; set; }

        [ProtoMember(82)]
        public uint SetItemsInTotal { get; set; }

        [ProtoMember(83)]
        public bool IsExtraRainbowRiot { get; set; }

        [ProtoMember(84)]
        public bool FirstReviveUsed { get; set; }

        [ProtoMember(85)]
        public List<string> CharityPopupsDisplayed { get; set; }

        [ProtoMember(86)]
        public WorldEventBossData WorldBoss { get; set; }

        [ProtoMember(87)]
        public Dictionary<string, List<uint>> WorldBossPlayersAttacksTimestamps { get; set; }

        [ProtoMember(88)]
        public int UnprocessedBossDefeats { get; set; }

        [ProtoMember(90)]
        public int UnprocessedBossVictories { get; set; }

        [ProtoMember(91)]
        public bool UnprocessedBossKillingBlow { get; set; }

        [ProtoMember(92)]
        public uint BossWonTime { get; set; }

        [ProtoMember(93)]
        public uint BossStartTime { get; set; }

        [ProtoMember(94)]
        public float RandomDecisionSeed { get; set; }

        [ProtoMember(95)]
        public bool OverrideProfileMerger { get; set; }

        [ProtoMember(96)]
        public int HighestPowerLevelEver { get; set; }

        [ProtoMember(97)]
        public uint TimeStampOfLastVideoGacha { get; set; }

        [ProtoMember(98)]
        public uint TimeStampOfLastVideoPvPGacha { get; set; }

        [ProtoMember(99)]
        public List<string> ShownShopPopups { get; set; }

        [ProtoMember(100)]
        public string CurrentPvPBuff { get; set; }

        [ProtoMember(101)]
        public Dictionary<string, DateTime> CurrentCooldownOffers { get; set; }

        [ProtoMember(102)]
        public bool BonusShardsGainedToday { get; set; }

        [ProtoMember(103)]
        public Dictionary<string, string> EquippedSkins { get; set; }

        [ProtoMember(104)]
        public string LastRatingSuccessVersion { get; set; }

        [ProtoMember(105)]
        public uint LastRatingFailTimestamp { get; set; }

        [ProtoMember(106)]
        public bool LostAnyPvpBattle { get; set; }

        [ProtoMember(107)]
        public List<string> LastwatchedNewsItems { get; set; }

        [ProtoMember(108)]
        public int ExperienceForNextLevel { get; set; }

        [ProtoMember(109)]
        public uint NotificationPopupShown { get; set; }

        [ProtoMember(110)]
        public int NotificationPopupsAmount { get; set; }

        [ProtoMember(111)]
        public bool IsNewCreatedAccount { get; set; }

        [ProtoMember(112)]
        public Dictionary<string, int> CollectiblesPerEvent { get; set; }

        [ProtoMember(113)]
        public uint TimeStampOfLastVideoObjectives { get; set; }

        [ProtoMember(114)]
        public bool ObjectiveVideoFreeRefreshUsed { get; set; }

        [ProtoMember(115)]
        public bool ConvertionFor153 { get; set; }

        [ProtoMember(116)]
        public string CachedChestRewardItem { get; set; }

        [ProtoMember(117)]
        public bool CinematricIntroStarted { get; set; }

        [ProtoMember(118)]
        public Dictionary<string, DateTime> SalesHistory { get; set; }

        [ProtoMember(119)]
        public Dictionary<int, string> CalendarChestLootWon { get; set; }

        [ProtoMember(120)]
        public bool FreeFusionused { get; set; }

        [ProtoMember(121)]
        public int DailyPvpObjectivesRerolled { get; set; }

        [ProtoMember(122)]
        public float TotalDollarsSpent { get; set; }

        [ProtoMember(123)]
        public Dictionary<string, int> UnresolvedHotspotsLost { get; set; }

        [ProtoMember(124)]
        public uint TimeStampOfLastPurchase { get; set; }

        [ProtoMember(125)]
        public List<string> SaleQueue { get; set; }

        [ProtoMember(126)]
        public uint TimeStampOfLastStickyPurchase { get; set; }

        [ProtoMember(127)]
        public Dictionary<string, List<string>> ChainPurchaseHistory { get; set; }

        [ProtoMember(128)]
        public KeyValuePair<string, uint> LastPrivateSale { get; set; }

        [ProtoMember(129)]
        public Dictionary<string, List<string>> CachedLootFromPurchase { get; set; }

        [ProtoMember(130)]
        public List<string> OffersEndedWithoutPurchase { get; set; }

        [ProtoMember(131)]
        public List<string> OffersPurchased { get; set; }

        [ProtoMember(132)]
        public List<string> OffersEnded { get; set; }

        [ProtoMember(133)]
        public Dictionary<string, int> TreshholdRewardsPerSeasonClaimed { get; set; }

        [ProtoMember(134)]
        public bool PlaysHardModeBoss { get; set; }

        [ProtoMember(135)]
        public bool PlaysHardModeDungeon { get; set; }

        [ProtoMember(136)]
        public uint TimeStampOfLastFreeGacha { get; set; }

        [ProtoMember(137)]
        public uint TimeStampOfLastFreePvPGacha { get; set; }

        [ProtoMember(138)]
        public string MissingClassForSkinPopup { get; set; }

        [ProtoMember(139)]
        public uint TimeStampOfLastCinemaVideo { get; set; }

        [ProtoMember(140)]
        public string RovioId { get; set; }

        [ProtoMember(141)]
        public uint TimeStampOfLastEventPointVideoBoost { get; set; }

        [ProtoMember(142)]
        public uint TimeStampOfLastArenaPointVideoBoost { get; set; }

        [ProtoMember(143)]
        public int m_CachedPvpTrophyId { get; set; }

        [ProtoMember(144)]
        public List<string> BoughtInfiniteOffers { get; set; }
    }

}
