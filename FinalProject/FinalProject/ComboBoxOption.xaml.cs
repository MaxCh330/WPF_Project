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
    /// ComboBoxOption.xaml 的互動邏輯
    /// </summary>
    public partial class ComboBoxOption : UserControl
    {
        public ComboBoxOption()
        {
            InitializeComponent();
        }

        private void ComboBoxOptionArea_MouseEnter(object sender, MouseEventArgs e)
        {
            ComboBoxOptionArea.Background = Brushes.Bisque;
        }

        private void ComboBoxOptionArea_MouseLeave(object sender, MouseEventArgs e)
        {
            ComboBoxOptionArea.Background = Brushes.Coral;
        }
        public string ComboBoxOptionTextValue
        {
            set
            {
                ComboBoxOptionText.Text = value;
            }
            get
            {
                return ComboBoxOptionText.Text;
            }
        }
    }
}
