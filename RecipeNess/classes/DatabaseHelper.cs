using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
namespace RecipeNess.classes
{
    public static class DatabaseHelper
    {
        public static string ConnectionString = "server=localhost;port=3306;database=recipe_app;user=root;password=12345;";
    }
}
