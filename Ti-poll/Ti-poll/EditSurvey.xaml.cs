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
    /// Interaction logic for EditSurvey.xaml
    /// </summary>
    public partial class EditSurvey : Window
    {
        public Clases.Survey survey;

        public EditSurvey(Clases.Survey survey)
        {
            InitializeComponent();
            this.survey = survey;
            questions_lb.ItemsSource = survey.profiles;
        }
        
    }
}
