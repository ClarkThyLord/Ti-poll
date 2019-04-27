using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Ti_poll.Clases;

namespace Ti_poll
{
    /// <summary>
    /// Interaction logic for Stats.xaml
    /// </summary>
    public partial class Stats : Window
    {
        public Timer timer;
        int siH = 9;
        int siM = 5;
        public Stats()
        {
            InitializeComponent();
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Clases.Survey sac = new Clases.Survey();

            if (combo_cb.SelectedIndex == 0)
            {
                //h_pb.Maximum = sac.ViewsH;
                //m_pb.Maximum = sac.ViewsM;
                //x_pb.Maximum = sac.ViewsH + sac.ViewsM;

                //timer = new Timer(1);
                //timer.Elapsed += Timer_Elapsed;
                //timer.Enabled = true;

                int hombres = 10;
                int mujeres = 10;
                h_pb.Maximum = hombres;
                m_pb.Maximum = mujeres;
                //Maximum = hombres;
                //adios.Maximum = mujeres;

                x_pb.Maximum = hombres + mujeres;

                timer = new Timer(1);
                timer.Elapsed += Timer_Elapsed;
                timer.Enabled = true;

            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //Clases.Survey sac = new Clases.Survey();
            //Profile pro = new Profile();
            //Dispatcher.Invoke((Action)(() =>
            //{
            //    if (h_pb.Value < sac.ViewsH) h_pb.Value += 1;

            //    if (m_pb.Value < sac.ViewsM) m_pb.Value += 1;

            //    if (x_pb.Value < sac.ViewsM + sac.ViewsH) x_pb.Value += 1;
            //    if (x_pb.Value == sac.ViewsH+sac.ViewsM && h_pb.Value == sac.ViewsH && m_pb.Value == sac.ViewsM)
            //    {
            //        timer.Dispose();
            //    }


            Dispatcher.Invoke((Action)(() =>
            {
                if (h_pb.Value < siH) h_pb.Value += 1;

                if (m_pb.Value < siM) m_pb.Value += 1;

                if (x_pb.Value < siH + siM) x_pb.Value += 1;
                if (x_pb.Value == siH + siM && h_pb.Value == siH && m_pb.Value == siM)
                {
                    timer.Dispose();
                }

            }));
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Home h = new Home();
            h.Owner = this;
            h.Show();
            Hide();

        }
    }
}
