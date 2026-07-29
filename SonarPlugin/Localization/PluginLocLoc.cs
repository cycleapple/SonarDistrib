using AG.EnumLocalization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarPlugin.Localization
{
    [EnumLocStrings("Localization")]
    public enum PluginLocLoc
    {
        [EnumLoc(Fallback = "匯入語言檔")]
        ImportPrompt,

        [EnumLoc(Fallback = "匯出語言檔")]
        ExportPrompt,

        [EnumLoc(Fallback = "顯示備援鍵值")]
        DebugFallbacks,

        [EnumLoc(Fallback = "使用除錯備援文字並顯示鍵值。")]
        DebugFallbacksTooltip,

        [EnumLoc(Fallback = "壓縮匯出格式")]
        MinifiedExport,

        [EnumLoc(Fallback = "在獨立執行緒重新載入語言。")]
        ThreadedTooltip,
    }
}
