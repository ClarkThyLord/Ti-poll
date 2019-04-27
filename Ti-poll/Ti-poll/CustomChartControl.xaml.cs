using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ti_poll
{
    /// <summary>
    /// Interaction logic for CustomChartControl.xaml
    /// </summary>
    public partial class CustomChartControl : UserControl
    {
        public double rectSpace { get; set; }
        public double rectWidth { get; set; }
        public CustomChartControl()
        {
            InitializeComponent();
        }
        //Define some properties
        //Property for dataSource for chart
        private static readonly DependencyProperty dataSource = DependencyProperty.Register("dataSource", typeof(string), typeof(CustomChartControl));
        public string DataSource
        {
            get { return (string)this.GetValue(dataSource); }
            set { this.SetValue(dataSource, value); }
        }
        //Chart bars Color
        private static readonly DependencyProperty barsColor = DependencyProperty.Register("barsColor", typeof(Brush), typeof(CustomChartControl));
        public Brush BarsColor
        {
            get { return (Brush)this.GetValue(barsColor); }
            set { this.SetValue(barsColor, value); }
        }
        //Method for drawing bars/Rectangles
        public void DrawBars()
        {
            string Data = File.ReadAllText(DataSource);
            string[] valueData = Data.Split(';');
            string[] cat1Value = valueData[0].Split(',');
            string[] cat2Value = valueData[1].Split(',');
            //Determine section depends on amount of Data
            double section = 525 / cat1Value.Length;
            //Space between bars, 20% of section
            rectSpace = (section * 20) / 100;
            //Bars width
            rectWidth = (section * 20) / 100;
            //Actual Drawing
            for(int i = 0; i < cat1Value.Length; i++)
            {
                Rectangle rec = new Rectangle();
                rec.Width = rectWidth;
                rec.Height = Convert.ToDouble(cat1Value[i]);
                rec.Margin = new Thickness(rectSpace, (350 - rec.Height), 0, 25);
                rec.Fill = BarsColor;
                wPanel.Children.Add(rec);
                //Effect or Animation
                DoubleAnimation ani = new DoubleAnimation
                {
                    From = 0,
                    To = Convert.ToDouble(cat1Value[i]),
                    Duration = new TimeSpan(0, 0, 2)
                };
                //Add animation
                ani.FillBehavior = FillBehavior.HoldEnd;
                rec.BeginAnimation(HeightProperty, ani);
                rec.Effect = new DropShadowEffect
                {
                    Color = new Color { A = 1, R = 0, G = 139, B = 139 },
                    Direction = 45,
                    ShadowDepth = 10,
                    Opacity = 0.8,
                    BlurRadius = 10
                };

                //Add axis labels
                Label label = new Label();
                label.Content = cat2Value[i].ToString();
                label.Background = Brushes.Transparent;
                label.Foreground = Brushes.SkyBlue;
                label.Margin = new Thickness(rectSpace, 320, 0, 0);
                label.FontSize = 20 - cat2Value.Length;
                label.Width = rec.Width;
                label.HorizontalAlignment = HorizontalAlignment.Center;
                label.Height = 30;
                stkPanel.Children.Add(label);
                //Show value on mouse hover
                rec.MouseEnter += Rec_MouseEnter;
            }
            //Add side lines/Scale Lines, each separated by value of 20
            for(int i = 20; i < wPanel.Height; i += 20)
            {
                Line line = new Line();
                line.X1 = 5;
                line.Y1 = i;
                line.X2 = 25;
                line.Y2 = line.Y1;
                line.Stroke = Brushes.SkyBlue;
                line.StrokeThickness = 1;
                grid.Children.Add(line);
            }
        }

        private void Rec_MouseEnter(object sender, MouseEventArgs e)
        {
            //Also add some animation
            DoubleAnimation anim = new DoubleAnimation
            {
                From = 0.7,
                To = 1,
                Duration = new TimeSpan(0, 0, 1)
            };
            ((Rectangle)sender).BeginAnimation(OpacityProperty, anim);
            popWindow.ClearValue(Popup.IsOpenProperty);
            popWindow.IsOpen = true;
            lblPopup.Content = "Value: " + ((Rectangle)sender).Height.ToString();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DrawBars();
        }
    }
}
