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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using HelpMe;
using MahApps.Metro.Controls.Dialogs;

namespace SampleApp
{
    /// <summary>
    /// Логика взаимодействия для GroupAdd.xaml
    /// </summary>
    public partial class TeacherAdd : MetroWindow
    {
        SchoolEntities2 database = new SchoolEntities2();
        public TeacherAdd()
        {
            InitializeComponent();
            gridType.ItemsSource = database.Teacher.ToList();

        }

        private void btn_Apply_Click(object sender, RoutedEventArgs e)
        {
            string line = txtInput.Text;
            if (line == "")
            {
                MessageBox.Show("Ошибка", "Пустое поле ввода!");
                return;
            }
            if (line.Length < 5)
            {
                MessageBox.Show("Ошибка", "Вы вводите не учителя!");
            }
            else
            {
                try
                {
                    var item = (from q in database.Teacher
                                where q.Fullname == txtInput.Text
                                select q).FirstOrDefault();
                    if (item == null)
                    {
                        Teacher a = new Teacher();
                        a.Fullname = txtInput.Text;
                        database.Teacher.Add(a);
                        database.SaveChanges();
                        gridType.ItemsSource = null;
                        gridType.ItemsSource = database.Teacher.ToList();
                        MessageBox.Show("Успех!", "Сообщение");
                    }
                    else
                    {
                        MessageBox.Show("Такой преподаватель уже есть!", "Ошибка");
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Такая учитель уже есть!");
                }
            }
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            WindowAdd add = new WindowAdd();
            add.Show();
            Close();
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Teacher gr = gridType.SelectedValue as Teacher;
                database.Database.ExecuteSqlCommand("DELETE FROM Teacher WHERE ID=" + gr.ID);
                MessageBox.Show("Сообщение", "Успех!");
                gridType.ItemsSource = null;
                gridType.ItemsSource = database.Teacher.ToList();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Вы не выбрали учителя!");
            }

        }

        private void txtInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char s = Convert.ToChar(e.Text);
            if (!(s < '0' || s > '9')) e.Handled = true;
        }
    }
}
