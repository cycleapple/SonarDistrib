using AG.EnumLocalization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarPlugin.Localization
{
    [EnumLocStrings("Plugin")]
    public enum PluginLoc
    {
        [EnumLoc(Fallback = "插件")]
        Plugin,

        [EnumLoc(Fallback = "語言")]
        Language,

        [EnumLoc(Fallback = "進階")]
        Advanced,

        [EnumLoc(Fallback = "預設備援文字")]
        Fallbacks,

        [EnumLoc(Fallback = "預設")]
        Presets,

        [EnumLoc(Fallback = "資源")]
        Resources,

        [EnumLoc(Fallback = "匯入")]
        Import,

        [EnumLoc(Fallback = "匯出")]
        Export,

        [EnumLoc(Fallback = "匯出預設備援文字")]
        ExportFallbacks,

        [EnumLoc(Fallback = "載入")]
        Load,

        [EnumLoc(Fallback = "儲存")]
        Save,

        [EnumLoc(Fallback = "重新載入語言")]
        RunSetup,
        
        [EnumLoc(Fallback = "除錯")]
        Debug,
    }
}
