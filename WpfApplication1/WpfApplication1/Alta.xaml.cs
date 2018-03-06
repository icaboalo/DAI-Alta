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

namespace WpfApplication1 {
    /// <summary>
    /// Lógica de interacción para Alta.xaml
    /// </summary>
    public partial class Alta : Window {
        public Alta() {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void btModificar_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Modificar w = new Modificar(this);
            w.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Buscar(this).Show();
            this.Hide();
        }

        private void btEliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btAgregar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
