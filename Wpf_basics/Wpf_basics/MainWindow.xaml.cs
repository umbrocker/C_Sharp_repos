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

namespace Wpf_basics
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

        private void ApplyBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is: {this.DescriptionTxtBox.Text}");
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WeldChbx.IsChecked = this.AssemblyChbx.IsChecked = this.PlasmaChbx.IsChecked = this.LaserChbx.IsChecked = this.LatheChbx.IsChecked = this.FoldChbx.IsChecked = 
                this.PurchaseChbx.IsChecked = this.RollChbx.IsChecked = this.DrillChbx.IsChecked = this.SawChbx.IsChecked = false;
        }

        private void Checkbox_checked(object sender, RoutedEventArgs e)
        {
            this.LengthTextbox.Text += ((CheckBox)sender).Content;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteTxtbx == null)
                return;
            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;
            this.NoteTxtbx.Text = (string)value.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox_SelectionChanged(this.FinishDropdown, null);
        }

        private void SupplierNameTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.MassTxtBx.Text = this.SupplierNameTxt.Text;
        }
    }
}
