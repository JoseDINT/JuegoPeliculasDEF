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

namespace EjercicioPeliculas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM vm = new MainWindowVM();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void Image_Right_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            vm.Siguiente();
        }

        private void Image_Left_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            vm.Anterior();
        }

        private void PistaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PistaTextBox.Visibility = Visibility.Hidden;
            vm.MostrarPista();
        }

        private void PistaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            PistaTextBox.Visibility = Visibility.Visible;
        }

        private void Button_Cargar_Click(object sender, RoutedEventArgs e)
        {    
            vm.Peliculas = vm.CargarListaPeliculasJSON();
        }

        private void Eliminar_Button_Click(object sender, RoutedEventArgs e)
        {
            vm.EliminarPelicula();
        }
    }
}
