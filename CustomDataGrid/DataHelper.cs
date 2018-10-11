using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace CustomDataGrid
{
    public class DataHelper
    {
        private readonly string connectionString;

        public DataHelper()
        {
            connectionString = @"server=db\sql2008;database=SHMEL_K03L;user id=logipos; password=1";
        }

        public ObservableCollection<Item> GetItems()
        {
            using ( var connection = new SqlConnection( connectionString ))
            {
                var result = connection.Query<Item>( "select * from item").AsList();


                //result.foreach (var item in collection)
                //{

                //}

                return new ObservableCollection<Item>(result.Cast<Item>());
            }
        }
    }
}
