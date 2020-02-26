namespace DNNDataTables.Modules.Extensions
{
    using global::DNNDataTables.Modules.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Dynamic.Core;

    public static class Extensions
    {
        #region DataTables

        /// <summary>
        /// Sort @source and return it
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static IQueryable<T> Sort<T>(IQueryable<T> source, DataTableRequest request)
        {
            // This will be the sort column until architected to handle multicolumn sorting
            int SORT_COLUMN_INDEX = 0;

            // Find sort column and sort order
            var order = request.order.ElementAt(SORT_COLUMN_INDEX);
            var columnName = request.columns.ElementAt(order.column).name;

            return source.OrderBy(columnName + (order.dir == "asc" ? " ascending" : " descending"));
        }

        public static DataTableResponse ToDataTableResponse<T>(this IQueryable<T> query, DataTableRequest request)
        {
            DataTableResponse response = new DataTableResponse();
            List<T> data = new List<T>();

            response.draw = request.draw;

            // Find the correct amount of records to display
            if (request.length <= 0)
            {
                data = query.ToList();
            }
            else
            {
                // Sort the table
                query = Sort(query, request);

                data = query.Skip(request.start).Take(request.length).ToList();
            }

            response.data = data.Cast<object>();

            response.recordsFiltered = query.Count();
            response.recordsTotal = query.Count();

            return response;
        }

        #endregion
    }
}