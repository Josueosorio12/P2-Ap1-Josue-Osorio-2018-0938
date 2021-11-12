using P2_Ap1_Josue_Osorio_2018_0938.Entidades;
using P2_Ap1_Josue_Osorio_2018_0938.UI.Consultas;
using P2_Ap1_Josue_Osorio_2018_0938.UI.Registros;
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

namespace P2_Ap1_Josue_Osorio_2018_0938
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            rProyecto proyect = new rProyecto();
            proyect.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            cProyecto proyecto = new cProyecto();
            proyecto.Show();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            cTipoTarea cTipo = new cTipoTarea();
            cTipo.Show();
        }
    }
}
