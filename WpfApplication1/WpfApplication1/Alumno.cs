using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Alumno
    {
        public Int16 cu;
        public String nombre, correo;
       
        public Alumno()
        {

        }
        public Alumno(Int16 cu, String correo)
        {
            this.correo = correo;
            this.cu = cu;
        }

        public Alumno(String correo)
        {
            this.correo = correo;
        }
     
        public static int borrarAlumno(Alumno alumno)
        {
            int res;
            SqlConnection con = Connection.addConnection();
            SqlCommand cmd = new SqlCommand(String.Format("Delete "));
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        
        public int modificarAlumno()
        {
            SqlConnection con;
            con = Connection.addConnection();
            SqlCommand cmd = new SqlCommand(String.Format("UPDATE alumno SET correo = '{0}' WHERE claveUnica = '{1}';", this.correo, this.cu), con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public List<Alumno> buscarAlumno()
        {
            List<Alumno> list = new List<Alumno>();
            SqlConnection con = Connection.addConnection();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT * FROM alumno WHERE nombre like '%{0}%';", this.nombre), con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Alumno(Int16.Parse(reader["cu"].ToString()), reader["correo"].ToString()));
            }
            return list;
        }
    }
}
