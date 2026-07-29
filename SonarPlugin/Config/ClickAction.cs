using AG.EnumLocalization.Attributes;
using SonarPlugin.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarPlugin.Config
{
    [EnumLocStrings]
    public enum ClickAction
    {
        [EnumLoc(Fallback = "預設")]
        Default,

        [EnumLoc(Fallback = "無")]
        None,

        [EnumLoc(Fallback = "傳送至聊天")]
        Chat,

        [EnumLoc(Fallback = "建立旗標")]
        Map,

        [EnumLoc(Fallback = "傳送")]
        Teleport,

        [EnumLoc(Fallback = "移除")]
        Remove,
    }
}
