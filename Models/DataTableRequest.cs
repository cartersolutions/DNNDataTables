﻿namespace DNNDataTables.Modules.Models
{
    using System.Collections.Generic;
    using System.Web.Http.ModelBinding;

    [ModelBinder(typeof(DataTableModelBinder))]
    public class DataTableRequest
    {
        public int draw { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public Search search { get; set; }
        public List<Order> order { get; set; }
        public List<Column> columns { get; set; }
        public List<Criteria> criteria { get; set; }

        public class Search
        {
            public string value { get; set; }
            public bool regex { get; set; }
        }

        public class Order
        {
            public string dir { get; set; }
            public int column { get; set; }
        }

        public class Column
        {
            public string data { get; set; }
            public string name { get; set; }
            public bool searchable { get; set; }
            public bool orderable { get; set; }
            public Search search { get; set; }
        }
    }
}