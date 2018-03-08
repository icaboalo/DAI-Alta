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
        public Int16 cu, programa, semestre;
        public String nombre, correo, sexo;
       
        public Alumno()
        {

        }

        public Alumno(Int16 cu, String nombre, String correo, String sexo, Int16 semestre, Int16 programa) : this (cu, correo) {
            this.nombre = nombre;
            this.sexo = sexo;
            this.semestre = semestre;
            this.programa = programa;
        }

        public Alumno(Int16 cu, String correo): this (cu) {
            this.correo = correo;
        }

        public Alumno(String correo) {
            this.correo = correo;
        }

        public Alumno(Int16 cu) {
            this.cu = cu;
        }

        public int altaAlumno() {
            int res;
            SqlConnection con = Connection.addConnection();
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO alumno VALUES ({0}, '{1}', '{2}', '{3}', {4}, {5})", 
                                                          this.cu, this.nombre, 
                                                          this.sexo, this.correo, 
                                                          this.semestre, 
                                                          this.programa), con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
     
        public int borrarAlumno() {
            int res;
            SqlConnection con = Connection.addConnection();
            SqlCommand cmd = new SqlCommand(String.Format("DELETE FROM alumno WHERE cu = {0}", this.cu), con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }
        
        public int modificarAlumno() {
            SqlConnection con;
            con = Connection.addConnection();
            SqlCommand cmd = new SqlCommand(String.Format("UPDATE alumno SET correo = '{0}' WHERE claveUnica = '{1}';", 
                                                          this.correo, this.cu), con);
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public List<Alumno> buscarAlumno() {
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
