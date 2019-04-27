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

namespace Ti_poll
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class SpalshScreen : Window
    {
        public Timer timer;

        public SpalshScreen()
        {
            InitializeComponent();
        }

        public void Start()
        {
            timer = new Timer(10);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke((Action)(() =>
            {
                if (progress.Value < 100) progress.Value += 1;
                else
                {
                    timer.Dispose();
                    Hide();
                    Owner.Show();
                    Close();
                }
            }));
        }
    }
}
