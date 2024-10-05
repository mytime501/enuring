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
    /// AcutionPage2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AuctionPage2 : Page
    {
        public AuctionPage2()
        {

            InitializeComponent();
            ProductExplain.Text = "물품 설명: " + Model.DBdata.db[1, 4];
            ProductPrice.Text = Model.DBdata.db[1, 2];
            Endtime.Text = Model.DBdata.db[1, 3];
            ProductQuality.Text = Model.DBdata.db[1, 5];
            ProductOpen.Text = Model.DBdata.db[1, 6];
            ProductDeal.Text = Model.DBdata.db[1, 7];
        }

        private void price_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
