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
        private static Viewport3D myViewport;
        private static double X = 0;
        private static double Y = 0;
        private static bool flag = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        public static Viewport3D content = null;
        public void Test(object sender, MouseButtonEventArgs args)
        {
            Point Position = args.GetPosition(myViewport);
            PointHitTestParameters PointParams = new PointHitTestParameters(Position);
            VisualTreeHelper.HitTest(myViewport, null, HTResult, PointParams);
        }
        public HitTestResultBehavior HTResult(System.Windows.Media.HitTestResult Result)
        {
            RayHitTestResult RayResult = Result as RayHitTestResult;
            if (RayResult != null)
            {
                RayMeshGeometry3DHitTestResult RayMeshResult = RayResult as RayMeshGeometry3DHitTestResult;
                if (RayMeshResult != null)
                {
                    GeometryModel3D Model = RayMeshResult.ModelHit as GeometryModel3D;
                    SetResult(Model);
                }
            }
            return HitTestResultBehavior.Stop;
        }
        
        
        public void SetResult(GeometryModel3D model)
        {
            if (model.Geometry == ((Cube)myViewport).CubeSide1)
            {
                MessageBox.Show("Side 1");
            }
            else if (model.Geometry == ((Cube)myViewport).CubeSide2)
            {
                MessageBox.Show("Side 2");
            }
            else if (model.Geometry == ((Cube)myViewport).CubeSide3)
            {
                MessageBox.Show("Side 3");
            }
            else if (model.Geometry == ((Cube)myViewport).CubeSide4)
            {
                MessageBox.Show("Side 4");
            }
            else if (model.Geometry == ((Cube)myViewport).CubeSide5)
            {
                MessageBox.Show("Side 5");
            }
            else if (model.Geometry == ((Cube)myViewport).CubeSide6)
            {
                MessageBox.Show("Side 6");
            }
        }

        private void DockPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                if (X == 0 && Y == 0)
                {
                    var position = e.GetPosition(this);
                    var point = PointToScreen(position);
                    X = point.X;
                    Y = point.Y;
                }
                else
                {
                    var position = e.GetPosition(this);
                    var point = PointToScreen(position);
                    if ((point.X - X) > 0)
                    {
                         textBox1.Text = "Right";
                    }
                    else if((point.X - X) < 0)
                    {
                        textBox1.Text = "Left";
                    }
                    if ((point.Y - Y) > 0)
                    {
                        textBox2.Text = "Down";
                    }
                    else if ((point.Y - Y) < 0)
                    {
                        textBox2.Text = "Up";
                    }
                    X = point.X;
                    Y = point.Y;
                }

            }
        }

        private void DockPanel_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            flag = true;
        }

        private void DockPanel_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            flag = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            myViewport = new Cube();
            ((Cube)myViewport).Side01Img = @"D:\Megamozg.png";
            MainPlatform.Children.Add(myViewport);
            RotateUtil util = new RotateUtil(MainPlatform);
            myViewport.Camera.Transform = util.TransformSource;
        }
    }
}
