using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System;
using System.IO;
using System.Windows;

namespace CubePlayerTest
{
    public class Cube : Viewport3D
    {
       
        #region CubeSide

        public MeshGeometry3D CubeSide1 = new MeshGeometry3D();
        public MeshGeometry3D CubeSide2 = new MeshGeometry3D();
        public MeshGeometry3D CubeSide3 = new MeshGeometry3D();
        public MeshGeometry3D CubeSide4 = new MeshGeometry3D();
        public MeshGeometry3D CubeSide5 = new MeshGeometry3D();
        public MeshGeometry3D CubeSide6 = new MeshGeometry3D();

        private void SetupeCubeSides()
        {
            System.Windows.Media.Int32Collection Triangle = new System.Windows.Media.Int32Collection(new List<int>() { 0, 1, 2, 3, 4, 5 });

            #region CubeSide1

            CubeSide1.TriangleIndices = Triangle;

            System.Windows.Media.PointCollection temp = new System.Windows.Media.PointCollection();
            temp.Add(new System.Windows.Point(0,1));
            temp.Add(new System.Windows.Point(0, 0));
            temp.Add(new System.Windows.Point(1, 0));
            temp.Add(new System.Windows.Point(1, 0));
            temp.Add(new System.Windows.Point(1, 1));
            temp.Add(new System.Windows.Point(0, 1));

            CubeSide1.TextureCoordinates = temp;

            CubeSide1.Normals = new Vector3DCollection(new List<Vector3D>() {
                new Vector3D(-1,0,0),
                new Vector3D(-1,0,0),
                new Vector3D(-1,0,0),
                new Vector3D(-1,0,0),
                new Vector3D(-1,0,0),
                new Vector3D(-1,0,0)
            });

            CubeSide1.Positions = new Point3DCollection(new List<Point3D>() {
                new Point3D(-0.5,0.5,-0.5),
                new Point3D(-0.5,-0.5,-0.5),
                new Point3D(-0.5,-0.5,0.5),
                new Point3D(-0.5,-0.5,0.5),
                new Point3D(-0.5,0.5,0.5),
                new Point3D(-0.5,0.5,-0.5)
            });

            #endregion

            #region CubeSide2

            CubeSide2.TriangleIndices = Triangle;

            temp = new System.Windows.Media.PointCollection();
            temp.Add(new System.Windows.Point(0, 0));
            temp.Add(new System.Windows.Point(1, 0));
            temp.Add(new System.Windows.Point(1, 1));
            temp.Add(new System.Windows.Point(1, 1));
            temp.Add(new System.Windows.Point(0, 1));
            temp.Add(new System.Windows.Point(0, 0));

            CubeSide2.TextureCoordinates = temp;

            CubeSide2.Normals = new Vector3DCollection(new List<Vector3D>() {
                new Vector3D(0,0,1),
                new Vector3D(0,0,1),
                new Vector3D(0,0,1),
                new Vector3D(0,0,1),
                new Vector3D(0,0,1),
                new Vector3D(0,0,1)
            });

            CubeSide2.Positions = new Point3DCollection(new List<Point3D>() {
                new Point3D(-0.5,-0.5,0.5),
                new Point3D(0.5,-0.5,0.5),
                new Point3D(0.5,0.5,0.5),
                new Point3D(0.5,0.5,0.5),
                new Point3D(-0.5,0.5,0.5),
                new Point3D(-0.5,-0.5,0.5)
            });

            #endregion

            #region CubeSide3

            CubeSide3.TriangleIndices = Triangle;

            temp = new System.Windows.Media.PointCollection();
            temp.Add(new System.Windows.Point(1, 0));
            temp.Add(new System.Windows.Point(1, 1));
            temp.Add(new System.Windows.Point(0, 1));
            temp.Add(new System.Windows.Point(0, 1));
            temp.Add(new System.Windows.Point(0, 0));
            temp.Add(new System.Windows.Point(1, 0));

            CubeSide3.TextureCoordinates = temp;

            CubeSide3.Normals = new Vector3DCollection(new List<Vector3D>() {
                new Vector3D(0,0,1),
                new Vector3D(0,0,1),
                new Vector3D(0,0,1),
                new Vector3D(0,0,1),
                new Vector3D(0,0,1),
                new Vector3D(0,0,1)
            });

            CubeSide3.Positions = new Point3DCollection(new List<Point3D>() {
                new Point3D(0.5,-0.5,-0.5),
                new Point3D(0.5,0.5,-0.5),
                new Point3D(0.5,0.5,0.5),
                new Point3D(0.5,0.5,0.5),
                new Point3D(0.5,-0.5,0.5),
                new Point3D(0.5,-0.5,-0.5)
            });

            #endregion

            #region CubeSide4

            CubeSide4.TriangleIndices = Triangle;

            temp = new System.Windows.Media.PointCollection();
            temp.Add(new System.Windows.Point(1, 0));
            temp.Add(new System.Windows.Point(1, 1));
            temp.Add(new System.Windows.Point(0, 1));
            temp.Add(new System.Windows.Point(0, 1));
            temp.Add(new System.Windows.Point(0, 0));
            temp.Add(new System.Windows.Point(1, 0));

            CubeSide4.TextureCoordinates = temp;

            CubeSide4.Normals = new Vector3DCollection(new List<Vector3D>() {
                new Vector3D(1,0,0),
                new Vector3D(1,0,0),
                new Vector3D(1,0,0),
                new Vector3D(1,0,0),
                new Vector3D(1,0,0),
                new Vector3D(1,0,0)
            });

            CubeSide4.Positions = new Point3DCollection(new List<Point3D>() {
                new Point3D(-0.5,-0.5,-0.5),
                new Point3D(-0.5,0.5,-0.5),
                new Point3D(0.5,0.5,-0.5),
                new Point3D(0.5,0.5,-0.5),
                new Point3D(0.5,-0.5,-0.5),
                new Point3D(-0.5,-0.5,-0.5)
            });

            #endregion

            Triangle = new System.Windows.Media.Int32Collection(new List<int>() { 0, 1, 2, 3, 4, 5,6,7,8,9,10,11 });

            #region CubeSide5

            CubeSide5.TriangleIndices = Triangle;

            temp = new System.Windows.Media.PointCollection();
            temp.Add(new System.Windows.Point(0, 0));
            temp.Add(new System.Windows.Point(1, 0));
            temp.Add(new System.Windows.Point(1, 1));
            temp.Add(new System.Windows.Point(1, 1));
            temp.Add(new System.Windows.Point(0, 1));
            temp.Add(new System.Windows.Point(0, 0));

            temp.Add(new System.Windows.Point(1, 1));
            temp.Add(new System.Windows.Point(0, 1));
            temp.Add(new System.Windows.Point(0, 0));
            temp.Add(new System.Windows.Point(0, 0));
            temp.Add(new System.Windows.Point(1, 0));
            temp.Add(new System.Windows.Point(1, 1));

            CubeSide5.TextureCoordinates = temp;

            CubeSide5.Normals = new Vector3DCollection(new List<Vector3D>() {
                new Vector3D(0,-1,0),
                new Vector3D(0,-1,0),
                new Vector3D(0,-1,0),
                new Vector3D(0,-1,0),
                new Vector3D(0,-1,0),
                new Vector3D(0,-1,0),
                new Vector3D(0,1,0),
                new Vector3D(0,1,0),
                new Vector3D(0,1,0),
                new Vector3D(0,1,0),
                new Vector3D(0,1,0),
                new Vector3D(0,1,0)
            });

            CubeSide5.Positions = new Point3DCollection(new List<Point3D>() {
                new Point3D(-0.5,-0.5,-0.5),
                new Point3D( -0.5,0.5,0.5),
                new Point3D( -0.5,-0.5,0.5),
                new Point3D(0.5,-0.5,0.5),
                new Point3D(-0.5,-0.5,-0.5),
                new Point3D(-0.5,0.5,-0.5),

                new Point3D(0.5,0.5,-0.5),
                new Point3D(-0.5,0.5,-0.5),
                new Point3D(-0.5,0.5,0.5),
                new Point3D(-0.5,0.5,0.5),
                new Point3D(0.5,0.5,0.5),
                new Point3D(0.5,0.5,-0.5)
            });

            #endregion


            #region CubeSide6

            CubeSide6.TriangleIndices = Triangle;

            temp = new System.Windows.Media.PointCollection();
            temp.Add(new System.Windows.Point(1, 0));
            temp.Add(new System.Windows.Point(1, 1));
            temp.Add(new System.Windows.Point(0, 1));
            temp.Add(new System.Windows.Point(0, 1));
            temp.Add(new System.Windows.Point(0, 0));
            temp.Add(new System.Windows.Point(1, 0));

            CubeSide6.TextureCoordinates = temp;

            CubeSide6.Normals = new Vector3DCollection(new List<Vector3D>() {
                new Vector3D(-1,0,0),
                new Vector3D(-1,0,0),
                new Vector3D(-1,0,0),
                new Vector3D(-1,0,0),
                new Vector3D(-1,0,0),
                new Vector3D(-1,0,0),
            });

            CubeSide6.Positions = new Point3DCollection(new List<Point3D>() {
                new Point3D(-0.5,-0.5,0.5),
                new Point3D(-0.5,-0.5,-0.5),
                new Point3D(0.5,-0.5,-0.5),
                new Point3D(0.5,-0.5,-0.5),
                new Point3D(0.5,-0.5,0.5),
                new Point3D(-0.5,-0.5,0.5)
                
            });

            #endregion


        }


