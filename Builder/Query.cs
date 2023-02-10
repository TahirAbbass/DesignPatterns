using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
    {
    class Query
        {
        private string _table;
        private string _filters;
        private string _orderby;

        public Query (string table)
            {
            this._table = table;
            }

        public void SetFilters (string filters)
            {
            this._filters = "WHERE " + filters;
            }

        public void SetOrderBy (string orderby)
            {
            this._orderby = "ORDERBY " + orderby;
            }

        public string ConvToString ()
            {
            return "SELECT * from " + this._table + " " + _filters + " " + _orderby;
            }
        }
    }
