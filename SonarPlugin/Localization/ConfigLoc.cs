using AG.EnumLocalization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarPlugin.Localization
{
    [EnumLocStrings("Config")]
    public enum ConfigLoc
    {
        [EnumLoc("Contribute.Global", Fallback = "全域分享通報")]
        GlobalContribute,

        [EnumLoc("Contribute.GlobalTooltip", Fallback = "停用後將不再分享狩獵與 FATE 通報。\n也可使用 /sonaron 與 /sonaroff 指令切換。")]
        GlobalContributeTooltip,

        [EnumLoc("Contribute.Hunts", Fallback = "分享狩獵通報")]
        ContributeHunts,

        [EnumLoc("Contribute.Fates", Fallback = "分享 FATE 通報")]
        ContributeFates,

        [EnumLoc("Contribute.Tooltip", Fallback = "必須分享通報才能接收其他 Sonar 使用者的通報。\n停用後 Sonar 仍會以本機模式運作，只顯示遊戲內自行偵測到的資訊。")]
        ContributeTooltip,

        [EnumLoc("Contribute.GlobalDisabled", Fallback = "全域分享已停用")]
        ContributeGlobalDisabled,

        [EnumLoc("TrackAll.Hunts", Fallback = "追蹤所有狩獵")]
        TrackAllHunts,

        [EnumLoc("TrackAll.Fates", Fallback = "追蹤所有 FATE")]
        TrackAllFates,

        [EnumLoc("TrackAll.Tooltip", Fallback = "勾選：忽略通報範圍設定，追蹤所有通報。\n未勾選：只追蹤設定範圍內的通報。")]
        TrackAllTooltip,

        [EnumLoc(Fallback = "接收範圍")]
        ReceiveJurisdiction,

    }
}
