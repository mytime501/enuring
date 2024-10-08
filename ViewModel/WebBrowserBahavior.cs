﻿using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using 에누링.Model;

namespace 에누링.ViewModel
{
    public class WebBrowserBehavior : Behavior<WebBrowser>
    {
        public MyLocale SelectedMyLocale
        {
            get { return (MyLocale)GetValue(SelectedMyLocaleProperty); }
            set 
            { 
                SetValue(SelectedMyLocaleProperty, value); 
            }
        }


        // Using a DependencyProperty as the backing store for SelectedMyLocale.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedMyLocaleProperty =
            DependencyProperty.Register("SelectedMyLocale", typeof(MyLocale), typeof(WebBrowserBehavior), new PropertyMetadata(null, SelectedMyLocaleChanged));

        private static void SelectedMyLocaleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var behavior = (WebBrowserBehavior)d;
            behavior.ExecuteInvokeScript();
        }

        private void ExecuteInvokeScript()
        {
            if (SelectedMyLocale == null)
            {
                return;
            }

            object[] ps = new object[] { SelectedMyLocale.Lat, SelectedMyLocale.Lng };
            AssociatedObject.InvokeScript("setCenter", ps);

        }
    }
}