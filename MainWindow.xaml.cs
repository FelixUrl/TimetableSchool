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
using HelpMe;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace SampleApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : MetroWindow
    {
        SchoolEntities2 database = new SchoolEntities2();
        public MainWindow()
        {
            InitializeComponent();
            Disabled_btn();
            gridTimetable.ItemsSource = database.Timetable.ToList();
            List<DateNow> date = database.DateNow.ToList();
            var ordereddate = from b in date
                              orderby b.Date
                              select b;
            cmbDate.ItemsSource = ordereddate;
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Timetable r = gridTimetable.SelectedValue as Timetable;
                database.Database.ExecuteSqlCommand("DELETE FROM Timetable WHERE ID_Timetable=" + r.ID_Timetable);
                gridTimetable.ItemsSource = null;
                gridTimetable.ItemsSource = database.Timetable.ToList();
                MessageBox.Show("Сообщение", "Успех!");
                Disabled_btn();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Вы выбрали не элемент!");
            }
            
        }

        private void btn_Create_Click(object sender, RoutedEventArgs e)
        {
                WindowAdd add = new WindowAdd();
                add.Show();
                Close();
        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Timetable tt = gridTimetable.SelectedValue as Timetable;
                WindowEdit edit = new WindowEdit(tt);
                Disabled_btn();
                edit.Show();
                Close();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Вы выбрали не элемент!");
            }
        }

        private void btn_View_Click(object sender, RoutedEventArgs e)
        {
            WindowView wv = new WindowView();
            wv.Show();
            Close();
        }

        private void gridTimetable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (gridTimetable.SelectedItem != null)
                {
                    if (gridTimetable.SelectedItem is Timetable row)
                    {
                        if (row != null)
                        {
                            Enabled_btn();
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        public void Disabled_btn()
        {
            btn_Edit.IsEnabled = false;
            btn_Delete.IsEnabled = false;
            btn_Edit.Foreground = new SolidColorBrush(Colors.DarkGray);
            btn_Delete.Foreground = new SolidColorBrush(Colors.DarkGray);
        }
        public void Enabled_btn()
        {
            btn_Edit.IsEnabled = true;
            btn_Delete.IsEnabled = true;
            btn_Edit.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 122, 204));
            btn_Delete.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 122, 204));
        }

        private void cmbDate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DateNow dateCurrent = cmbDate.SelectedValue as DateNow;
            gridTimetable.ItemsSource = null;
            gridTimetable.ItemsSource = database.Timetable.Where(x => x.DateNow1.Date == dateCurrent.Date).ToList();
        }
    }
}