        #endregion

        #region Material

        public MaterialGroup DefaultMaterial = new MaterialGroup();
        private MaterialGroup CubeSide01Material = new MaterialGroup();
        private MaterialGroup CubeSide02Material = new MaterialGroup();
        private MaterialGroup CubeSide03Material = new MaterialGroup();
        private MaterialGroup CubeSide04Material = new MaterialGroup();
        private MaterialGroup CubeSide05Material = new MaterialGroup();
        private MaterialGroup CubeSide06Material = new MaterialGroup();

        private void SetupMaterials()
        {
            #region Default
            LinearGradientBrush brush = new LinearGradientBrush();
            brush.GradientStops = new GradientStopCollection(new List<GradientStop>() {
                new GradientStop() { Color = Color.FromRgb(255,0,0), Offset =0 },
                new GradientStop() { Color = Color.FromRgb(255,255,0), Offset =0.5 },
                new GradientStop() { Color = Color.FromRgb(0,0,255), Offset =0.7 }
            }); 

            DiffuseMaterial material = new DiffuseMaterial(brush);
            DefaultMaterial.Children.Add(material);
            #endregion

            #region CubeMaterials

            DiffuseMaterial material01 = new DiffuseMaterial(new ImageBrush() {
                Stretch = Stretch.Fill,
                TileMode = TileMode.None,
                ViewportUnits = BrushMappingMode.Absolute,
                Viewport = new System.Windows.Rect(0, 0, 1, 1),
                AlignmentX = AlignmentX.Left,
                AlignmentY = AlignmentY.Top,
                Opacity = 1
            });

            CubeSide01Material.Children.Add(material01);
            CubeSide02Material.Children.Add(material01);
            CubeSide03Material.Children.Add(material01);
            CubeSide04Material.Children.Add(material01);
            CubeSide05Material.Children.Add(material01);
            CubeSide06Material.Children.Add(material01);
            
            #endregion

        }

