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

namespace 에누링.View
{
    /// <summary>
    /// AuctionPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AuctionPage : Page
    {
        public AuctionPage()
        {

            InitializeComponent();
            ProductExplain.Text = "물품 설명: " + Model.DBdata.db[0, 4];
            ProductPrice.Text = Model.DBdata.db[0, 2];
            Endtime.Text = Model.DBdata.db[0, 3];
            ProductQuality.Text = Model.DBdata.db[0, 5];
            ProductOpen.Text = Model.DBdata.db[0, 6];
            ProductDeal.Text = Model.DBdata.db[0, 7];
            DealPlace.Text = Model.DBdata.db[0, 8];
        }
    }
}
