using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Lógica de interacción para modificar.xaml
    /// </summary>
    public partial class Modificar : Window
    {
        Window parent;
        public Modificar(Window parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void tbModificar_Click(object sender, RoutedEventArgs e)
        {
            Alumno alumno = new Alumno(Int16.Parse(tbFolio.Text), tbCorreo.Text);
            int res = alumno.modificarAlumno();
            if (res > 0)
            {
                MessageBox.Show("Correo modificado");
            } else
            {
                MessageBox.Show("El correo no pudo ser modificado");
            }
        }

        private void tbRegresar_Click(object sender, RoutedEventArgs e)
        {
            parent.Show();
            this.Close();
        }
    }
}
