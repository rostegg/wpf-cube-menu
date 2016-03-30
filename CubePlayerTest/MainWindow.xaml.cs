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
        public void TestCube()
        {
            // <Viewport3D  ClipToBounds="True" Width="351" Height="400" Name="myViewport" Focusable="True" Margin="0,0,0,-29.6" >
            Viewport3D obj = new Viewport3D() {
                ClipToBounds = true,
                Width = 351,
                Height = 400,
                Focusable = true,
                Margin = new Thickness(0, 0, 0, -29.6)
            };
            obj.Camera = new PerspectiveCamera() {
                FarPlaneDistance = 15,
                LookDirection = new Vector3D(0, 0, 1),
                UpDirection = new Vector3D(0, 1, 0),
                NearPlaneDistance = 1,
                Position = new Point3D(0, 0, -3),
                FieldOfView=50
            };

            EventTrigger Event = new EventTrigger()
            {
                RoutedEvent = Viewport3D.LoadedEvent
            };
           
            ModelVisual3D CubeModel = new ModelVisual3D();

            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new DirectionalLight() { Color = Color.FromRgb(255,255,255), Direction = new Vector3D(-0.612372, -0.5, -0.612372) }
            });
            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new DirectionalLight() { Color = Color.FromRgb(255, 255, 255), Direction = new Vector3D(0.612372, -0.5, -0.612372) }
            });

            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new AmbientLight() { Color = Color.FromRgb(255, 255, 255) }
            });


            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new GeometryModel3D() { Geometry = (Geometry3D)Application.Current.Resources["CubeSide01"] ,
                    Material = (Material)Application.Current.Resources["Material1"] }
            });

            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new GeometryModel3D()
                {
                    Geometry = (Geometry3D)Application.Current.Resources["CubeSide02"],
                    Material = (Material)Application.Current.Resources["Material2"]
                }
            });

            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new GeometryModel3D()
                {
                    Geometry = (Geometry3D)Application.Current.Resources["CubeSide03"],
                    Material = (Material)Application.Current.Resources["Material3"]
                }
            });

            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new GeometryModel3D()
                {
                    Geometry = (Geometry3D)Application.Current.Resources["CubeSide04"],
                    Material = (Material)Application.Current.Resources["Material1"]
                }
            });

            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new GeometryModel3D()
                {
                    Geometry = (Geometry3D)Application.Current.Resources["CubeSide05"],
                    Material = (Material)Application.Current.Resources["Material2"]
                }
            });

            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new GeometryModel3D()
                {
                    Geometry = (Geometry3D)Application.Current.Resources["CubeSide06"],
                    Material = (Material)Application.Current.Resources["Material3"]
                }
            });


            Transform3DGroup CubeAnim = new Transform3DGroup();

            //horizontal
            CubeAnim.Children.Add(new RotateTransform3D()
            {
                Rotation = new AxisAngleRotation3D() { Angle = 0, Axis = new Vector3D(0, 1, 0) }
            });


            //vetical
            CubeAnim.Children.Add(new RotateTransform3D()
            {
                Rotation = new AxisAngleRotation3D() { Angle = 0, Axis = new Vector3D(1, 0, 0) }
            } );

            CubeAnim.Children.Add(new TranslateTransform3D()
            {
                OffsetX = 0,
                OffsetY=0,
                OffsetZ=0
            });

            CubeModel.Transform = CubeAnim;

            obj.Children.Add(CubeModel);

            content = obj;
            //< TranslateTransform3D x: Name = "myTranslateTransform" OffsetX = "0" OffsetY = "0" OffsetZ = "0" />

        }
        public void SetResult(GeometryModel3D model)
        {
            if (model.Geometry == (MeshGeometry3D)Application.Current.Resources["CubeSide01"])
            {
                MessageBox.Show("Side 1");
            }
            else if (model.Geometry == (MeshGeometry3D)Application.Current.Resources["CubeSide02"])
            {
                MessageBox.Show("Side 2");
            }
            else if (model.Geometry == (MeshGeometry3D)Application.Current.Resources["CubeSide03"])
            {
                MessageBox.Show("Side 3");
            }
            else if (model.Geometry == (MeshGeometry3D)Application.Current.Resources["CubeSide04"])
            {
                MessageBox.Show("Side 4");
            }
            else if (model.Geometry == (MeshGeometry3D)Application.Current.Resources["CubeSide05"])
            {
                MessageBox.Show("Side 5");
            }
            else if (model.Geometry == (MeshGeometry3D)Application.Current.Resources["CubeSide06"])
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

            RotateUtil util = new RotateUtil(MainPlatform);
            myViewport.Camera.Transform = util.TransformSource;
        }
    }
}
