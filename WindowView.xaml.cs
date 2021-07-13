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
    public partial class WindowView : MetroWindow
    {
        SchoolEntities2 database = new SchoolEntities2();
        public WindowView()
        {
            InitializeComponent();
            gridTeacher.ItemsSource = database.Timetable.ToList();
            gridStudent.ItemsSource = database.Timetable.ToList();
            List<Groups> groups = database.Groups.ToList();
            var ordergroup = from b in groups
                             orderby b.Name
                             select b;
            cmbStudent.ItemsSource = ordergroup;
            List<Teacher> teachers = database.Teacher.ToList();
            var orderteachers = from b in teachers
                                orderby b.Fullname
                                select b;
            cmbTeacher.ItemsSource = orderteachers;
            List<DateNow> date = database.DateNow.ToList();
            var ordereddate = from b in date
                              orderby b.Date
                              select b;
            cmbDateStudent.ItemsSource = ordereddate;
            cmbDateTeacher.ItemsSource = ordereddate;
        }

        private void cmbTeacher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Teacher currentvalue = cmbTeacher.SelectedValue as Teacher;
            try
            {
                gridTeacher.ItemsSource = null;
                gridTeacher.ItemsSource = database.Timetable.Where(x => x.Teacher1.Fullname == currentvalue.Fullname).ToList();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Пустое расписание!");
            }
            
        }

        private void cmbStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Groups currentvalue = cmbStudent.SelectedValue as Groups;
            try
            {
                gridStudent.ItemsSource = null;
                gridStudent.ItemsSource = database.Timetable.Where(x => x.Groups1.Name == currentvalue.Name).ToList();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Пустое расписание!");
            }
        }
        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }

        private void cmbDateTeacher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DateNow dateCurrent = cmbDateTeacher.SelectedValue as DateNow;
            gridTeacher.ItemsSource = null;
            gridTeacher.ItemsSource = database.Timetable.Where(x => x.DateNow1.Date == dateCurrent.Date).ToList();
        }

        private void cmbDateStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DateNow dateCurrent = cmbDateStudent.SelectedValue as DateNow;
            gridStudent.ItemsSource = null;
            gridStudent.ItemsSource = database.Timetable.Where(x => x.DateNow1.Date == dateCurrent.Date).ToList();
        }
    }
}
