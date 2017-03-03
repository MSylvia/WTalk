﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WTalk.Desktop.Resources
{
    public partial class WTalkStyle
    {
        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {            
            System.Windows.Window window = ((System.Windows.Controls.Grid)sender).TemplatedParent as System.Windows.Window;
            window.DragMove();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.Window window = ((System.Windows.Controls.Button)sender).TemplatedParent as System.Windows.Window;

            if (window is MainWindow)
            {
                if (((WTalk.Desktop.ViewModel.MainViewModel)window.DataContext).AuthenticationRequired)
                    App.Current.Shutdown();
                else
                    window.WindowState = System.Windows.WindowState.Minimized;
            }
            else
                window.Hide();
        }
    }
}
