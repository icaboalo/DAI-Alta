using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication1
{
    class Connection
    {
        public static SqlConnection addConnection() {
            try {
                SqlConnection connection = new SqlConnection("Data Source=CC102-28;Initial Catalog=registro2;Persist Security Info=True;User ID=sa;Password=sqladmin");
                connection.Open();
                return connection;
            } catch (Exception e) {
                MessageBox.Show("No se pudo conectar a la base de datos.");
                return null;
            }
        }
    }
}
