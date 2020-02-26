namespace DNNDataTables.Modules.Services
{
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Web.Http;

    using DotNetNuke.Services.Exceptions;
    using DotNetNuke.Web.Api;

    using global::DNNDataTables.Modules.Data;
    using global::DNNDataTables.Modules.Extensions;
    using global::DNNDataTables.Modules.Models;

    public class CitiesController:DnnApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage HelloWorld()
        {
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, new { Title = "Hello World!" });
        }

        [AllowAnonymous]
        [HttpGet]
        public HttpResponseMessage List()
        {
            try
            {
                var dnnDataTablesEntities = new DNNDataTablesEntities();
                var cityWeatherQuery = from c in dnnDataTablesEntities.DNNDataTables_CityWeather select c;
                return Request.CreateResponse(System.Net.HttpStatusCode.OK, cityWeatherQuery.Take(100).ToList(), "application/json");
            }
            catch (Exception exc)
            {
                Exceptions.LogException(exc);
                return Request.CreateErrorResponse(System.Net.HttpStatusCode.InternalServerError, exc);
            }
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public HttpResponseMessage Paged([FromBody] DataTableRequest request)
        {
            var cityWeatherResponse = new DataTableResponse();

            try
            {
                var dnnDataTablesEntities = new DNNDataTablesEntities();

                var cityWeatherQuery = from c in dnnDataTablesEntities.DNNDataTables_CityWeather select c;
                cityWeatherResponse = cityWeatherQuery.ToDataTableResponse(request);
            }
            catch (Exception exc)
            {
                Exceptions.LogException(exc);
            }

            var response = Request.CreateResponse(System.Net.HttpStatusCode.OK, cityWeatherResponse);
            response.Headers.Add("Access-Control-Allow-Origin", "*");

            return response;
        }

    }
}