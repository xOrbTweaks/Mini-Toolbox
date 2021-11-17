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

namespace MegaToolsDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string message = "I do not own any of the applications within this program. Nor do I take responsiblity if anything goes wrong with any of these applications.";
            string title = "Disclaimer!";
            MessageBox.Show(message, title);
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /// autoruns
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/sysinternals/downloads/autoruns");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /// afinity tool
            System.Diagnostics.Process.Start("https://www.techpowerup.com/download/microsoft-interrupt-affinity-tool/");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            /// msi utility
            System.Diagnostics.Process.Start("https://www.mediafire.com/file/ewpy1p0rr132thk/MSI_util_v3.zip/file");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            /// timer resoultion
            System.Diagnostics.Process.Start("https://cms.lucashale.com/timer-resolution/");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            /// activate windows 
            System.Diagnostics.Process.Start("https://github.com/abbodi1406/KMS_VL_ALL_AIO/releases");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            /// cpuz
            System.Diagnostics.Process.Start("https://www.cpuid.com/softwares/cpu-z.html");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            /// gpuz
            System.Diagnostics.Process.Start("https://www.techpowerup.com/gpuz/");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            /// rufas
            System.Diagnostics.Process.Start("https://rufus.ie/en/");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            /// aida64
            System.Diagnostics.Process.Start("https://www.aida64.com/downloads");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            /// linpack extreme
            System.Diagnostics.Process.Start("https://www.techpowerup.com/download/linpack-xtreme/");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            /// tm5
            System.Diagnostics.Process.Start("https://mega.nz/file/vLhxBahB#WwJIpN3mQOaq_XsJUboSIcaMg3RlVBWvFnVspgJpcLY");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            /// occt
            System.Diagnostics.Process.Start("https://www.ocbase.com/");
        }
    }
}
