using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace School.Library.Work
{
    public static class DataAccess
    {
        public static bool Write<T>(List<T> records)
        {
            string dataPath = @"C:\WebFiles\" + typeof(T).Name + "s.Json";
            try
            {
                using (StreamWriter writer = new StreamWriter(dataPath, false))
                {
                    writer.Write(JsonConvert.SerializeObject(records));
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public static List<T> Read<T>()
        {

            string dataPath = @"C:\WebFiles\" + typeof(T).Name + "s.Json";
            List<T> result =  new List<T>();
            string jsonObj = "";
            try
            {
                using (StreamReader reader = new StreamReader(dataPath))
                {
                    jsonObj = reader.ReadToEnd();
                }
                result = JsonConvert.DeserializeObject<List<T>>(jsonObj);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
