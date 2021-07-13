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
    public partial class AuditionAdd : MetroWindow
    {
        SchoolEntities2 database = new SchoolEntities2();
        public AuditionAdd()
        {
            InitializeComponent();
            gridType.ItemsSource = database.Audition.ToList();

        }

        private void btn_Apply_Click(object sender, RoutedEventArgs e)
        {
            string line = txtInput.Text;
            if(line == "" || line == " " || line == "  " || line == "   ")
            {
                MessageBox.Show("Ошибка", "Пустое поле ввода!");
                return;
            }
            if (line.Length > 3)
            {
                MessageBox.Show("Ошибка", "Вы вводите не аудиторию!");
                return;
            }
            else
            {
                char s = line[0];
                if (!(s < '0' || s > '9'))
                {

                    char s1 = line[1];
                    if (!(s1 < '0' || s1 > '9'))
                    {
                        char s2 = line[2];
                        if (!(s2 < '0' || s2 > '9'))
                        {
                            try
                            {
                                var item = (from q in database.Audition
                                            where q.Name == txtInput.Text
                                            select q).FirstOrDefault();
                                if (item == null)
                                {
                                    Audition a = new Audition();
                                    a.Name = txtInput.Text;
                                    database.Audition.Add(a);
                                    database.SaveChanges();
                                    gridType.ItemsSource = null;
                                    gridType.ItemsSource = database.Audition.ToList();
                                    MessageBox.Show("Успех!", "Сообщение");
                                }
                                else
                                {
                                    MessageBox.Show("Такая аудитория уже есть!", "Ошибка");
                                }
                            } 
                            catch 
                            {
                                MessageBox.Show("Ошибка", "Такая аудитория уже есть!");
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Ошибка", "Введите аудиторию правильно!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка", "Введите аудиторию правильно!");
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка", "Введите аудиторию правильно!");
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
                Audition gr = gridType.SelectedValue as Audition;
                database.Database.ExecuteSqlCommand("DELETE FROM Audition WHERE ID=" + gr.ID);
                MessageBox.Show("Сообщение", "Успех!");
                gridType.ItemsSource = null;
                gridType.ItemsSource = database.Audition.ToList();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Вы не выбрали аудиторию!");
            }

        }
    }
}
