using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
using ZodiacSign.Classes;

namespace ZodiacSign.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageZnak.xaml
    /// </summary>
    public partial class PageZnak : Page
    {
        public PageZnak()
        {
            InitializeComponent();
            //привязка таблицы            
            DgZnak.ItemsSource = znak_dbEntities.GetContext().zodiacSign.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            ConnectHelper.frmObj.Navigate(new PageAdd(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var usersForRemoving = DgZnak.SelectedItems.Cast<zodiacSign>().ToList();
            if (MessageBox.Show($"Удалить {usersForRemoving.Count()} запись?", "Внимание!",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                try
                {
                    znak_dbEntities.GetContext().zodiacSign.RemoveRange(usersForRemoving);
                    znak_dbEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            DgZnak.ItemsSource = znak_dbEntities.GetContext().zodiacSign.ToList();
        }

        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = TxbSearch.Text;
            if (TxbSearch.Text != null)
            {
                DgZnak.ItemsSource = znak_dbEntities.GetContext().zodiacSign.
                    Where(x => x.birthdate?.ToString("MMMM").Contains(search)).ToList();
            }
        }
    }
}
