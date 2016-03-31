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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CubePlayerTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Cube myFigure;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            myFigure = new Cube(MainPlatform);
            myFigure.Side01Function = () => { MessageBox.Show("Test"); };
            //myFigure.Side01Img = "Path";
            MainPlatform.Children.Add(myFigure);
        }
    }
}
