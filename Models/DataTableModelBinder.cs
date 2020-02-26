namespace DNNDataTables.Modules.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public class DataTableModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            base.BindModel(controllerContext, bindingContext);

            var dataTableRequest = new DataTableRequest();
            var request = controllerContext.HttpContext.Request;

            // Retrieve request data
            dataTableRequest.draw = Convert.ToInt32(request["draw"]);
            dataTableRequest.start = Convert.ToInt32(request["start"]);
            dataTableRequest.length = Convert.ToInt32(request["length"]);

            // Search
            dataTableRequest.search = new DataTableRequest.Search
            {
                value = request["search[value]"],
                regex = Convert.ToBoolean(request["search[regex]"])
            };

            // Order
            var o = 0;
            dataTableRequest.order = new List<DataTableRequest.Order>();

            while (request["order[" + o + "][column]"] != null)
            {
                dataTableRequest.order.Add(new DataTableRequest.Order
                {
                    column = Convert.ToInt32(request["order[" + o + "][column]"]),
                    dir = request["order[" + o + "][dir]"]
                });
                o++;
            }
            // Columns
            var c = 0;
            dataTableRequest.columns = new List<DataTableRequest.Column>();

            while (request["columns[" + c + "][name]"] != null)
            {
                dataTableRequest.columns.Add(new DataTableRequest.Column
                {
                    data = request["columns[" + c + "][data]"],
                    name = request["columns[" + c + "][name]"],
                    orderable = Convert.ToBoolean(request["columns[" + c + "][orderable]"]),
                    searchable = Convert.ToBoolean(request["columns[" + c + "][searchable]"]),
                    search = new DataTableRequest.Search
                    {
                        value = request["columns[" + c + "][search][value]"],
                        regex = Convert.ToBoolean(request["columns[" + c + "][search][regex]"])
                    }
                });
                c++;
            }

            return dataTableRequest;
        }
    }
}