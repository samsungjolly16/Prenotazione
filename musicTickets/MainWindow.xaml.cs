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
using Ticket;

namespace musicTickets
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

        private void AggiungiCliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente c = new Cliente();
                {
                    c.Nome = txtNome.Text;
                    c.Cognome = txtCognome.Text;
                    c.Cellulare = txtCell.Text;
                    if (rdbM.IsChecked == true)
                    {
                        c.SetGenere(true);
                    }
                    else
                        c.SetGenere(false);
                }
                cmbCliente.Items.Add(c);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
