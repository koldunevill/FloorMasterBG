using System;
using System.Data.Entity.Validation;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace FloopMasterBG
{
    public partial class AddEdirPathers : Page
    {
        private Pathers _pathers;

        public AddEdirPathers(Pathers pathers)
        {
            InitializeComponent();
            _pathers = pathers ?? new Pathers();

            if (_pathers != null)
            {
                TypePathers.SelectedIndex = _pathers.TypeID - 1;
            }
            DataContext = _pathers;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            string errorMessages = string.Empty;

            // Проверка наименования компании
            if (string.IsNullOrWhiteSpace(NameTB.Text))
            {
                errorMessages += "Введите наименование компании.\n";
            }

            // Проверка типа компании
            if (TypePathers.SelectedIndex < 0)
            {
                errorMessages += "Выберите тип компании.\n";
            }

            // Проверка рейтинга
            if (string.IsNullOrWhiteSpace(RankTB.Text) || !int.TryParse(RankTB.Text, out int rating))
            {
                errorMessages += "Введите корректный рейтинг (целое число).\n";
            }

            // Проверка email
            if (string.IsNullOrWhiteSpace(EmailTb.Text) || !IsValidEmail(EmailTb.Text))
            {
                errorMessages += "Введите корректный email.\n";
            }

            // Проверка телефона
            if (string.IsNullOrWhiteSpace(PhoneTB.Text) || !IsValidPhoneNumber(PhoneTB.Text))
            {
                errorMessages += "Введите корректный номер телефона.\n";
            }

            if (string.IsNullOrWhiteSpace(INN.Text) || !IsValidINN(INN.Text))
            {
                errorMessages += "Введите корректный ИНН.\n";
            }

            // Если есть ошибки, выводим их
            if (!string.IsNullOrEmpty(errorMessages))
            {
                MessageBox.Show(errorMessages, "Ошибки ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Присвоение значений свойствам
            _pathers.NameCompany = NameTB.Text;
            _pathers.TypeID = TypePathers.SelectedIndex + 1;
            _pathers.Rating = int.Parse(RankTB.Text);
            _pathers.SurnameDirector = FioTB.Text;
            _pathers.NameDirector = NameDirectorTB.Text;
            _pathers.PatronomycDirector = PatronomycTB.Text;
            _pathers.Legacy_Adress = AdresTb.Text;
            _pathers.Email = EmailTb.Text;
            _pathers.Phone = PhoneTB.Text;
            _pathers.INN = INN.Text;



            if (_pathers.ID == 0)
            {
                FloopMasterEntities.GetContext().Pathers.Add(_pathers);
            }
            try
            {
                FloopMasterEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                manager.MainFrame.GoBack();
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder validationErrors = new StringBuilder("Ошибка сохранения данных:\n");
                foreach (var entityError in ex.EntityValidationErrors)
                {
                    foreach (var error in entityError.ValidationErrors)
                    {
                        validationErrors.AppendLine($"Сущность: {entityError.Entry.Entity.GetType().Name}, Свойство: {error.PropertyName}, Ошибка: {error.ErrorMessage}");
                    }
                }
                MessageBox.Show(validationErrors.ToString(), "Ошибки валидации", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool IsValidPhoneNumber(string phone)
        {
            return Regex.IsMatch(phone, @"^\+?\d{10,13}$");
        }
        private bool IsValidINN(string Inn)
        {
            return Regex.IsMatch(Inn, @"\d{10}");
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            manager.MainFrame.GoBack();
        }
    }
}
