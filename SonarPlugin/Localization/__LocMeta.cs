using AG.EnumLocalization.Attributes;
using System.ComponentModel;

namespace SonarPlugin.Localization
{
    [EnumLocStrings("__Meta")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public enum __LocMeta
    {
        [EnumLoc(Fallback = "Sonar Team")]
        Author,

        [EnumLoc(Fallback = "台灣繁體中文")]
        Language,

        [EnumLoc(Fallback = "台灣繁中介面")]
        Notes,
    }
}
