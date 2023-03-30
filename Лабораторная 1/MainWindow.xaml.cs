using System.Windows;
using System.Windows.Controls;
using Лабораторная_1.Lab1DataSetTableAdapters;

namespace Лабораторная_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        guildTableAdapter guild = new guildTableAdapter();
        employeeTableAdapter employee = new employeeTableAdapter();
        detailsTableAdapter detail = new detailsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();

            GuildDataGrid.ItemsSource = guild.GetData();
            EmployeeDataGrid.ItemsSource = employee.GetData();
            DetailDataGrid.ItemsSource = detail.GetData();

        }

        private void GuildDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "guild_id":
                    e.Column = null;
                    break;
                case "guild_name":
                    e.Column.Header = "Название";
                    break;
                case "area_number":
                    e.Column.Header = "Номер участка";
                    break;
                default:
                    break;
            }
        }

        private void EmployeeDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "employee_id":
                    e.Column = null;
                    break;
                case "guild_id":
                    e.Column.Header = "Цех";
                    break;
                case "second_name":
                    e.Column.Header = "Фамилия";
                    break;
                case "first_name":
                    e.Column.Header = "Имя";
                    break;
                case "patronymic":
                    e.Column.Header = "Отчество";
                    break;
                case "passport_inf":
                    e.Column.Header = "Паспорт";
                    break;
                case "phone_number":
                    e.Column.Header = "Номер телефона";
                    break;
                case "something":
                    e.Column.Header = "Что-то";
                    break;
                default:
                    break;
            }
        }

        private void DetailDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {

            switch (e.PropertyName)
            {
                case "detail_id":
                    e.Column = null;
                    break;
                case "guild_id":
                    e.Column.Header = "Цех";
                    break;
                case "detail_name":
                    e.Column.Header = "Название";
                    break;
                case "size":
                    e.Column.Header = "Размер";
                    break;
                case "amount":
                    e.Column.Header = "Количество";
                    break;
                case "raw_material_id":
                    e.Column = null;
                    break;
                default:
                    break;
            }
        }
    }
}
