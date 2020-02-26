namespace DNNDataTables.Modules.Services
{
    using DotNetNuke.Web.Api;

    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute(
            "DNNDataTables",
            "default",
            "{controller}/{action}",
            new string[] { "DNNDataTables.Modules.Services" });
        }
    }
}