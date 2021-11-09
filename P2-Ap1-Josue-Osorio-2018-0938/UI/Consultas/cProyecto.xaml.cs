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

namespace P2_Ap1_Josue_Osorio_2018_0938.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cProyecto.xaml
    /// </summary>
    public partial class cProyecto : Window
    {
        public cProyecto()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
          
                var Detalle = new List<Proyectos>();

                if (!String.IsNullOrWhiteSpace(CriterioComboBox.Text))
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {

                        case 0:
                            Detalle = ProyectoBLL.GetList(r => r.Proyectoid == Utilidades.ToInt(CriterioComboBox.Text));
                            break;
                        case 1:
                            Detalle = ProyectoBLL.GetList(r => r.Descripcion.Contains(CriterioComboBox.Text.ToUpper()) || r.Descripcion.Contains(CriterioComboBox.Text.ToLower()));
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Detalle = ProyectoBLL.GetList(e => true);

                }
                DatosDataGrid.ItemsSource = null;
                DatosDataGrid.ItemsSource = Detalle;


            }
       }
}
