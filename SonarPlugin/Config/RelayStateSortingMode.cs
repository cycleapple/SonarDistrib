using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sonar.Models;
using SonarPlugin.Attributes;
using Sonar.Utilities;
using Sonar.Trackers;
using Sonar.Data.Extensions;
using AG.EnumLocalization.Attributes;

namespace SonarPlugin.Config
{
    [EnumLocStrings("RelaySortingMode")]
    public enum RelayStateSortingMode
    {
        [EnumLoc(Fallback = "預設")]
        Default,

        [EnumLoc(Fallback = "最近發現")]
        LastFound,

        [EnumLoc(Fallback = "最近更新")]
        LastUpdated,

        [EnumLoc(Fallback = "名稱")]
        Alphabetical,

        [EnumLoc(Fallback = "資料中心 ID")]
        Datacenter,

        [EnumLoc(Fallback = "世界 ID")]
        World,

        [EnumLoc(Fallback = "區域 ID")]
        Zone,

        [EnumLoc(Fallback = "世界、區域、分流、通報 ID")]
        WorldZoneInstanceRelay,

        [EnumLoc(Fallback = "區域、分流、通報 ID")]
        ZoneInstanceRelay,

        [EnumLoc(Fallback = "通報範圍")]
        Jurisdiction,

        [EnumLoc(Fallback = "通報範圍、世界、區域、分流、通報 ID")]
        JurisdictionWorldZoneInstanceRelay,
    }

    public static class RelayStateSortingModeExtensions
    {
        public static IOrderedEnumerable<RelayState> SortBy(this IEnumerable<RelayState> states, RelayStateSortingMode mode, GamePlace place)
        {
            return mode switch
            {
                RelayStateSortingMode.LastFound => states.OrderByDescending(s => s.LastFound),
                RelayStateSortingMode.LastUpdated => states.OrderByDescending(s => s.LastUpdated),
                RelayStateSortingMode.Alphabetical => states.OrderBy(s => s.SortKey),
                RelayStateSortingMode.Datacenter => states.OrderBy(s => s.GetWorld()?.AudienceId ?? 0),
                RelayStateSortingMode.World => states.OrderBy(s => s.WorldId),
                RelayStateSortingMode.Zone => states.OrderBy(s => s.ZoneId),
                RelayStateSortingMode.WorldZoneInstanceRelay => states.OrderBy(s => s.WorldId).ThenBy(s => s.ZoneId).ThenBy(s => s.InstanceId).ThenBy(s => s.Relay.Id),
                RelayStateSortingMode.ZoneInstanceRelay => states.OrderBy(s => s.ZoneId).ThenBy(s => s.InstanceId).ThenBy(s => s.Relay.Id),
                RelayStateSortingMode.Jurisdiction => states.OrderBy(s => place.GetJurisdictionWith(s.Relay)),
                RelayStateSortingMode.JurisdictionWorldZoneInstanceRelay => states.OrderBy(s => place.GetJurisdictionWith(s.Relay)).ThenBy(s => s.WorldId).ThenBy(s => s.ZoneId).ThenBy(s => s.InstanceId).ThenBy(s => s.Relay.Id),
                _ => states.SortBy(RelayStateSortingMode.LastFound, place),
            };
        }
    }
}
