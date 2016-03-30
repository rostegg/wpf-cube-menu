using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace CubePlayerTest
{
    public class ClickingUtil
    {

        public readonly Viewport3D Figure;

        public Figures State;

        public ClickingUtil (Viewport3D obj, Figures figure)
        {
            Figure = obj;
            State = figure;
        }

        public void ClickFaceEvent(object sender, MouseButtonEventArgs args)
        {
            Point Position = args.GetPosition(Figure);
            PointHitTestParameters PointParams = new PointHitTestParameters(Position);
            VisualTreeHelper.HitTest(Figure, null, HTResult, PointParams);
        }

        private HitTestResultBehavior HTResult(System.Windows.Media.HitTestResult Result)
        {
            RayHitTestResult RayResult = Result as RayHitTestResult;
            if (RayResult != null)
            {
                RayMeshGeometry3DHitTestResult RayMeshResult = RayResult as RayMeshGeometry3DHitTestResult;
                if (RayMeshResult != null)
                {
                    GeometryModel3D Model = RayMeshResult.ModelHit as GeometryModel3D;
                    switch (State)
                    {
                        case Figures.Cube:
                            SetResultCube(Model);
                            break;
                        case Figures.Triangle:
                            SetResultTriangle(Model);
                            break;
                        default:
                            throw new ArgumentNullException();
                    }
                }
            }
            return HitTestResultBehavior.Stop;
        }


        private void SetResultCube(GeometryModel3D model)
        {
            Cube CurrentFigure = Figure as Cube;
            if (model.Geometry == ((Cube)Figure).CubeSide1)
            {
                if (CurrentFigure.Side01Function != null)
                    CurrentFigure.Side01Function();
                else
                    MessageBox.Show("Side 1");
            }
            else if (model.Geometry == ((Cube)Figure).CubeSide2)
            {
                if (CurrentFigure.Side02Function != null)
                    CurrentFigure.Side02Function();
                else
                    MessageBox.Show("Side 2");
            }
            else if (model.Geometry == ((Cube)Figure).CubeSide3)
            {
                if (CurrentFigure.Side03Function != null)
                    CurrentFigure.Side03Function();
                else
                    MessageBox.Show("Side 3");
            }
            else if (model.Geometry == ((Cube)Figure).CubeSide4)
            {
                if (CurrentFigure.Side04Function != null)
                    CurrentFigure.Side04Function();
                else
                    MessageBox.Show("Side 4");
            }
            else if (model.Geometry == ((Cube)Figure).CubeSide5)
            {
                if (CurrentFigure.Side05Function != null)
                    CurrentFigure.Side05Function();
                else
                    MessageBox.Show("Side 5");
            }
            else if (model.Geometry == ((Cube)Figure).CubeSide6)
            {
                if (CurrentFigure.Side06Function != null)
                    CurrentFigure.Side06Function();
                else
                    MessageBox.Show("Side 6");
            }
        }
        private void SetResultTriangle(GeometryModel3D model)
        {

        }
    }
}
