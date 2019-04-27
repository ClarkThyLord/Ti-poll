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

namespace Ti_poll
{
    /// <summary>
    /// Interaction logic for Perfil.xaml
    /// </summary>
    public partial class Perfil : Window
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void BttnGuardar_Click(object sender, RoutedEventArgs e)
        {
            Perfil popup = new Perfil();
            string messsage = "Save successfully";
            popup.ShowDialog(messsage);
        }

        private void ShowDialog(string messsage)
        {
            throw new NotImplementedException();
        }
    }
}
