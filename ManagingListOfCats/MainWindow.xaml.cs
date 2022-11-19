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

namespace ManagingListOfCats
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Style _borderOpen;
        private Style _border;
        private Style _buttonOpen;
        private Style _button;
        public MainWindow()
        {
            InitializeComponent();
            _border = this.FindResource("ButtonBorder") as Style;
            _borderOpen = this.FindResource("ButtonBorderOpen") as Style;
            _button = this.FindResource("NavButton") as Style;
            _buttonOpen = this.FindResource("NavButtonOpen") as Style;
        }

        private void changeAllButtonToDefault()
        {
            allcatsborder.Style = _border;
            allcats.Style = _button;
            naispitatelnomborder.Style = _border;
            NaIspitatelnom.Style = _button;
            koshkivpriyuteborder.Style = _border;
            KoshkiVpriyute.Style = _button;
            zapasiborder.Style = _border;
            Zapasi.Style = _button;
        }
        
        private void Allcats_OnClick(object sender, RoutedEventArgs e)
        {
            changeAllButtonToDefault();
            allcatsborder.Style = _borderOpen;
            allcats.Style = _buttonOpen;
        }

        private void NaIspitatelnom_OnClick(object sender, RoutedEventArgs e)
        {
            changeAllButtonToDefault();
            naispitatelnomborder.Style = _borderOpen;
            NaIspitatelnom.Style = _buttonOpen;
        }

        private void KoshkiVpriyute_OnClick(object sender, RoutedEventArgs e)
        {
            changeAllButtonToDefault();
            koshkivpriyuteborder.Style = _borderOpen;
            KoshkiVpriyute.Style = _buttonOpen;
        }

        private void Zapasi_OnClick(object sender, RoutedEventArgs e)
        {
            changeAllButtonToDefault();
            zapasiborder.Style = _borderOpen;
            Zapasi.Style = _buttonOpen;
        }
    }
}