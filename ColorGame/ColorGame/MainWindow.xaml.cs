using Microsoft.Kinect;
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
using System.Threading;

namespace ColorGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private static String OnRed     = "http://192.168.100.110?ve=1";
        private static String OnGreen   = "http://192.168.100.110?vd=1";
        private static String OnYellow  = "http://192.168.100.110?am=1";
        private static String OffRed    = "http://192.168.100.110?ve=0";
        private static String OffGreen  = "http://192.168.100.110?vd=0";
        private static String OffYellow = "http://192.168.100.110?am=0";

        private static WebBrowser w1;
        private static WebBrowser w2;
        private static WebBrowser w3;

        public MainWindow()
        {
            InitializeComponent();
        }

        /**
         * Gera as frequencias 1 - 50
         */
        public static void geraFrequencia(int level)
        {
            int[] sequency = new int[50]; 
            Random rdn = new Random();
            for (int i = 0; i <= level; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    //1-green 2-yellow 3-red
                    int light = rdn.Next(3) + 1;
                    sequency[i] = light;
                    //System.Console.WriteLine(rdn.Next(3) + 1);
                    /*if(light == 1){
                        
                        onGreen();
                        Thread.Sleep(1000);
                        offGreen();
                        
                    } else if(light == 2){
                        onYellow();
                        Thread.Sleep(1000);
                        offYellow();
                        
                    } else if(light == 3){
                        onRed();
                        Thread.Sleep(1000);
                        offRed();
                    }*/
                }
                Thread.Sleep(10000);
                //System.Console.WriteLine("========");    
            }
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            geraFrequencia( Convert.ToInt32(txt_level.Text) );
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            offAll();
        }


        public void onAll() 
        {
            w1 = new WebBrowser();
            w1.Navigate(OnRed);
            w2 = new WebBrowser();
            w2.Navigate(OnGreen);
            w3 = new WebBrowser();
            w3.Navigate(OnYellow);
            w1 = null;
            w2 = null;
            w3 = null;
        }

        public void offAll()
        {
            w1 = new WebBrowser();
            w1.Navigate(OffRed);
            w2 = new WebBrowser();
            w2.Navigate(OffGreen);
            w3 = new WebBrowser();
            w3.Navigate(OffYellow);
            w1 = null;
            w2 = null;
            w3 = null;
        }

        public static void onGreen()
        {
            w1 = new WebBrowser();
            w1.Navigate( OnGreen );
            w1 = null;
        }

        public static void offGreen()
        {
            w1 = new WebBrowser();
            w1.Navigate( OffGreen );
            w1 = null;
        }

        public static void onYellow()
        {
            w1 = new WebBrowser();
            w1.Navigate(OnYellow);
            w1 = null;
        }

        public static void offYellow()
        {
            w1 = new WebBrowser();
            w1.Navigate(OffYellow);
            w1 = null;
        }

        public static void onRed()
        {
            w1 = new WebBrowser();
            w1.Navigate(OnRed);
            w1 = null;
        }

        public static void offRed()
        {
            w1 = new WebBrowser();
            w1.Navigate(OffRed);
            w1 = null;
        }


    }
}
