using P2_WPFApplication.Models;
using P2_WPFApplication.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P2_WPFApplication.Controls
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }

        public string ContactName
        {
            get { return contactName.Text; }
            set { contactName.Text = value; }
        }

        private void btnCurrentContact_Click(object sender, RoutedEventArgs e)
        {
            Button btn1 = (Button)sender;
            TextBlock tb = btn1.FindName("contactName") as TextBlock;
            DataContext = new CurrentContactModel();
            CurrentContactViewModel control2 = new CurrentContactViewModel(tb.Text);
            ContactViewModel.control2.Children.Add(control2);
        }
    }
}
