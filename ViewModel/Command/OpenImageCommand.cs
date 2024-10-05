using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using 에누링.View;
using 에누링.ViewModel;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Controls;


namespace 에누링.ViewModel.Command
{
    public class OpenImageCommand : ICommand
    {
        Action<object> _executeMethod;

        public OpenImageCommand()
        {

        }

        public OpenImageCommand(Action<object> executeMethod)
        {
            this._executeMethod = executeMethod;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            dialog.DefaultExt = ".jpg";
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.Multiselect = true;
            System.Windows.Controls.Image image = parameter as System.Windows.Controls.Image;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = dialog.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selectedFileName);
                bitmap.EndInit();
                image.Source = bitmap;
            }

        }
    }
 }


