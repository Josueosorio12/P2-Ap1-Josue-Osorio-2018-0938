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
        public List<TipoDetalle> Detalles;

        public rProyecto()
        {
            InitializeComponent();
            this.DataContext = proyectos;

            Detalles = new List<TipoDetalle>();
            TipodeTareaComboBox.ItemsSource = TipoDeTareaBLL.GetTiposTarea();
            TipodeTareaComboBox.SelectedValue = "Tipoid";
            TipodeTareaComboBox.DisplayMemberPath = "TipodeTarea";


            Limpiar();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
           var encontrado = ProyectoBLL.Buscar(Utilidades.ToInt(ProyectoidTextBox.Text));


            if(encontrado != null)
            {
                this.proyectos = encontrado;
                this.Detalles = encontrado.TipoDetalle;

               Cargar();
            }

            else
            {
                this.proyectos = new Proyectos();
                MessageBox.Show("El Proyecto no existe en la base de datos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            this.DataContext = this.proyectos;
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {

            if (!Validar())
                return;

            this.Detalles.Add(new TipoDetalle(
                proyectoid: (int)Convert.ToInt32(ProyectoidTextBox.Text),
                tipotarea: TipodeTareaComboBox.Text,
                requerimiento: RequerimientoTextBox.Text,
                tiempo: (int)Convert.ToInt32(TiempoTextBox.Text)
                ));

            TiempoTotalTextBox.Text = proyectos.Total.ToString();

            Cargar();

            TiempoTotalTextBox.Focus();
            TiempoTotalTextBox.Clear();
        }

        private void RemoverFilaButton_Click(object sender, RoutedEventArgs e)
        {
            if(TipoDataGrid.Items.Count >= 1 && TipoDataGrid.SelectedIndex <= TipoDataGrid.Items.Count - 1)
            {
                proyectos.TipoDetalle.RemoveAt(TipoDataGrid.SelectedIndex);
                proyectos.Total -= int.Parse(TiempoTotalTextBox.Text);
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {

            if (!Validar())
                return;

                bool paso = ProyectoBLL.Guardar(this.proyectos);

            if (proyectos.Proyectoid == 0)
            {
                paso = ProyectoBLL.Guardar(proyectos);
            }

         

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transacion Exitosa", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Error al guardar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProyectoBLL.Eliminar(Utilidades.ToInt(ProyectoidTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Proyecto Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("El Proyecto no se Elimino", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Cargar()
        {
            TipoDataGrid.ItemsSource = null;
            TipoDataGrid.ItemsSource = Detalles;
            proyectos.TipoDetalle = Detalles;
        }
        private void Limpiar()
        {
            this.proyectos = new Proyectos();
            this.DataContext = proyectos;
        }

        private bool Validar()
        {
            bool esValido = true;

            if(ProyectoidTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Favor LLenar todos los campos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if(DescripcionTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Favor LLenar todos los campos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if(RequerimientoTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Favor LLenar todos los campos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if(TiempoTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Favor LLenar todos los campos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            return esValido;
        }
    }
}
