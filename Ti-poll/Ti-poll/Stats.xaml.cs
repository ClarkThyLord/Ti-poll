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
        public Stats()
        {
            InitializeComponent();
            //questions_lb.Items.Add("hola");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Clases.Survey sac = new Clases.Survey();

            if (combo_cb.SelectedIndex == 0)
            {
                h_pb.Maximum = sac.ViewsH;
                m_pb.Maximum = sac.ViewsM;
                x_pb.Maximum = sac.ViewsH + sac.ViewsM;

                timer = new Timer(1);
                timer.Elapsed += Timer_Elapsed;
                timer.Enabled = true;

            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Clases.Survey sac = new Clases.Survey();
            Profile pro = new Profile();
            Dispatcher.Invoke((Action)(() =>
            {
                if (h_pb.Value < sac.ViewsH) h_pb.Value += 1;

                if (m_pb.Value < sac.ViewsM) m_pb.Value += 1;

                if (x_pb.Value < sac.ViewsM + sac.ViewsH) x_pb.Value += 1;
                if (x_pb.Value == sac.ViewsH+sac.ViewsM && h_pb.Value == sac.ViewsH && m_pb.Value == sac.ViewsM)
                {
                    timer.Dispose();
                }

            }));
        }
    }
}
