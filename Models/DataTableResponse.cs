using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace DNNDataTables.Modules.Models
{
    public class DataTableResponse
    {
        public DataTableResponse()
        {
            options = new ExpandoObject();
            files = new ExpandoObject();
        }

        public int draw { get; set; }

        /// <summary>
        /// Total number of records in non paged dataset
        /// </summary>
        public int recordsTotal { get; set; }

        /// <summary>
        /// Total number of records to display
        /// </summary>
        public int recordsFiltered { get; set; }

        public string error { get; set; }

        /// <summary>
        /// Response data
        /// </summary>
        public IEnumerable<object> data { get; set; }

        public dynamic options { get; set; }

        public dynamic files { get; set; }
    }
}