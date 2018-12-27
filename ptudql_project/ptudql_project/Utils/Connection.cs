using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ptudql_project.Utils
{
    class Connection
    {
        public string Name { get; set; }
        public string ConnectionString { get; set; }

        private static string _path = $"data\\ConnectionString.json";

        public static List<Connection> lstConnection { get; set; }

        private static int _currentIdx;

        public static string CurrentConnectionString
        {
            get
            {
                if (lstConnection == null)
                {
                    LoadConnection();
                }

                if (lstConnection == null)
                {
                    MessageBox.Show("Bạn chưa có Connection String nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return lstConnection[CurrentIdx].ConnectionString;
            }
        }

        public static int CurrentIdx
        {
            get { return _currentIdx; }
            set
            {
                _currentIdx = value;
                SaveConnection();
            }
        }

        public static void AddConnection(Connection con)
        {
            if (lstConnection == null)
            {
                lstConnection = new List<Connection>();
            }

            lstConnection.Add(con);
            SaveConnection();
        }

        public static void DeleteConnection(int idx)
        {
            if (lstConnection == null)
            {
                return;
            }

            lstConnection.RemoveAt(idx);
            SaveConnection();
        }

        public static void SaveConnection()
        {
            var data = new Dictionary<string, string>();

            data["current_idx"] = CurrentIdx.ToString();

            if (!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
            }

            foreach(var item in lstConnection)
            {
                data[item.Name] = item.ConnectionString;
            }

            using (var file = File.CreateText(_path))
            {
                var serializer = new JavaScriptSerializer();
                var result = serializer.Serialize(data);
                file.Write(result);
            }
        }

        public static List<Connection> LoadConnection()
        {
            var json = LoadJson();

            if (json == null)
            {
                return null;
            }

            int.TryParse(json["current_idx"], out _currentIdx);
            lstConnection = new List<Connection>();

            foreach (var item in json)
            {
                if (item.Key != "current_idx")
                {
                    lstConnection.Add(new Connection() { Name = item.Key, ConnectionString = item.Value });
                }
            }

            return lstConnection;
        }

        public static Dictionary<string, string> LoadJson()
        {
            if (!File.Exists(_path))
            {
                return null;
            }

            var jsonStr = File.ReadAllText(_path);
            var serializer = new JavaScriptSerializer();
            var json = serializer.Deserialize<Dictionary<string, string>>(jsonStr);

            return json;
        }

        
    }
}
