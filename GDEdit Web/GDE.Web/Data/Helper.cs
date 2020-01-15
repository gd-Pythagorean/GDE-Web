namespace GDE.Web.Data
{
    public static class Helper
    {
        public static int SectionToHueMap(LinkItems section) => section switch
        {
            LinkItems.Home => 255,
            LinkItems.Levels => 200,
            LinkItems.Community => 150,
            LinkItems.Help => 46,
            LinkItems.Error => 333,
            _ => 255
        };
    }
}