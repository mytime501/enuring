using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows;
using 에누링.Model;
using 에누링.ViewModel.Command;

namespace 에누링.ViewModel
{
    public class Kakaovm : ObservableObject
    {
        public IList<MyLocale> MyLocales { get; set; }
        public IRelayCommand SearchCommand { get; set; }
        private string _inputText;
        public string InputText
        {
            get { return _inputText; }
            set { SetProperty(ref _inputText, value); }
        }

        private MyLocale _selectedMyLocale;
        public MyLocale SelectedMyLocale
        {
            get { return _selectedMyLocale; }
            set { SetProperty(ref _selectedMyLocale, value); }
        }

        public Kakaovm()
        {
            MyLocales = new ObservableCollection<MyLocale>();
            SearchCommand = new RelayCommand(OnSearch);
            PropertyChanged += Kakaovm_PropertyChanged;
          
        }


        private void Kakaovm_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(SelectedMyLocale):

                    break;
            }
        }
     

        private void OnSearch()
        {
            MyLocales.Clear();

            string site = "https://dapi.kakao.com/v2/local/search/keyword.json";
            string rquery = string.Format("{0}?query={1}", site, InputText);
            WebRequest request = WebRequest.Create(rquery);
            string rkey = "c27c1882a03c9400f00c15826e86ce9d";
            string header = "KakaoAK " + rkey;
            request.Headers.Add("Authorization", header);

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            String json = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic dob = js.Deserialize<dynamic>(json);
            dynamic docs = dob["documents"];
            object[] buf = docs;

            int length = buf.Length;
            for (int i = 0; i < length; i++)
            {
                string lname = docs[i]["place_name"];
                double x = double.Parse(docs[i]["x"]);
                double y = double.Parse(docs[i]["y"]);
                MyLocales.Add(new MyLocale(lname, y, x));
            }
        }

    }
}

