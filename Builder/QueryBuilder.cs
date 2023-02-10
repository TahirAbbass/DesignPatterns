using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
    {
    class QueryBuilder
        {
        private Query _query;

        public QueryBuilder (string table)
            {
            this._query = new Query(table);
            }

        public QueryBuilder SetFilters (string filters)
            {
            this._query.SetFilters(filters);
            return this;
            }

        public QueryBuilder SetOrderBy (string orderby)
            {
            this._query.SetOrderBy(orderby);
            return this;
            }

        public Query Build ()
            {
            return _query;
            }

        }
    }
