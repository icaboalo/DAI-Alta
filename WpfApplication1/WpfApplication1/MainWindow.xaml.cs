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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            SqlConnection connection = Connection.addConnection();
            if (connection != null) {
                SqlCommand command = new SqlCommand(String.Format("SELECT contra FROM usuarios WHERE nombreUsuario = '{0}'", txUsuario.Text), connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    if (txPassword.Text == reader.GetString(0)) {
                        MessageBox.Show("Inicio de sesión completo!");
                        Window alta = new Alta();
                        alta.Show();
                        this.Close();                     
                    } else {
                        MessageBox.Show("Credenciales invalidas");
                    }
                }
            }
        }
    }
}
