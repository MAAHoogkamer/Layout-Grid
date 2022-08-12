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
using System.Windows.Shapes;

namespace WPF_Uebung
{
    public partial class LayoutCon : Window
    {
        public LayoutCon()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Using RoutedEventArgs.Source property to get a originator of event
            // e can then be used as such: 
            Button? b = e.Source as Button;
            switch (b?.Content)
            {
                case "Calculator":
                    // Add try & catch to catch and show the exception in case of error
                    try
                    {
                        System.Diagnostics.Process.Start("calc.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "Notepad":
                    try
                    {
                        System.Diagnostics.Process.Start("Notepad.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "Webbrowser":
                    try
                    {
                        System.Diagnostics.Process.Start("explorer.exe", "https://citoc.dscloud.biz");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "Remote":
                    try
                    {
                        System.Diagnostics.Process.Start("mstsc.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }
    }
}
