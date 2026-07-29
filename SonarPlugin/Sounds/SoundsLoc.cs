using AG.EnumLocalization.Attributes;
using System.ComponentModel;

namespace SonarPlugin.Sounds
{
    [EnumLocStrings("Sounds")]
    public enum SoundsLoc : uint
    {
        [EnumLoc("Config.PlaySounds", Fallback = "播放音效")]
        PlaySound,

        [EnumLoc("Config.Sounds", Fallback = "音效")]
        Sounds,

        [EnumLoc("Config.GameSound", Fallback = "遊戲音效")]
        GameSound,

        [EnumLoc("Config.Resource", Fallback = "內建音效")]
        Resource,

        [EnumLoc("Config.Custom", Fallback = "自訂")]
        Custom,

        [EnumLoc("Config.Unknown", Fallback = "未知")]
        Unknown,

        [EnumLoc("Config.GameSoundTooltip", Fallback = "使用 FFXIV 音效引擎播放遊戲內建音效。\n音量取決於 FFXIV 的系統音效設定。")]
        GameSoundTooltip,

        [EnumLoc("Config.ResourceTooltip", Fallback = "使用 Sonar 音效引擎播放內建音效。\n音量取決於 Sonar 的提醒音量。")]
        ResourceTooltip,

        [EnumLoc("Config.CustomTooltip", Fallback = "使用 Sonar 音效引擎播放自訂音效。\n音量取決於 Sonar 的提醒音量。")]
        CustomTooltip,

        [EnumLoc("Config.UnknownTooltip", Fallback = "若出現此選項，請聯絡 Sonar Support")]
        UnknownTooltip,

        [EnumLoc("Config.SelectFile", Fallback = "選擇檔案……")]
        SelectFile,

        [EnumLoc("Config.SelectFilePrompt", Fallback = "自訂音效檔")]
        SelectFilePrompt,

        [EnumLoc("Config.SelectFilePromptFilter.SoundFiles", Fallback = "音效檔")]
        SelectFilePromptSoundFiles,

        #region Sound Effect Fallbacks
        // NOTE: SoundXY implicictly exists
        // This is used to define fallbacks
        // More information at SoundEngine.GetSoundName

        [EnumLoc(Fallback = "音效 <id>")] // Generic fallback for non-existent SoundXY entries
        SoundGeneric,

        [EnumLoc(Fallback = "聊天音效 <se.1>")]
        Sound37,

        [EnumLoc(Fallback = "聊天音效 <se.2>")]
        Sound38,

        [EnumLoc(Fallback = "聊天音效 <se.3>")]
        Sound39,

        [EnumLoc(Fallback = "聊天音效 <se.4>")]
        Sound40,

        [EnumLoc(Fallback = "聊天音效 <se.5>")]
        Sound41,

        [EnumLoc(Fallback = "聊天音效 <se.6>")]
        Sound42,

        [EnumLoc(Fallback = "聊天音效 <se.7>")]
        Sound43,

        [EnumLoc(Fallback = "聊天音效 <se.8>")]
        Sound44,

        [EnumLoc(Fallback = "聊天音效 <se.9>")]
        Sound45,

        [EnumLoc(Fallback = "聊天音效 <se.10>")]
        Sound46,

        [EnumLoc(Fallback = "聊天音效 <se.11>")]
        Sound47,

        [EnumLoc(Fallback = "聊天音效 <se.12>")]
        Sound48,

        [EnumLoc(Fallback = "聊天音效 <se.13>")]
        Sound49,

        [EnumLoc(Fallback = "聊天音效 <se.14>")]
        Sound50,

        [EnumLoc(Fallback = "聊天音效 <se.15>")]
        Sound51,

        [EnumLoc(Fallback = "聊天音效 <se.16>")]
        Sound52,
        #endregion

        #region Resource Sound Fallbacks
        [EnumLoc("Resources.EnterChat", Fallback = "開啟聊天輸入")]
        ResEnterChat,

        [EnumLoc("Resources.Fanfare", Fallback = "獲得成就")]
        ResFanfare,

        [EnumLoc("Resources.FeatureUnlocked", Fallback = "功能開放")]
        ResFeatureUnlocked,

        [EnumLoc("Resources.IncomingTell1", Fallback = "收到悄悄話 1")]
        ResIncomingTell1,

        [EnumLoc("Resources.IncomingTell2", Fallback = "收到悄悄話 2")]
        ResIncomingTell2,

        [EnumLoc("Resources.LimitBreakCharged", Fallback = "極限技充能")]
        ResLimitBreakCharged,

        [EnumLoc("Resources.LimitBreakUnlocked", Fallback = "極限技可用")]
        ResLimitBreakUnlocked,

        [EnumLoc("Resources.LinkshellTransmission", Fallback = "通訊貝通知")]
        ResLinkshellTransmission,

        [EnumLoc("Resources.Notification", Fallback = "通知")]
        ResNotification,
        #endregion
    }
}
