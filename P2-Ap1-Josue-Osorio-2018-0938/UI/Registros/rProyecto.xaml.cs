using P2_Ap1_Josue_Osorio_2018_0938.BLL;
using P2_Ap1_Josue_Osorio_2018_0938.Entidades;
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

namespace P2_Ap1_Josue_Osorio_2018_0938.UI.Registros
{
    /// <summary>
    /// Interaction logic for rProyecto.xaml
    /// </summary>
    public partial class rProyecto : Window
    {
        private Proyectos proyectos = new Proyectos();
        private TipoDetalle Detalle = new TipoDetalle();
        public rProyecto()
        {
            InitializeComponent();
            this.DataContext = proyectos;

            TipodeTareaComboBox.ItemsSource = TipoDeTareaBLL.GetTiposTarea();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
         //   Proyectos encontrado = ProyectoBLL.Buscar(Proyectos.Proyectoid);
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoverFilaButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Limpiar()
        {
            this.proyectos = new Proyectos();
            this.DataContext = proyectos;
        }
    }
}
