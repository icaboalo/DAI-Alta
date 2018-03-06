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
            SqlCommand cmd = new SqlCommand(String.Format("UPDATE alumno SET correo = '{0}' WHERE claveUnica = '{1}';", this.correo, this.cu));
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }   
    }
}
