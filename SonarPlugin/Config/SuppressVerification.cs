using AG.EnumLocalization.Attributes;
using SonarPlugin.Attributes;
using System.Text;

namespace SonarPlugin.Config
{
    [EnumLocStrings]
    public enum SuppressVerification
    {
        [EnumLoc(Fallback = "永不")]
        None,

        [EnumLoc(Fallback = "除非必要")]
        UnlessRequired,

        [EnumLoc(Fallback = "永遠")]
        Always
    }
}
