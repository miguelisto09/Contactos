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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Contactos
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void CerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar la ventana?",
                                                     "Confirmación",
                                                     MessageBoxButton.YesNo,
                                                     MessageBoxImage.Question);

            if (resultado == MessageBoxResult.Yes)
            {

                Window ventana = Window.GetWindow(this);
                if (ventana != null)
                {
                    ventana.Close();
                }
            }

        }
        private void minimizar(object sender, RoutedEventArgs e)
        {

            Window ventana = Window.GetWindow(this);
            if (ventana != null)
            {
                ventana.WindowState = WindowState.Minimized;
            }
        }
        private void Agregar_tipo_contacto(object sender, RoutedEventArgs e)
        {
            Tipo_contacto.Items.Add(txttipocontacto.Text);
        }
        private void Agregar_tipo_red_social(object sender, RoutedEventArgs e)
        {
            Tipo_red_social.Items.Add(txttiporedsocial.Text);
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Registrar_contacto_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}