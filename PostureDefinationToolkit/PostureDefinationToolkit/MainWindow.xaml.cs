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


namespace PostureDefinationToolkit
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        bool isDragDropInEffect = false;
        Point pos = new Point();

        private PuppetBodyData pbd = new PuppetBodyData(300);

        private UIElement hipCenter;
        private UIElement spine;
        private UIElement shoulderCenter;

        private UIElement head;

        private UIElement shoulderLeft;
        private UIElement elbowLeft;
        private UIElement wristLeft;
        private UIElement hipLeft;
        private UIElement kneeLeft;
        private UIElement angleLeft;
        private UIElement footLeft;

        private UIElement shoulderRight;
        private UIElement elbowRight;
        private UIElement wristRight;
        private UIElement hipRight;
        private UIElement kneeRight;
        private UIElement angleRight;
        private UIElement footRight;

        private TextBox Num1;
        private TextBox Num2;
        private TextBlock Num3;

        private const int lineNumber = 64;

        public MainWindow()
        {


            InitializeComponent();
            Layout.DataContext = pbd;
            //固定不变的点
            hipCenter = HipCenter;
            spine = Spine;
            shoulderCenter = ShoulderCenter;
            //变化的点
            head = Head;
            shoulderLeft = ShoulderLeft;
            elbowLeft = ElbowLeft;
            wristLeft = WristLeft;
            kneeLeft = KneeLeft;
            angleLeft = AngleLeft;
            footLeft = FootLeft;

            shoulderRight = ShoulderRight;
            elbowRight = ElbowRight;
            wristRight = WristRight;
            hipRight = HipRight;
            kneeRight = KneeRight;
            angleRight = AngleRight;
            footRight = FootRight;

            Num1 = num1;
            Num2 = num2;
            Num3 = num3;


            elbowRight.MouseMove += new MouseEventHandler(Element_MouseMove_ElbowRight);
            wristRight.MouseMove += new MouseEventHandler(Element_MouseMove_WristRight);

            elbowLeft.MouseMove += new MouseEventHandler(Element_MouseMove_ElbowLeft);
            wristLeft.MouseMove += new MouseEventHandler(Element_MouseMove_WristLeft);


            #region

            elbowRight.MouseLeftButtonDown += new MouseButtonEventHandler(Element_MouseLeftButtonDown);
            elbowRight.MouseLeftButtonUp += new MouseButtonEventHandler(Element_MouseLeftButtonUp);

            wristRight.MouseLeftButtonDown += new MouseButtonEventHandler(Element_MouseLeftButtonDown);
            wristRight.MouseLeftButtonUp += new MouseButtonEventHandler(Element_MouseLeftButtonUp);

            elbowLeft.MouseLeftButtonDown += new MouseButtonEventHandler(Element_MouseLeftButtonDown);
            elbowLeft.MouseLeftButtonUp += new MouseButtonEventHandler(Element_MouseLeftButtonUp);

            wristLeft.MouseLeftButtonDown += new MouseButtonEventHandler(Element_MouseLeftButtonDown);
            wristLeft.MouseLeftButtonUp += new MouseButtonEventHandler(Element_MouseLeftButtonUp);

            #endregion


        }





        #region



        void Element_MouseMove_ElbowRight(object sender, MouseEventArgs e)
        {
            if (isDragDropInEffect)
            {
                FrameworkElement currEle = sender as FrameworkElement;
                double xBefore = (double)currEle.GetValue(Canvas.LeftProperty);
                double yBefore = (double)currEle.GetValue(Canvas.TopProperty);
                double xNow = e.GetPosition(null).X - pos.X + xBefore;
                double yNow = e.GetPosition(null).Y - pos.Y + yBefore;
                double xLimit = (double)shoulderRight.GetValue(Canvas.LeftProperty);
                double yLimit = (double)shoulderRight.GetValue(Canvas.TopProperty);
                double distance = PointDistance(xLimit, yLimit, xNow, yNow);
                double limitDistance = double.Parse(pbd.ElbowRightY) - double.Parse(pbd.ShoulderRightY);
                double xNew;
                double yNew;

                xNew = xLimit + (xNow - xLimit) * limitDistance / distance;
                yNew = yLimit + (yNow - yLimit) * limitDistance / distance;

                currEle.SetValue(Canvas.LeftProperty, xNew);
                currEle.SetValue(Canvas.TopProperty, yNew);
                wristRight.SetValue(Canvas.LeftProperty, (double)wristRight.GetValue(Canvas.LeftProperty) + xNew - xBefore);
                wristRight.SetValue(Canvas.TopProperty, (double)wristRight.GetValue(Canvas.TopProperty) + yNew - yBefore);
                pos = e.GetPosition(null);
            }
        }

        void Element_MouseMove_WristRight(object sender, MouseEventArgs e)
        {
            if (isDragDropInEffect)
            {
                FrameworkElement currEle = sender as FrameworkElement;
                double xBefore = (double)currEle.GetValue(Canvas.LeftProperty);
                double yBefore = (double)currEle.GetValue(Canvas.TopProperty);
                double xNow = e.GetPosition(null).X - pos.X + xBefore;
                double yNow = e.GetPosition(null).Y - pos.Y + yBefore;
                double xLimit = (double)ElbowRight.GetValue(Canvas.LeftProperty);
                double yLimit = (double)ElbowRight.GetValue(Canvas.TopProperty);
                double distance = PointDistance(xLimit, yLimit, xNow, yNow);
                double limitDistance = double.Parse(pbd.WristRightY) - double.Parse(pbd.ElbowRightY);
                double xNew;
                double yNew;
              

                xNew = xLimit + (xNow - xLimit) * limitDistance / distance;
                yNew = yLimit + (yNow - yLimit) * limitDistance / distance;
  
                currEle.SetValue(Canvas.LeftProperty, xNew);
                currEle.SetValue(Canvas.TopProperty, yNew);
                pos = e.GetPosition(null);
            }
        }

        void Element_MouseMove_ElbowLeft(object sender, MouseEventArgs e)
        {
            if (isDragDropInEffect)
            {
                FrameworkElement currEle = sender as FrameworkElement;
                double xBefore = (double)currEle.GetValue(Canvas.LeftProperty);
                double yBefore = (double)currEle.GetValue(Canvas.TopProperty);
                double xNow = e.GetPosition(null).X - pos.X + xBefore;
                double yNow = e.GetPosition(null).Y - pos.Y + yBefore;
                double xLimit = (double)shoulderLeft.GetValue(Canvas.LeftProperty);
                double yLimit = (double)shoulderLeft.GetValue(Canvas.TopProperty);
                double distance = PointDistance(xLimit, yLimit, xNow, yNow);
                double limitDistance = double.Parse(pbd.ElbowLeftY) - double.Parse(pbd.ShoulderLeftY);
                double xNew;
                double yNew;
                
                xNew = xLimit + (xNow - xLimit) * limitDistance / distance;
                yNew = yLimit + (yNow - yLimit) * limitDistance / distance;

                
                currEle.SetValue(Canvas.LeftProperty, xNew);
                currEle.SetValue(Canvas.TopProperty, yNew);
                wristLeft.SetValue(Canvas.LeftProperty, (double)wristLeft.GetValue(Canvas.LeftProperty) + xNew - xBefore);
                wristLeft.SetValue(Canvas.TopProperty, (double)wristLeft.GetValue(Canvas.TopProperty) + yNew - yBefore);
                pos = e.GetPosition(null);
            }
        }

        void Element_MouseMove_WristLeft(object sender, MouseEventArgs e)
        {
            if (isDragDropInEffect)
            {
                FrameworkElement currEle = sender as FrameworkElement;
                double xBefore = (double)currEle.GetValue(Canvas.LeftProperty);
                double yBefore = (double)currEle.GetValue(Canvas.TopProperty);
                double xNow = e.GetPosition(null).X - pos.X + xBefore;
                double yNow = e.GetPosition(null).Y - pos.Y + yBefore;
                double xLimit = (double)ElbowLeft.GetValue(Canvas.LeftProperty);
                double yLimit = (double)ElbowLeft.GetValue(Canvas.TopProperty);
                double distance = PointDistance(xLimit, yLimit, xNow, yNow);
                double limitDistance = double.Parse(pbd.WristLeftY) - double.Parse(pbd.ElbowLeftY);
                double xNew;
                double yNew;
                
                xNew = xLimit + (xNow - xLimit) * limitDistance / distance;
                yNew = yLimit + (yNow - yLimit) * limitDistance / distance;

                currEle.SetValue(Canvas.LeftProperty, xNew);
                currEle.SetValue(Canvas.TopProperty, yNew);
                pos = e.GetPosition(null);
            }
        }

        void Element_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            FrameworkElement fEle = sender as FrameworkElement;
            isDragDropInEffect = true;
            pos = e.GetPosition(null);
            fEle.CaptureMouse();
            fEle.Cursor = Cursors.Hand;
        }

        void Element_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (isDragDropInEffect)
            {
                FrameworkElement ele = sender as FrameworkElement;
                isDragDropInEffect = false;
                ele.ReleaseMouseCapture();
            }
        }


        double PointDistance(double x1, double y1, double x2, double y2)
        {
            return System.Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float[] code = new float[8];
            double wristLeftX = (double)WristLeft.GetValue(Canvas.LeftProperty);
            double wristLeftY = (double)WristLeft.GetValue(Canvas.TopProperty);

            double wristRightX = (double)WristRight.GetValue(Canvas.LeftProperty);
            double wristRightY = (double)WristRight.GetValue(Canvas.TopProperty);

            double elbowLeftX = (double)ElbowLeft.GetValue(Canvas.LeftProperty);
            double elbowLeftY = (double)ElbowLeft.GetValue(Canvas.TopProperty);

            double elbowRightX = (double)ElbowRight.GetValue(Canvas.LeftProperty);
            double elbowRightY = (double)ElbowRight.GetValue(Canvas.TopProperty);

            double shoulderLeftX = (double)ShoulderLeft.GetValue(Canvas.LeftProperty);
            double shoulderLeftY = (double)ShoulderLeft.GetValue(Canvas.TopProperty);

            double shoulderRightX = (double)ShoulderRight.GetValue(Canvas.LeftProperty);
            double shoulderRightY = (double)ShoulderRight.GetValue(Canvas.TopProperty);


            wristLeftX -= shoulderLeftX;
            wristLeftY = shoulderLeftY - wristLeftY;

            wristRightX -= shoulderRightX;
            wristRightY = shoulderRightY - wristRightY;

            elbowLeftX -= shoulderLeftX;
            elbowLeftY = shoulderLeftY - elbowLeftY;

            elbowRightX -= shoulderRightX;
            elbowRightY = shoulderRightY - elbowRightY;

            double dis1 = getDistance(0, 0, elbowLeftX, elbowLeftY);
            double dis2 = getDistance(0, 0, elbowRightX, elbowRightY);
            code[0] = (float)(wristLeftX / dis1);
            code[1] = (float)(wristLeftY / dis1);
            code[2] = (float)(wristRightX / dis2);
            code[3] = (float)(wristRightY / dis2);
            code[4] = (float)(elbowLeftX / dis1);
            code[5] = (float)(elbowLeftY / dis1);
            code[6] = (float)(elbowRightX / dis2);
            code[7] = (float)(elbowRightY / dis2);

            String temp = "";
            for (int i = 0; i < 8; i++)
            {
                temp += code[i].ToString();
                temp += " ";
            }


            Num1.Text = temp;;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string numOne = Num1.Text;
            string numTwo = Num2.Text;

            int[] diff = new int[40];
            double result = 0;

            for (int i = 0; i <= 39; i++)
            {
                string s1 = numOne.Substring(i, 1);
                string s2 = numTwo.Substring(i, 1);
                diff[i] = StringIntegerConverter.convertToInteger(s1) - StringIntegerConverter.convertToInteger(s2);
            }

            for (int i = 0; i <= 9; i++)
            {
                result += Math.Sqrt(diff[2 * i] * diff[2 * i] + diff[2 * i + 1] * diff[2 * i + 1]);
            }

            Num3.Text = result.ToString();

        }

        private double getDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }
    }
}