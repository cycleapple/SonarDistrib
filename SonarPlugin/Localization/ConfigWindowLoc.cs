using AG.EnumLocalization.Attributes;
using System.Text;

namespace SonarPlugin.Localization
{
    [EnumLocStrings("ConfigWindow")]
    public enum ConfigWindowLoc
    {
        [EnumLoc(Fallback = "Sonar 設定")]
        WindowTitle,

        [EnumLoc("Tab.General", "一般")]
        GeneralTab,

        [EnumLoc("Tab.Hunts", "狩獵")]
        HuntsTab,

        [EnumLoc("Tab.Fates", "FATE")]
        FatesTab,

        [EnumLoc("Tab.About", "關於")]
        AboutTab,

        [EnumLoc("Tab.Debug", "除錯")]
        DebugTab,

        #region General Tab

        [EnumLoc(Fallback = "預設顯示浮動視窗")]
        OverlaysVisibleByDefault,

        [EnumLoc(Fallback = "鎖定浮動視窗")]
        LockOverlays,

        [EnumLoc(Fallback = "隱藏標題列")]
        HideTitleBar,

        [EnumLoc("Clickthrough.Window", Fallback = "啟用視窗點擊穿透")]
        EnableClickthrough,

        [EnumLoc("Clickthrough.Tabs", Fallback = "啟用頁籤列點擊穿透")]
        TabsClickthrough,

        [EnumLoc("Clickthrough.List", Fallback = "啟用清單點擊穿透")]
        ListClickthrough,

        [EnumLoc(Fallback = "排序方式")]
        SortingMode,

        [EnumLoc(Fallback = "透明度")]
        Opacity,

        [EnumLoc(Fallback = "提醒音量")]
        AlertVolume,

        [EnumLoc("Header.Duty", Fallback = "任務設定")]
        DutySettingsHeader,

        [EnumLoc("Header.Click", Fallback = "點擊操作設定")]
        ClickSettingsHeader,

        [EnumLoc("Header.Localization", Fallback = "語言設定")]
        LocalizationHeader,

        [EnumLoc("Header.Lodestone", Fallback = "Lodestone 驗證設定")]
        LodestoneHeader,

        [EnumLoc("Header.Color", Fallback = "Sonar 配色")]
        ColorSettingsHeader,

        // Duty Settings

        [EnumLoc("Duty.DisableChatAlerts", Fallback = "任務期間停用聊天提醒")]
        DutyDisableChatAlerts,

        [EnumLoc("Duty.DisableSoundAlerts", Fallback = "任務期間停用聲音提醒")]
        DutyDisableSoundAlerts,

        // Click Settings

        [EnumLoc("Click.Middle", Fallback = "中鍵")]
        MiddleClick,

        [EnumLoc("Click.Right", Fallback = "右鍵")]
        RightClick,

        [EnumLoc("Click.ShiftMiddle", Fallback = "Shift + 中鍵")]
        ShiftMiddleClick,

        [EnumLoc("Click.ShiftRight", Fallback = "Shift + 右鍵")]
        ShiftRightClick,

        [EnumLoc("Click.AltMiddle", Fallback = "Alt + 中鍵")]
        AltMiddleClick,

        [EnumLoc("Click.AltRight", Fallback = "Alt + 右鍵")]
        AltRightClick,

        [EnumLoc("Click.CtrlMiddle", Fallback = "Ctrl + 中鍵")]
        CtrlMiddleClick,

        [EnumLoc("Click.CtrlRight", Fallback = "Ctrl + 右鍵")]
        CtrlRightClick,

        [EnumLoc(Fallback = "偏好的城邦")]
        PreferredCityState,

        // Lodestone Settings
        [EnumLoc("Lodestone.SuppressVerification", Fallback = "隱藏驗證要求")]
        SuppressLodestoneVerifications,

        // Color Settings

        [EnumLoc("Color.Hunt.Healthy", Fallback = "狩獵－未開戰")]
        HealthyHuntColor,

        [EnumLoc("Color.Hunt.Pulled", Fallback = "狩獵－已開戰")]
        PulledHuntColor,

        [EnumLoc("Color.Hunt.Dead", Fallback = "狩獵－已討伐")]
        DeadHuntColor,

        [EnumLoc("Color.Fate.Running", Fallback = "FATE－進行中")]
        RunningFateColor,

        [EnumLoc("Color.Fate.Progress", Fallback = "FATE－有進度")]
        ProgressFateColor,

        [EnumLoc("Color.Fate.Complete", Fallback = "FATE－完成")]
        CompleteFateColor,

        [EnumLoc("Color.Fate.Failed", Fallback = "FATE－失敗")]
        FailedFateColor,

        [EnumLoc("Color.Fate.Prepararing", Fallback = "FATE－準備中")]
        PreparingFateColor,

        [EnumLoc("Color.Fate.Unknown", Fallback = "FATE－未知")]
        UnknownFateColor,

        [EnumLoc("Color.s_presets", Fallback = "配色預設")]
        ColorPresets,

        [EnumLoc("Color.Preset.Default", Fallback = "預設")]
        DefaultColorPreset,

        [EnumLoc("Color.Preset.Original", Fallback = "原始")]
        OriginalColorPreset,

        #endregion

        [EnumLoc(Fallback = "聊天通報設定")]
        ChatReportsConfig,

        [EnumLoc(Fallback = "在遊戲聊天顯示通報")]
        ChatReportsEnabled,

        [EnumLoc(Fallback = "使用斜體字")]
        ChatEnableItalics,

        [EnumLoc(Fallback = "通報來自其他世界時顯示跨界圖示")]
        ChatEnableCwIcon,

        [EnumLoc(Fallback = "顯示討伐通報")]
        ChatEnableDeaths,

        [EnumLoc(Fallback = "聲音提醒設定")]
        SoundAlertsConfig,

        #region Hunts Tab

        [EnumLoc("Hunts.SRankSounds", Fallback = "S 級音效")]
        HuntSRankSounds,

        [EnumLoc("Hunts.ARankSounds", Fallback = "A 級音效")]
        HuntARankSounds,

        [EnumLoc("Hunts.BRankSounds", Fallback = "B 級音效")]
        HuntBRankSounds,

        [EnumLoc(Fallback = "")]
        i,

        [EnumLoc(Fallback = "")]
        j,

        [EnumLoc(Fallback = "")]
        k,

        [EnumLoc(Fallback = "")]
        l,

        [EnumLoc(Fallback = "")]
        m,

        [EnumLoc(Fallback = "")]
        n,

        [EnumLoc(Fallback = "")]
        o,

        [EnumLoc(Fallback = "")]
        p,

        [EnumLoc(Fallback = "")]
        q,

        [EnumLoc(Fallback = "")]
        r,

        [EnumLoc(Fallback = "")]
        s,

        [EnumLoc(Fallback = "")]
        t,

        [EnumLoc(Fallback = "")]
        u,

        [EnumLoc(Fallback = "")]
        v,

        [EnumLoc(Fallback = "")]
        w,

        [EnumLoc(Fallback = "")]
        x,

        [EnumLoc(Fallback = "")]
        y,

        [EnumLoc(Fallback = "")]
        z,

        #endregion

        #region Fates Tab
        [EnumLoc("Fates.FateSounds", Fallback = "FATE 音效")]
        FateSounds,


        #endregion

        #region About Tab
        #endregion

        #region Debug Tab
        #endregion
    }
}
