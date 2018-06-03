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
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        //移動視窗
        private void GridBase_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        //關閉程式
        private void CloseButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void EnterTargetButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TargetMenu.Visibility = Visibility.Visible;
        }

        private void TargetMenuClose_Click(object sender, RoutedEventArgs e)
        {
            TargetMenu.Visibility = Visibility.Hidden;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Memo memo = new Memo();
            memo.DeleteItem += new EventHandler(DeleteItem);

            MemoList.Children.Add(memo);
        }

        // 刪除事件
        private void DeleteItem (object sender, EventArgs e)
        {
            MemoList.Children.Remove((Memo)sender);
        }

        private void EnterMenoButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MemoMenu.Visibility = Visibility.Visible;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            MemoMenu.Visibility = Visibility.Hidden;
        }

        private void TargetOK_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TargetMenu.Visibility = Visibility.Hidden;
        }
    }
}
