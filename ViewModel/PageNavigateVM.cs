using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using 에누링.ViewModel.Command;
using 에누링.Model;

namespace 에누링.ViewModel
{
    class PageNavigateVM
    {
        public int currentPage { get; set; }
        public PageNavigateCommand PageNavigateCommand { get; set; }

        List<string> PageNames;
        Frame frame;
        
        

        

        
        // 기본값을 설정해두지 않으면 0001년으로 표시되기 때문에 기본값을 지정해 주어야 합니다.
        private DateTime _selectedDateTime = DateTime.Now;
        public DateTime SelectedDateTime
        {
            get
            {
                return _selectedDateTime;
            }
            set
            {
                _selectedDateTime = value;
                if (value != null)
                {
                    Model.DBdata_insert.date = _selectedDateTime;
                }
                NotifyPropertyChanged(nameof(SelectedDateTime));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string name)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        }
        public PageNavigateVM()
        {
            PageNavigateCommand = new PageNavigateCommand(this);

            PageNames = new List<string>();
            PageNames.Add("View/Login.xaml");
            PageNames.Add("View/Register.xaml");
            PageNames.Add("View/Todo.xaml");
            PageNames.Add("View/Sell.xaml");
            PageNames.Add("View/Buy.xaml");
            PageNames.Add("View/AuctionPage.xaml");
            PageNames.Add("View/AuctionPage2.xaml");

            frame = (Frame)Application.Current.MainWindow.FindName("PageFrame");
        }

        public void NavigateTo(int pageNum)
        {
            currentPage = pageNum;
            frame.NavigationService.Navigate(new Uri(PageNames[currentPage], UriKind.RelativeOrAbsolute));
        }
    }
}

