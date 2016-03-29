using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Media3D;

namespace CubePlayerTest
{
    public class RotateUtil
    {
        #region Params
        private FrameworkElement Event;
        private Point Position2D;
        private Vector3D Position3D = new Vector3D(0, 0, 1);

        private Transform3DGroup Transform;
        private ScaleTransform3D Scale = new ScaleTransform3D();
        private AxisAngleRotation3D Rotation = new AxisAngleRotation3D();
        #endregion

        public RotateUtil(FrameworkElement element)
        {
            Transform = new Transform3DGroup();
            Transform.Children.Add(Scale);
            Transform.Children.Add(new RotateTransform3D(Rotation));
            SetEventSource(element);
        }

        public Transform3D TransformSource { get { return Transform; } }
        
        private void SetEventSource(FrameworkElement element)
        {
            Event = element;

            Event.MouseDown += this.onMouseDown;
            Event.MouseUp += this.onMouseUp;
            Event.MouseMove += this.onMouseMove;
        }


        private void onMouseDown(object sender, MouseEventArgs e)
        {
            Mouse.Capture(Event, CaptureMode.Element);
            Position2D = e.GetPosition(Event);
            Position3D = ProjectToTrackball(
                Event.ActualWidth,
                Event.ActualHeight,
                Position2D);
        }

        private void onMouseUp(object sender, MouseEventArgs e)
        {
            Mouse.Capture(Event, CaptureMode.None);
        }

        private void onMouseMove(object sender, MouseEventArgs e)
        {
            Point currentPosition = e.GetPosition(Event);

            if (e.RightButton == MouseButtonState.Pressed)
            {
                Track(currentPosition);
            }

            Position2D = currentPosition;
        }

        private void Track(Point currentPosition)
        {
            try
            {
                Vector3D currentPosition3D = ProjectToTrackball(
                Event.ActualWidth, Event.ActualHeight, currentPosition);

                Vector3D axis = Vector3D.CrossProduct(Position3D, currentPosition3D);
                double angle = Vector3D.AngleBetween(Position3D, currentPosition3D);
                Quaternion delta = new Quaternion(axis, -angle);
                
                AxisAngleRotation3D r = Rotation;
                Quaternion q = new Quaternion(Rotation.Axis, Rotation.Angle);
                
                q *= delta;
                
                Rotation.Axis = q.Axis;
                Rotation.Angle = q.Angle;

                Position3D = currentPosition3D;
            }
            catch
            {

            }
            
        }

        private Vector3D ProjectToTrackball(double width, double height, Point point)
        {
            double x = point.X / (width / 2);  
            double y = point.Y / (height / 2);

            x = x - 1;                          
            y = 1 - y;                         

            double z2 = 1 - x * x - y * y;      
            double z = z2 > 0 ? Math.Sqrt(z2) : 0;

            return new Vector3D(x, y, z);
        }

        private void Zoom(Point currentPosition)
        {
            double yDelta = currentPosition.Y - Position2D.Y;

            double scale = Math.Exp(yDelta / 100);   

            Scale.ScaleX *= scale;
            Scale.ScaleY *= scale;
            Scale.ScaleZ *= scale;
        }
    }
}
