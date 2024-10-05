using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
using Microsoft.Win32;

namespace 에누링.View
{
    /// <summary>
    /// Page1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page1 : Page
    {
        public static string quality = "";
        public static string open = "";
        public static string deal = "";
        public Page1()
        {
            InitializeComponent();
        }

        DataSet ds;
        string strName, imageName;
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (((RadioButton)sender).IsChecked == true)
            {
                quality = "상";  
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (((RadioButton)sender).IsChecked == true)
            {
                quality = "중";
            }
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            if (((RadioButton)sender).IsChecked == true)
            {
                quality = "하";
            }
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            if (((RadioButton)sender).IsChecked == true)
            {
                open = "개봉";
            }
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            if (((RadioButton)sender).IsChecked == true)
            {
                open = "미개봉";
            }
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            if (((RadioButton)sender).IsChecked == true)
            {
                deal = "택배";
            }
        }

        private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {
            if (((RadioButton)sender).IsChecked == true)
            {
                deal = "직거래";
            }
        }
        

    }
}
