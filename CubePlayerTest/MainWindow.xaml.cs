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
        private static Cube myViewport;
        private static double X = 0;
        private static double Y = 0;
        private static bool flag = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            myViewport = new Cube(MainPlatform);
            myViewport.Side01Img = @"D:\Megamozg.png";
            MainPlatform.Children.Add(myViewport);
           // RotateUtil util = new RotateUtil(MainPlatform);
           // myViewport.Camera.Transform = util.TransformSource;
           // ClickingUtil click = new ClickingUtil(myViewport, Figures.Cube);
           //this.MainPlatform.MouseLeftButtonDown += ((Cube)myViewport).ClickEvent.ClickFaceEvent;
        }
    }
}
