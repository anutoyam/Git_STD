using HMI_MVVM.Models;
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

namespace HMI_MVVM
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void ButtonTest1_Click(object sender, RoutedEventArgs e)
        {
            List<User> myList1 = new List<User>();
            labelTest1.Content = "내용변경완료";
            checkBoxTest1.IsChecked = !checkBoxTest1.IsChecked;
            //MessageBox.Show(textBoxTest1.Text);
            User userA = new User();
            userA.Name = "Tuna";
            userA.UserAge = 33;
            userA.UserImg = @"C:\Users\MH\Source\Repos\anutoyam\Git_STD\HMI_MVVM\HMI_MVVM\Resources\photo1.jpg";

            User userB = new User();
            userB.Name = "Mayo";
            userB.UserAge = 33;
            userB.UserImg = @"C:\Users\MH\Source\Repos\anutoyam\Git_STD\HMI_MVVM\HMI_MVVM\Resources\photo1.jpg";

            myList1.Add(userA);
            myList1.Add(userB);

            listView1.ItemsSource = myList1;
        }

    }
}
