using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows ;
using System.Windows.Controls;
using System.Windows.Input;

namespace 에누링.ViewModel.Command
{
    public class PriceCommand : ICommand
    {
        public PriceVM VM { get; set; }

        public PriceCommand(PriceVM priceVM)
        {
            VM = priceVM;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public static string pricenow = "";

        public void Execute(object parameter)
        {
            TextBox txtbox = parameter as TextBox;
            int price1 = Convert.ToInt32(txtbox.Text);

            if (txtbox.Text != null)
            {
                if (VM.Price.Count == 0)
                {
                    VM.Price.Insert(0, price1);
                    pricenow = price1.ToString();
                    MessageBox.Show("입찰이 완료되었습니다");
                }
                else
                {
                    if (price1 > VM.Price[0])
                    {
                        VM.Price.Insert(0, price1);
                        pricenow = price1.ToString();
                        MessageBox.Show("입찰이 완료되었습니다");
                    }

                    else if (price1 < VM.Price[0])
                    {
                        MessageBox.Show("현재 입찰가보다 낮은 가격입니다!! 다시입력해주세요");
                    }
                    else
                    {
                        MessageBox.Show("현재 입찰가와 동일한 값입니다!! 다시 입력해주세요");
                     }
                }

            }

        }


        public bool CanExecute(object parameter)
        {
            TextBox txtbox = parameter as TextBox;
            try
            {
                int price = Convert.ToInt32(txtbox.Text);
                if (price != 0)
                {
                    if (txtbox != null && txtbox.Text.Length > 0)
                    {
                        if (price % 1000 == 0)
                        {
                            return true;

                        }
                        else return false;

                    }
                }
                else return false;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }
    }
}


