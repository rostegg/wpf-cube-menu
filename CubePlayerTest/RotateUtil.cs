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
        private FrameworkElement EventPlatform;
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

            if (EventPlatform != null)
            {
                EventPlatform.MouseDown -= this.onMouseDown;
                EventPlatform.MouseUp -= this.onMouseUp;
                EventPlatform.MouseMove -= this.onMouseMove;
            }

            EventPlatform = element;
            
            EventPlatform.MouseDown += this.onMouseDown;
            EventPlatform.MouseUp += this.onMouseUp;
            EventPlatform.MouseMove += this.onMouseMove;
        }


        private void onMouseDown(object sender, MouseEventArgs e)
        {
            Mouse.Capture(EventPlatform, CaptureMode.Element);
            Position2D = e.GetPosition(EventPlatform);
            Position3D = GetVector3D(
                EventPlatform.ActualWidth,
                EventPlatform.ActualHeight,
                Position2D);
        }

        private void onMouseUp(object sender, MouseEventArgs e)
        {
            Mouse.Capture(EventPlatform, CaptureMode.None);
        }

        private void onMouseMove(object sender, MouseEventArgs e)
        {
            Point currentPosition = e.GetPosition(EventPlatform);

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Track(currentPosition);
            }
            if (e.MiddleButton == MouseButtonState.Pressed)
                Zoom(currentPosition);

            Position2D = currentPosition;
        }

        private void Track(Point currentPosition)
        {
            try
            {
                Vector3D currentPosition3D = GetVector3D(
                EventPlatform.ActualWidth, EventPlatform.ActualHeight, currentPosition);

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

        private Vector3D GetVector3D(double width, double height, Point point)
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
