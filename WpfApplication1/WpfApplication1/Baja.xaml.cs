using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Baja : Window {
        Window parent;
        public Baja(Window parent) {
            InitializeComponent();
            this.parent = parent;
        }

        private void btBaja_Click(object sender, RoutedEventArgs e) {
            int res = new Alumno(Int16.Parse(tbFolio.Text)).borrarAlumno();
            if (res > 0) {
                MessageBox.Show("Alumno eliminado.");
            } else {
                MessageBox.Show("Ocurrió un error al eliminar el alumno.");
            }
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e) {
            this.Close();
            parent.Show();
        }
    }
}
