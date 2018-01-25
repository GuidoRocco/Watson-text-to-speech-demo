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
using System.Net;
using System.IO; 

namespace Speech_To_Text_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void speak_button_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox_tts.Text;
            if (text != "")
            {
                System.Diagnostics.Process.Start("https://xxx.mybluemix.net/tts_visualstudio?text_to_say=" + text);
            }
            else
            {
                MessageBox.Show("Please write a valid text", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            textBox_tts.Text = ""; 
            return; 

        }
    }
}



