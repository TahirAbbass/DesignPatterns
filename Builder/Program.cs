using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
    {
    class Program
        {
        static void Main (string[] args)
            {
            string tableName = "employee";
            string filter = "EmpId = 10";
            string ordby = "EmpId ASC";

            //not readable
            Query query = new Query("employee");
            query.SetFilters("EmpId=10");
            query.SetOrderBy("EmpId ASC");


            Query query1 = new QueryBuilder(tableName).SetFilters(filter).SetOrderBy(ordby).Build();

            Console.WriteLine(query1.ConvToString());
            }
        }
    }
