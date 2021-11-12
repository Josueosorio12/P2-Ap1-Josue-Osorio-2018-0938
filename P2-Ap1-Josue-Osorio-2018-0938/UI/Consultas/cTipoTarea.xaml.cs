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
    /// Interaction logic for cTipoTarea.xaml
    /// </summary>
    public partial class cTipoTarea : Window
    {
        public cTipoTarea()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<TipoTarea>();
           
            switch (FiltroComboBox.SelectedIndex)
            {
                case 0: 
                    listado = TipoDeTareaBLL.GetTiposTarea();
                    break;
                case 1: 
                    listado = TipoDeTareaBLL.GetList(e => e.Tipoid == Utilidades.ToInt(CriterioTextBox.Text));
                    break;
                case 2:
                    listado = TipoDeTareaBLL.GetList(e => e.Requerimiento.Contains(CriterioTextBox.Text.ToLower()));
                    break;
                case 3:
                    listado = TipoDeTareaBLL.GetList(e => e.Tiempo == Utilidades.ToInt(CriterioTextBox.Text));
                    break;
            }

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;

        }
    }
}
