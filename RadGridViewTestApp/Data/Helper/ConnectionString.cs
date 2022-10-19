using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadGridViewTestApp.Data.Helper
{

    public abstract class ConnectionString
    {
        protected readonly string connectionString = "";
        public ConnectionString()
        {
            string filePath = Directory.GetCurrentDirectory().Replace(@"\bin\Debug\net6.0-windows", String.Empty);
            connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={filePath}\\Data\\Database\\RadGridViewDB.mdf;Integrated Security=True";
        }
    }
}
