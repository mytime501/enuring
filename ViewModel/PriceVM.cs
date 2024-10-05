using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 에누링.ViewModel.Command;

namespace 에누링.ViewModel
{
    public class PriceVM
    {
        public ObservableCollection<int> Price { get; set; }
        public PriceCommand PriceCommand { get; set; }
        public PriceVM()
        {
            Price = new ObservableCollection<int>();
            PriceCommand = new PriceCommand(this);
        }
       
    }
}
