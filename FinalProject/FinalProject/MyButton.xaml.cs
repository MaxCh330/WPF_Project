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

namespace FinalProject
{
    /// <summary>
    /// MyButton.xaml 的互動邏輯
    /// </summary>
    public partial class MyButton : UserControl
    {
        public MyButton()
        {
            InitializeComponent();
        }


        private void MyButton1_MouseEnter(object sender, MouseEventArgs e)
        {
            MyButtonBackground.Background = Brushes.White;
            MyButtonText.Foreground = Brushes.Black;
        }

        private void MyButton1_MouseLeave(object sender, MouseEventArgs e)
        {
            MyButtonBackground.Background = Brushes.Coral;
            MyButtonText.Foreground = Brushes.White;
        }
        public string ButtonText
        {
            get
            {
                return MyButtonText.Text;
            }
            set
            {
                MyButtonText.Text = value;
            }
        }
    }
}