        #endregion

        #region Params
        private DockPanel Platform = null;
        public ClickingUtil ClickEvent = null;

        private string _side01Img = String.Empty;
        private string _side02Img = String.Empty;
        private string _side03Img = String.Empty;
        private string _side04Img = String.Empty;
        private string _side05Img = String.Empty;
        private string _side06Img = String.Empty;

        private Action _side01Func = null;
        private Action _side02Func = null;
        private Action _side03Func = null;
        private Action _side04Func = null;
        private Action _side05Func = null;
        private Action _side06Func = null;


        public string Side01Img
        {
            get { return _side01Img; }
            set
            {
                if (File.Exists(value))
                {
                    ((ImageBrush)((DiffuseMaterial)CubeSide01Material.Children[0]).Brush).ImageSource = new BitmapImage(new Uri(value));

                    ((GeometryModel3D)((ModelVisual3D)((ModelVisual3D)this.Children[0]).Children[3]).Content).Material = CubeSide01Material;
                    _side01Img = value;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
        }

        public string Side02Img
        {
            get { return _side02Img; }
            set
            {
                if (File.Exists(value))
                {
                    ((ImageBrush)((DiffuseMaterial)CubeSide02Material.Children[0]).Brush).ImageSource = new BitmapImage(new Uri(value));

                    ((GeometryModel3D)((ModelVisual3D)((ModelVisual3D)this.Children[0]).Children[4]).Content).Material = CubeSide02Material;
                    _side02Img = value;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
        }

        public string Side03Img
        {
            get { return _side03Img; }
            set
            {
                if (File.Exists(value))
                {
                    ((ImageBrush)((DiffuseMaterial)CubeSide03Material.Children[0]).Brush).ImageSource = new BitmapImage(new Uri(value));

                    ((GeometryModel3D)((ModelVisual3D)((ModelVisual3D)this.Children[0]).Children[5]).Content).Material = CubeSide03Material;

                    _side03Img = value;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
        }

        public string Side04Img
        {
            get { return _side04Img; }
            set
            {
                if (File.Exists(value))
                {
                    ((ImageBrush)((DiffuseMaterial)CubeSide04Material.Children[0]).Brush).ImageSource = new BitmapImage(new Uri(value));

                    ((GeometryModel3D)((ModelVisual3D)((ModelVisual3D)this.Children[0]).Children[6]).Content).Material = CubeSide04Material;

                    _side04Img = value;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
        }

        public string Side05Img
        {
            get { return _side05Img; }
            set {
                 if (File.Exists(value))
                {
                    ((ImageBrush)((DiffuseMaterial)CubeSide05Material.Children[0]).Brush).ImageSource = new BitmapImage(new Uri(value));

                    ((GeometryModel3D)((ModelVisual3D)((ModelVisual3D)this.Children[0]).Children[7]).Content).Material = CubeSide05Material;

                    _side05Img = value;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
        }

        public string Side06Img
        {
            get { return _side06Img; }
            set
            {
                if (File.Exists(value))
                {
                    ((ImageBrush)((DiffuseMaterial)CubeSide06Material.Children[0]).Brush).ImageSource = new BitmapImage(new Uri(value));

                    ((GeometryModel3D)((ModelVisual3D)((ModelVisual3D)this.Children[0]).Children[8]).Content).Material = CubeSide06Material;

                    _side06Img = value;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
        }

        public Action Side01Function
        {
            get { return _side01Func; }
            set { _side01Func = value; }
        }

        public Action Side02Function
        {
            get { return _side02Func; }
            set { _side02Func = value; }
        }

        public Action Side03Function
        {
            get { return _side03Func; }
            set { _side03Func = value; }
        }

        public Action Side04Function
        {
            get { return _side04Func; }
            set { _side04Func = value; }
        }

        public Action Side05Function
        {
            get { return _side05Func; }
            set { _side05Func = value; }
        }

        public Action Side06Function
        {
            get { return _side06Func; }
            set { _side06Func = value; }
        }
        #endregion


        public Cube(DockPanel platform)
        {
            Platform = platform;
            SetupeCubeSides();
            SetupMaterials();
            CreateCube();
            ClickEvent = new ClickingUtil(this as Viewport3D, Figures.Cube);
            platform.MouseLeftButtonDown += ClickEvent.ClickFaceEvent;
            CreateRotateUtil();
        }

        public Cube(double position, DockPanel platform)
        {
            Platform = platform;
            SetupeCubeSides();
            SetupMaterials();
            if (position > 0 && position < 1)
            {
                ChangePositionFromDefault(position);
            }
            CreateCube();
            ClickEvent = new ClickingUtil(this as Viewport3D, Figures.Cube);
            platform.MouseLeftButtonDown += ClickEvent.ClickFaceEvent;
            CreateRotateUtil();
        }

        public void ChangePositionFromDefault(double position)
        {
            CubeSide1.Positions = new Point3DCollection(new List<Point3D>() {
                new Point3D(-position,position,-position),
                new Point3D(-position,-position,-position),
                new Point3D(-position,-position,position),
                new Point3D(-position,-position,position),
                new Point3D(-position,position,position),
                new Point3D(-position,position,-position)
            });

            CubeSide2.Positions = new Point3DCollection(new List<Point3D>() {
                new Point3D(-position,-position,position),
                new Point3D(position,-position,position),
                new Point3D(position,position,position),
                new Point3D(position,position,position),
                new Point3D(-position,position,position),
                new Point3D(-position,-position,position)
            });

            CubeSide3.Positions = new Point3DCollection(new List<Point3D>() {
                new Point3D(position,-position,-position),
                new Point3D(position,position,-position),
                new Point3D(position,position,position),
                new Point3D(position,position,position),
                new Point3D(position,-position,position),
                new Point3D(position,-position,-position)
            });

            CubeSide4.Positions = new Point3DCollection(new List<Point3D>() {
                new Point3D(-position,-position,-position),
                new Point3D(-position,position,-position),
                new Point3D(position,position,-position),
                new Point3D(position,position,-position),
                new Point3D(position,-position,-position),
                new Point3D(-position,-position,-position)
            });

            CubeSide5.Positions = new Point3DCollection(new List<Point3D>() {
                new Point3D(-position,-position,-position),
                new Point3D( -position,position,position),
                new Point3D( -position,-position,position),
                new Point3D(position,-position,position),
                new Point3D(-position,-position,-position),
                new Point3D(-position,position,-position),

                new Point3D(position,position,-position),
                new Point3D(-position,position,-position),
                new Point3D(-position,position,position),
                new Point3D(-position,position,position),
                new Point3D(position,position,position),
                new Point3D(position,position,-position)
            });

            CubeSide6.Positions = new Point3DCollection(new List<Point3D>() {
                new Point3D(-position,-position,position),
                new Point3D(-position,-position,-position),
                new Point3D(position,-position,-position),
                new Point3D(position,-position,-position),
                new Point3D(position,-position,position),
                new Point3D(-position,-position,position)

            });

        }

        private void CreateCube()
        {
            this.ClipToBounds = true;
            this.Width = 351;
            this.Height = 400;
            this.Focusable = true;
            this.Margin = new Thickness(0, 0, 0, -29.6);

            this.Camera = new PerspectiveCamera()
            {
                FarPlaneDistance = 15,
                LookDirection = new Vector3D(0, 0, 1),
                UpDirection = new Vector3D(0, 1, 0),
                NearPlaneDistance = 1,
                Position = new Point3D(0, 0, -3),
                FieldOfView = 50
            };

            EventTrigger Event = new EventTrigger()
            {
                RoutedEvent = Viewport3D.LoadedEvent
            };

            ModelVisual3D CubeModel = new ModelVisual3D();

            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new DirectionalLight() { Color = Color.FromRgb(255, 255, 255), Direction = new Vector3D(-0.612372, -0.5, -0.612372) }
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
                Content = new GeometryModel3D()
                {
                    Geometry = CubeSide1,
                    Material = DefaultMaterial
                }
            });

            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new GeometryModel3D()
                {
                    Geometry = CubeSide2,
                    Material = DefaultMaterial
                }
            });

            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new GeometryModel3D()
                {
                    Geometry = CubeSide3,
                    Material = DefaultMaterial
                }
            });

            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new GeometryModel3D()
                {
                    Geometry = CubeSide4,
                    Material = DefaultMaterial
                }
            });

            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new GeometryModel3D()
                {
                    Geometry = CubeSide5,
                    Material = DefaultMaterial
                }
            });

            CubeModel.Children.Add(new ModelVisual3D()
            {
                Content = new GeometryModel3D()
                {
                    Geometry = CubeSide6,
                    Material = DefaultMaterial
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
            });

            CubeAnim.Children.Add(new TranslateTransform3D()
            {
                OffsetX = 0,
                OffsetY = 0,
                OffsetZ = 0
            });

            CubeModel.Transform = CubeAnim;


            this.Children.Add(CubeModel);
        }
       
        private void CreateRotateUtil()
        {
            RotateUtil util = new RotateUtil(Platform);
            this.Camera.Transform = util.TransformSource;
        }
    }
}
