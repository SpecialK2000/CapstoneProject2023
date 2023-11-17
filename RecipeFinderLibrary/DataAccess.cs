using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace RecipeFinderGUI
{
    public class DataAccess
    {
        private static string connectionString = "Data Source=../../../RecipeFinder.db;Version=3;";
        //This was from when connection was SQLite based, do I delete this? 


        public static string ExecuteScalarQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    // Check if result is not null before converting to string
                    if (result != null)
                    {
                        return result.ToString();
                    }

                    // Handle the case when there are no usernames in the table
                    return null;
                }
            }
        }

        public static T ExecuteQuery<T>(string query) where T : new()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            T result = new T();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string propertyName = reader.GetName(i);
                                PropertyInfo property = typeof(T).GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

                                if (property != null && !reader.IsDBNull(i))
                                {
                                    object value = Convert.ChangeType(reader.GetValue(i), property.PropertyType);
                                    property.SetValue(result, value);
                                }
                            }

                            return result;
                        }
                    }
                }
            }

            return default(T);
        }

        public List<T> ExecuteQueryList<T>(string query) where T : new()
        {
            List<T> resultList = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T result = new T();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string propertyName = reader.GetName(i);
                                PropertyInfo property = typeof(T).GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

                                if (property != null && !reader.IsDBNull(i))
                                {
                                    object value = Convert.ChangeType(reader.GetValue(i), property.PropertyType);
                                    property.SetValue(result, value);
                                }
                            }

                            resultList.Add(result);
                        }
                    }
                }
            }

            return resultList;
        }
    }
}

