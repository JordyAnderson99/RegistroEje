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
using RegistroEje.DAL;
using RegistroEje.Entidades;

namespace RegistroEje
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
        Actores actor =new Actores();
        public void GuardarButton_Click(object sender, RoutedEventArgs e){
            Contexto context = new Contexto();

            
            context.Actores.Add(this.actor);

           int cant= context.SaveChanges();
            context.Dispose();

            if(cant>0){
                MessageBox.Show("Guardo!");
                this.actor = new Actores();
                this.DataContext = this.actor;
            }
            else if(cant==0){
                MessageBox.Show("No se pudo Guardar!");
                this.actor = new Actores();
                this.DataContext = this.actor;
            }

        }

        public void BuscarButton_Click(object sender, RoutedEventArgs e){

                Contexto context = new Contexto();
                var found = context.Actores.Find(Convert.ToInt32(ActorIdTextBox.Text));

                if(found != null){
                    Actores actor = found;
                    NombresTextBox.Text =actor.Nombres;
                    SalarioIdTextBox.Text = Convert.ToString(actor.Salario);
                }
            }
    }

    
}
