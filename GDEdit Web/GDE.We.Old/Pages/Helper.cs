using System.Collections.Generic;
using GDE.We.Old.Data;

namespace GDE.We.Old.Pages
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