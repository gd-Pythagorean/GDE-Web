using System.Collections.Generic;
using GDE.Web.Data;

namespace GDE.Web.Pages
{
    public static class Helper
    {
        public static int SectionToHueMap(GlobalVariables.LinkItems section)
            => section switch
            {
                GlobalVariables.LinkItems.Home => 255,
                GlobalVariables.LinkItems.Levels => 200,
                GlobalVariables.LinkItems.Community => 150,
                GlobalVariables.LinkItems.Help => 20,
                _ => 255
            };
    }
}