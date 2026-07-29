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

        [EnumLoc(Fallback = "Chat Sounds <se.1>")]
        Sound37,

        [EnumLoc(Fallback = "Chat Sounds <se.2>")]
        Sound38,

        [EnumLoc(Fallback = "Chat Sounds <se.3>")]
        Sound39,

        [EnumLoc(Fallback = "Chat Sounds <se.4>")]
        Sound40,

        [EnumLoc(Fallback = "Chat Sounds <se.5>")]
        Sound41,

        [EnumLoc(Fallback = "Chat Sounds <se.6>")]
        Sound42,

        [EnumLoc(Fallback = "Chat Sounds <se.7>")]
        Sound43,

        [EnumLoc(Fallback = "Chat Sounds <se.8>")]
        Sound44,

        [EnumLoc(Fallback = "Chat Sounds <se.9>")]
        Sound45,

        [EnumLoc(Fallback = "Chat Sounds <se.10>")]
        Sound46,

        [EnumLoc(Fallback = "Chat Sounds <se.11>")]
        Sound47,

        [EnumLoc(Fallback = "Chat Sounds <se.12>")]
        Sound48,

        [EnumLoc(Fallback = "Chat Sounds <se.13>")]
        Sound49,

        [EnumLoc(Fallback = "Chat Sounds <se.14>")]
        Sound50,

        [EnumLoc(Fallback = "Chat Sounds <se.15>")]
        Sound51,

        [EnumLoc(Fallback = "Chat Sounds <se.16>")]
        Sound52,
        #endregion

        #region Resource Sound Fallbacks
        [EnumLoc("Resources.EnterChat", Fallback = "Enter Chat")]
        ResEnterChat,

        [EnumLoc("Resources.Fanfare", Fallback = "Fanfare")]
        ResFanfare,

        [EnumLoc("Resources.FeatureUnlocked", Fallback = "Feature Unlocked")]
        ResFeatureUnlocked,

        [EnumLoc("Resources.IncomingTell1", Fallback = "Incoming Tell 1")]
        ResIncomingTell1,

        [EnumLoc("Resources.IncomingTell2", Fallback = "Incoming Tell 2")]
        ResIncomingTell2,

        [EnumLoc("Resources.LimitBreakCharged", Fallback = "Limit Break Charged")]
        ResLimitBreakCharged,

        [EnumLoc("Resources.LimitBreakUnlocked", Fallback = "Limit Break Unlocked")]
        ResLimitBreakUnlocked,

        [EnumLoc("Resources.LinkshellTransmission", Fallback = "Linkshell Transmission")]
        ResLinkshellTransmission,

        [EnumLoc("Resources.Notification", Fallback = "Notification")]
        ResNotification,
        #endregion
    }
}
