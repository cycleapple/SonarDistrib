using AG.EnumLocalization.Attributes;
namespace SonarPlugin.Localization
{
    [EnumLocStrings("MainWindow")]
    public enum MainWindowLoc
    {
        [EnumLoc(Fallback = "Sonar")]
        WindowTitle,

        [EnumLoc("Tabs.All", "全部")]
        AllTab,

        [EnumLoc("Detail.Location", "位置")]
        LocationDetail,

        [EnumLoc("Detail.FlagButtonTooltip", "在聊天視窗顯示座標")]
        DetailFlagToolTip,

        [EnumLoc("Detail.MapButtonTooltip", "設定旗標並開啟地圖")]
        DetailMapToolTip,

        [EnumLoc("Detail.TeleportButtonTooltip", "傳送至最近的以太之光")]
        DetailTeleportToolTip,

        [EnumLoc("Detail.RemoveButtonTooltip", "從清單移除，直到下次更新")]
        DetailRemoveToolTip,
    }
}
