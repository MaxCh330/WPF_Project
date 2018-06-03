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
    /// Memo.xaml 的互動邏輯
    /// </summary>
    public partial class Memo : UserControl
    {
        public Memo()
        {
            InitializeComponent();
        }

        private void CheckArea_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (CheckShow.Visibility == Visibility.Hidden)
            {
                CheckShow.Visibility = Visibility.Visible;
            }
            else
            {
                CheckShow.Visibility = Visibility.Hidden;
            }
        }
        public bool isChecked
        {
            get
            {
                if (CheckShow.Visibility == Visibility.Hidden)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            set
            {
                if (value)
                {
                    CheckShow.Visibility = Visibility.Visible;
                }
                else
                {
                    CheckShow.Visibility = Visibility.Hidden;
                }
            }
        }

        // 自訂刪除事件
        public event EventHandler DeleteItem;
        
        // 項目名稱鍵盤按下事件
        private void MenoContext_PreviewKeyDown(object sender, KeyEventArgs e)
        {
           // 任務空白，而且按下 Backspace 鍵時，引發 DeleteItem 事件
           if (MenoContext.Text == ""&& e.Key == Key.Back)
           {
                DeleteItem(this, null);
           }
        }  
    }
}
