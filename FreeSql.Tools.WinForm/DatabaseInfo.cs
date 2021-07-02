using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FreeSqlTools
{
    [Serializable]
    public class DatabaseInfo
    {
        private string _path = Path.Combine(Environment.CurrentDirectory, "database.bin");

        public List<DatabaseInfo> Databases { get; } = new List<DatabaseInfo>();
        public string Name { get; set; }
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string Pwd { get; set; }
        public string Host { get; set; }
        public bool IsString { get; set; } = false;
        public string ConnectionString { get; set; }
        public FreeSql.DataType DataType { get; set; } = FreeSql.DataType.MySql;
        public int ValidatorType { get; set; } = 0;
        public string Port { get; set; }
        public string DbName { get; set; }

        public DatabaseInfo()
        {
            Databases = Load();
        }

        public List<DatabaseInfo> Load()
        {
            if (!File.Exists(_path))
            {
                return new List<DatabaseInfo>();
            }

            using (Stream destream = new FileStream(_path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                try
                {
                    IFormatter formatter = new BinaryFormatter();
                    var entity = (DatabaseInfo)formatter.Deserialize(destream);
                    return entity.Databases;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return new List<DatabaseInfo>();
                }
            }
        }

        public void Add()
        {
            Databases.Add(this);
            this.Save();
        }

        public void Delete(Guid id)
        {
            var model = Databases.Where(a => a.Id == id).FirstOrDefault();
            if (model != null)
            {
                Databases.Remove(model);
                this.Save();
            }
        }

        public void Update()
        {
            var model = Databases.Where(a => a.Id == this.Id).FirstOrDefault();
            if (model != null)
            {
                this.Id = model.Id;
                this.UserId = model.UserId;
                this.Pwd = model.Pwd;
                this.Host = model.Host;
                this.Port = model.Port;
                this.DbName = model.DbName;
                this.Save();
            }
        }

        private void Save()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                File.WriteAllBytes(_path, ms.GetBuffer());
            }
        }
    }
}