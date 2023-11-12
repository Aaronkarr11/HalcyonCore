using DapperExtensions;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HalcyonCore.Datalayer
{
    public static class DataLayerExtensions
    {
        public static void CreateCommand(this string connectionString, string queryString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandTimeout = 15;
                command.CommandType = CommandType.Text;
                command.CommandText = queryString;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}, {1}",
                        reader[0], reader[1]));
                }
            }
        }

        public static int DataInsert<T>(this string ConnectionString, T Data) where T : class
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                return conn.Insert(Data);
            }
        }

        public static bool DataUpdate<T>(this string ConnectionString, T Data) where T : class
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                return conn.Update(Data);
            }
        }

        public static List<Dictionary<int, string>> DeleteItemFromDictionary(this List<Dictionary<int, string>> objectToDelete, int keyId)
        {
            foreach (var item in objectToDelete.Where(k => k.Keys.FirstOrDefault() == keyId).ToList())
            {
                objectToDelete.Remove(item);
            }
            return objectToDelete;
        }

        public static List<Dictionary<int, string>> DeleteItemFromCollection(this List<Dictionary<int, string>> objectToDelete, int keyId)
        {
            foreach (var item in objectToDelete.Where(k => k.Keys.FirstOrDefault() == keyId).ToList())
            {
                objectToDelete.Remove(item);
            }
            return objectToDelete;
        }

        public static List<Dictionary<int, string>> DeleteAllItemsFromDictionary(this List<Dictionary<int, string>> objectToDelete)
        {

            foreach (var item in objectToDelete.ToList())
            {
                objectToDelete.Remove(item);
            }
            return objectToDelete;
        }

        public static void WriteToJsonFile<T>(this string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = Newtonsoft.Json.JsonConvert.SerializeObject(objectToWrite);
                writer = new StreamWriter(filePath, append);
                writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public static List<T> ReadFromJsonFile<T>(this string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                using (reader = new StreamReader(filePath))
                {
                    var fileContents = reader.ReadToEnd();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(fileContents);
                }
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        public static List<T> String2JSON<T>(this string fileContents) where T : new()
        {
            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(fileContents);
            }
            catch (Exception ex)
            {
                throw ex;
            }                
        }
    }
}
