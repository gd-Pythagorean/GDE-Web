using System;
using System.Collections.Generic;

namespace GDE.Web.Data
{
    public static class GlobalVariables
    {
        private static LinkItems currentSection = LinkItems.Home;
        
        public static LinkItems CurrentSection
        {
            get => currentSection;
            set
            {
                if (Links.ContainsKey(value))
                    currentSection = value;
                else
                    throw new Exception($"{value} is not inside the Links Dictionary");
            }
        }

        public static Dictionary<LinkItems, string[]> Links = new Dictionary<LinkItems, string[]>
        {
            { 
                LinkItems.Home, new []
                {
                    "",
                    "News",
                    "Team",
                    "Changelog",
                    "Download",
                    "Search"
                }
            },
            {
                LinkItems.Levels, new []
                {
                    "gdapi",
                    "Listing"
                }
            },
            {
                LinkItems.Community, new []
                {
                    "fetchdata",
                    "Forums",
                    "Contests"
                }
            },
            {
                LinkItems.Help, new []
                {
                    "counter",
                    "Wiki",
                    "FAQ",
                    "Rules",
                    "No, Really, I need help!"
                }
            }
        };
        
        public enum LinkItems
        {
            Home,
            Levels,
            Community,
            Help
        }
    }
}