using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using 에누링.View;

namespace 에누링.ViewModel.Command
{
    class Selectbutton : ICommand
    {
       
       

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public static string place = "";
        public void Execute(object parameter)
        {
            string str = parameter.ToString();
            kakaomap KM = new kakaomap();

            MessageBoxResult Result = System.Windows.MessageBox.Show(str+" 여기가 맞습니까?","직거래장소선택하기",MessageBoxButton.YesNo, MessageBoxImage.Question);
            place = str;
            if (Result == MessageBoxResult.Yes)
            {
                MessageBoxResult Result1= System.Windows.MessageBox.Show("선택이 완료되었습니다.", "선택", MessageBoxButton.OK, MessageBoxImage.Information);
                
            }
            else if (Result == MessageBoxResult.No)
            {
                System.Windows.MessageBox.Show("다시 선택해주세요", "Result", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }
        }
    }
}
