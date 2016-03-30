using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Media3D;

namespace CubePlayerTest
{
    public class Cube : Viewport3D
    {

        #region CubeSide
        

        
        private MeshGeometry3D CubeSide1 = new MeshGeometry3D();
        private MeshGeometry3D CubeSide2 = new MeshGeometry3D();
        private MeshGeometry3D CubeSide3 = new MeshGeometry3D();
        private MeshGeometry3D CubeSide4 = new MeshGeometry3D();
        private MeshGeometry3D CubeSide5 = new MeshGeometry3D();
        private MeshGeometry3D CubeSide6 = new MeshGeometry3D();

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
                new Point3D(-0.5,0.5,-0.5),
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
                new Point3D(-0.5,-0.5,0.5),
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
                new Point3D(0.5,-0.5,-0.5),
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
                new Point3D(-0.5,-0.5,-0.5),
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
                new Point3D(0.5,0.5,-0.5),
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
     //< MeshGeometry3D x: Key = "CubeSide06"
     // TextureCoordinates = "1,0 1,1 0,1 0,1 0,0 1,0 "
        }



        #endregion

        #region Material
        #endregion

        #region Params
        #endregion
        public Cube(float position)
        {
            SetupeCubeSides();
        }
        

    }
}
