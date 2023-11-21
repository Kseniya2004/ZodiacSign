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
using ZodiacSign.Classes;

namespace ZodiacSign.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAdd.xaml
    /// </summary>
    public partial class PageAdd : Page
    {
        private zodiacSign _currentSign = new zodiacSign();
        public PageAdd(zodiacSign selectedSign)
        {
            InitializeComponent();
            DataContext = _currentSign;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            
            StringBuilder error = new StringBuilder(); //объект для сообщения об ошибке

            //проверка полей объекта
            if (string.IsNullOrWhiteSpace(_currentSign.surname))
                error.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_currentSign.name))
                error.AppendLine("Укажите имя");
            if (string.IsNullOrWhiteSpace(_currentSign.sign))
                error.AppendLine("Укажите знак зодиака");
            if (string.IsNullOrWhiteSpace(_currentSign.birthdate.ToString()))
                error.AppendLine("Укажите дату рождения");
            // проверка на ввод знака зодиака 
            string input = TbZnak.Text;
            if (input == "Овен") { }
            else if (input == "Телец") { }
            else if (input == "Близнецы") { }
            else if (input == "Рак") { }
            else if (input == "Лев") { }
            else if (input == "Дева") { }
            else if (input == "Весы") { }
            else if (input == "Скорпион") { }
            else if (input == "Стрелец") { }
            else if (input == "Козерог") { }
            else if (input == "Водолей") { }
            else if (input == "Рыбы") { }
            else
                error.AppendLine("Невеный знак зодиака");

            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());
                return;
            }
            //если продукт новый
            if (znak_dbEntities.GetContext().zodiacSign.Find(_currentSign.id) == null)
                znak_dbEntities.GetContext().zodiacSign.Add(_currentSign); //добавить в контекст
            try
            {
                znak_dbEntities.GetContext().SaveChanges(); // сохранить изменения

                MessageBox.Show("Данные сохранены");
                ConnectHelper.frmObj.Navigate(new PageZnak());

            }
            catch (Exception ex)
            {
                MessageBox.Show("При сохранении произошли ошибки");
            }
        }
    }
}
