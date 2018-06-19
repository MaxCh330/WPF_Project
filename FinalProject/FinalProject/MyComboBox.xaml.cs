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
    /// MyComboBox.xaml 的互動邏輯
    /// </summary>
    public partial class MyComboBox : UserControl
    {
        public MyComboBox()
        {
            InitializeComponent();
        }

        private void OptionOpen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Option1.Visibility == Visibility.Hidden)
            {
                Option1.Visibility = Visibility.Visible;
                Option2.Visibility = Visibility.Visible;
               
            }
            else
            {
                Option1.Visibility = Visibility.Hidden;
                Option2.Visibility = Visibility.Hidden;
                
            }
        }

        private void Option1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OptionOpen.ComboBoxOptionTextValue = Option1.ComboBoxOptionTextValue ;
            Option1.Visibility = Visibility.Hidden;
            Option2.Visibility = Visibility.Hidden;
        
        }

        private void Option2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OptionOpen.ComboBoxOptionTextValue = Option2.ComboBoxOptionTextValue;
            Option1.Visibility = Visibility.Hidden;
            Option2.Visibility = Visibility.Hidden;
           
        }
        public bool targetchoose
        {
            get
            {
                if (OptionOpen.ComboBoxOptionTextValue == Option2.ComboBoxOptionTextValue)
                {
                    return false;
                }
                else if (OptionOpen.ComboBoxOptionTextValue == Option1.ComboBoxOptionTextValue)
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
