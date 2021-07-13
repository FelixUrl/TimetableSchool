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
    public partial class DisciplineAdd : MetroWindow
    {
        SchoolEntities2 database = new SchoolEntities2();
        public DisciplineAdd()
        {
            InitializeComponent();
            gridType.ItemsSource = database.Discipline.ToList();

        }

        private void btn_Apply_Click(object sender, RoutedEventArgs e)
        {
            string line = txtInput.Text;
            if (line == "" || line == " " || line == "  " || line == "   ")
            {
                MessageBox.Show("Ошибка", "Пустое поле ввода!");
                return;
            }
            if (line.Length < 2)
            {
                MessageBox.Show("Ошибка", "Вы вводите не дисциплину!");
            }
            else
            {
                try
                {
                    var item = (from q in database.Discipline
                                where q.Name == txtInput.Text
                                select q).FirstOrDefault();
                    if (item == null)
                    {
                        Discipline a = new Discipline();
                        a.Name = txtInput.Text;
                        database.Discipline.Add(a);
                        database.SaveChanges();
                        gridType.ItemsSource = null;
                        gridType.ItemsSource = database.Discipline.ToList();
                        MessageBox.Show("Успех!", "Сообщение");
                    }
                    else
                    {
                        MessageBox.Show("Такая дисциплина уже есть!", "Ошибка");
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка", "Такая дисциплина уже есть!");
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
                Discipline gr = gridType.SelectedValue as Discipline;
                database.Database.ExecuteSqlCommand("DELETE FROM Discipline WHERE ID=" + gr.ID);
                MessageBox.Show("Сообщение", "Успех!");
                gridType.ItemsSource = null;
                gridType.ItemsSource = database.Discipline.ToList();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Вы не выбрали дисциплину!");
            }

        }

    }
}
