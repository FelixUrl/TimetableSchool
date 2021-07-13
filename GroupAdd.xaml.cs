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
    public partial class GroupAdd : MetroWindow
    {
        SchoolEntities2 database = new SchoolEntities2();
        public GroupAdd()
        {
            InitializeComponent();
            gridType.ItemsSource = database.Groups.ToList();

        }

        private void btn_Apply_Click(object sender, RoutedEventArgs e)
        {
            string line = txtInput.Text;
            if (line == "" || line ==" " || line=="  " || line=="   " || line=="    " || line=="     " || line=="      ")
            {
                MessageBox.Show("Ошибка", "Пустое поле ввода!");
                return;
            }
            if (line.Length > 6 || line.Length < 5)
            {
                MessageBox.Show("Ошибка", "Вы вводите не группу!");
            }
            else
            {
                char s = line[0];
                if (s < '0' || s > '9')
                {
                    char d = line[1];
                    if (d < '0' || d > '9')
                    {
                        char f = line[2];
                        if (f == '-')
                        {
                            char c = line[3];
                            if (c < 'А' || c > 'я')
                            {
                                char c1 = line[4];
                                if (c1 < 'А' || c1 > 'я')
                                {
                                    char c2 = line[5];
                                    if (c2 < 'А' || c2 > 'я')
                                    {
                                        try
                                        {
                                            var item = (from q in database.Groups
                                                        where q.Name == txtInput.Text
                                                        select q).FirstOrDefault();
                                            if (item == null)
                                            {
                                                Groups a = new Groups();
                                                a.Name = txtInput.Text;
                                                database.Groups.Add(a);
                                                database.SaveChanges();
                                                gridType.ItemsSource = null;
                                                gridType.ItemsSource = database.Groups.ToList();
                                                MessageBox.Show("Успех!", "Сообщение");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Такая группа уже есть!", "Ошибка");
                                            }
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Ошибка", "Такая группа уже есть!");
                                        }
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ошибка", "Введите группу правильно!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ошибка", "Введите группу правильно!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ошибка", "Введите группу правильно!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ошибка", "Введите группу правильно!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка", "Введите группу правильно!");
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка", "Введите группу правильно!");
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
                Groups gr = gridType.SelectedValue as Groups;
                database.Database.ExecuteSqlCommand("DELETE FROM Groups WHERE ID=" + gr.ID);
                MessageBox.Show("Сообщение", "Успех!");
                gridType.ItemsSource = null;
                gridType.ItemsSource = database.Groups.ToList();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Вы не выбрали группу!");
            }
            
        }
    }
}
