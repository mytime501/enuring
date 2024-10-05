using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

namespace 에누링.View
{
    /// <summary>
    /// Buy.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Buy : Page
    {
        string[,] db = new string[100, 9];
        OleDbDataReader dr;
        OleDbConnection con;
        int i = 0;
        public Buy()
        {
            InitializeComponent();




            Title1.Text = "제목: " + Model.DBdata.db[0, 4];
            Price1.Text = "가격: " + Model.DBdata.db[0, 2];
            Time1.Text = "마감시간: " + Model.DBdata.db[0, 3];
            Title2.Text = "제목: " + Model.DBdata.db[1, 4];
            Price2.Text = "가격: " + Model.DBdata.db[1, 2];
            Time2.Text = "마감시간: " + Model.DBdata.db[1, 3];
            Title3.Text = "제목: " + Model.DBdata.db[2, 4];
            Price3.Text = "가격: " + Model.DBdata.db[2, 2];
            Time3.Text = "마감시간: " + Model.DBdata.db[2, 3];
        }
    }
}
