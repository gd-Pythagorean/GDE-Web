﻿namespace GDE.Web.Data
{
    public static class Helper
    {
        public static int SectionToHueMap(LinkItems section) => section switch
        {
            LinkItems.home => 255,
            LinkItems.levels => 200,
            LinkItems.community => 333,
            LinkItems.help => 46,
            LinkItems.rankings => 115,
            LinkItems.error => 333,
            _ => 255
        };
    }
}