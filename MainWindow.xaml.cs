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

namespace controles2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            LinearGradientBrush buttonBush = new LinearGradientBrush();
            buttonBush.StartPoint = new Point(0, 0.5);
            buttonBush.EndPoint = new Point(1, 0.5);
            buttonBush.GradientStops.Add(new GradientStop(Colors.Green, 0));
            buttonBush.GradientStops.Add(new GradientStop(Colors.White, 0.9));
        }

    }

}

