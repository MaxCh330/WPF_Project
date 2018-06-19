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
            // 新增一個串列裝每個項目轉成的文字
            List<string> datas = new List<string>();
            // 轉換每一個項目
            foreach (Memo memo in MemoList.Children)
            {
                string line = "";
                // 加入是否勾選的符號
                if (memo.isChecked == true)
                {
                    line += "+";
                }
                else
                {
                    line += "-";
                }
                // 加上|符號和項目文字
                line += "|" + memo.MenoContext.Text;
                // 加入串列中
                datas.Add(line);
            }
            // 存檔
            System.IO.File.WriteAllLines(@"C:\Users\asdfg\Desktop\finalProject\SaveData", datas);
            MemoMenu.Visibility = Visibility.Hidden;
        }

        private void TargetOK_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TargetMenu.Visibility = Visibility.Hidden;
        }

        private void RemindButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RemindMenu.Visibility = Visibility.Visible;
        }

        private void RemindOKBTN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RemindMenu.Visibility = Visibility.Hidden;
        }

        private void MyselfOK_01_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int x = int.Parse(MoneyRemain.Text);
            int y = int.Parse(DaysRemain.Text);
            if (y == 0)
            {
                y = 1;
            }
            MoneyCanUse.Text = (x / y).ToString();
            MyselfMenu01.Visibility = Visibility.Hidden;
        }

        private void EnterMyselfButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (targetchooseList.targetchoose == true)
            {
                MyselfMenu02.Visibility = Visibility.Visible;
            }
            else
            {
                MyselfMenu01.Visibility = Visibility.Visible;
            }
        }

        private void MyselfOK_02_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int x = int.Parse(MoneyGainPM.Text);
            int y = int.Parse(TargetMenoy.Text);

            MoneyCanUse.Text = ((x - y) / 30).ToString();

            MyselfMenu02.Visibility = Visibility.Hidden;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // 開檔
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\asdfg\Desktop\finalProject\SaveData");
            // 分析每一行
            foreach (string line in lines)
            {
                // 用 | 符號拆開
                string[] parts = line.Split('|');
                // 建立 TodoItem
                Memo memo = new Memo();
                memo.MenoContext.Text = parts[1];
                memo.DeleteItem += new EventHandler(DeleteItem);
                // 是否勾選
                if (parts[0] == "+")
                {
                    memo.isChecked = true;
                }
                else
                {
                    memo.isChecked = true;
                }
               // 放到清單中
               MemoList.Children.Add(memo);
            }
        }
    }
}
