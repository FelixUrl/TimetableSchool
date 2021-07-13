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
using MahApps.Metro.IconPacks.Converter;
using HelpMe;
using MahApps.Metro.Controls.Dialogs;

namespace SampleApp
{
    /// <summary>
    /// Логика взаимодействия для WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : MetroWindow
    {
        SchoolEntities2 database = new SchoolEntities2();
        public WindowAdd()
        {
            InitializeComponent();
            List<Groups> groups = database.Groups.ToList();
            var ordergroup = from b in groups
                        orderby b.Name
                        select b;
            cmbGroup.ItemsSource = ordergroup;
            List<Audition> auditions = database.Audition.ToList();
            var orderauditions = from b in auditions
                                 orderby b.Name
                                 select b;
            cmbAudition.ItemsSource = orderauditions;
            List<Discipline> disciplines = database.Discipline.ToList();
            var orderisciplines = from b in disciplines
                                  orderby b.Name
                                 select b;
            cmbDiscipline.ItemsSource = orderisciplines;
            List<Teacher> teachers = database.Teacher.ToList();
            var orderteachers = from b in teachers
                                orderby b.Fullname
                                select b;
            cmbTeacher.ItemsSource = orderteachers;
            List<Lesson> lessons = database.Lesson.ToList();
            var orderlessons = from b in lessons
                                orderby b.Number
                                select b;
            cmbNumber.ItemsSource = orderlessons;
            List<TypeOfLesson> typeOfLessons = database.TypeOfLesson.ToList();
            var ordertol = from b in typeOfLessons
                           orderby b.Type
                           select b;
            cmbTypeOfLesson.ItemsSource = ordertol;
            List<DateNow> date = database.DateNow.ToList();
            var ordereddate = from b in date
                              orderby b.Date
                              select b;
            cmbDate.ItemsSource = ordereddate;
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void btn_Apply_Click(object sender, RoutedEventArgs e)
        {
            int id123 = (cmbAudition.SelectedValue as Audition).ID;
            int num123 = (cmbNumber.SelectedValue as Lesson).ID;
            int date123 = (cmbDate.SelectedValue as DateNow).ID;
            List<Timetable> timetables = database.Timetable.ToList();
            if ((cmbGroup.SelectedIndex == -1) || (cmbAudition.SelectedIndex == -1) || (cmbDiscipline.SelectedIndex == -1) || (cmbTeacher.SelectedIndex == -1) || (cmbNumber.SelectedIndex == -1) || (cmbTypeOfLesson.SelectedIndex == -1) || (cmbDate.SelectedIndex == -1))
            {
                MessageBox.Show("Вы не выбрали все данные!", "Ошибка");
            }
            else
            {
                var item = (from c in database.DateNow
                            where c.Date == date_Date.SelectedDate
                            select c).FirstOrDefault();
                var check = (from t in database.Timetable
                             where t.Audition == id123 && t.Lesson == num123 && t.DateNow == date123
                             select t).FirstOrDefault();
                if (check == null)
                {

                    if (item == null)
                    {
                        DateNow dt1 = new DateNow
                        {
                            Date = date_Date.SelectedDate
                        };
                        database.DateNow.Add(new DateNow
                        {
                            Date = date_Date.SelectedDate
                        });
                        database.Timetable.Add(new Timetable
                        {
                            Groups = (cmbGroup.SelectedValue as Groups).ID,
                            Audition = (cmbAudition.SelectedValue as Audition).ID,
                            Discipline = (cmbDiscipline.SelectedValue as Discipline).ID,
                            Teacher = (cmbTeacher.SelectedValue as Teacher).ID,
                            Lesson = (cmbNumber.SelectedValue as Lesson).ID,
                            TypeOfLesson = (cmbTypeOfLesson.SelectedValue as TypeOfLesson).ID,
                            DateNow = (cmbDate.SelectedValue as DateNow).ID
                        });
                    }
                    else
                    {
                        database.Timetable.Add(new Timetable
                        {
                            Groups = (cmbGroup.SelectedValue as Groups).ID,
                            Audition = (cmbAudition.SelectedValue as Audition).ID,
                            Discipline = (cmbDiscipline.SelectedValue as Discipline).ID,
                            Teacher = (cmbTeacher.SelectedValue as Teacher).ID,
                            Lesson = (cmbNumber.SelectedValue as Lesson).ID,
                            TypeOfLesson = (cmbTypeOfLesson.SelectedValue as TypeOfLesson).ID,
                            DateNow = (cmbDate.SelectedValue as DateNow).ID
                        });
                    }
                    database.SaveChanges();
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Такая запись уже существует", "Ошибка");
                }
                
            }
        }

        private void btnAdd_Group_Click(object sender, RoutedEventArgs e)
        {
           GroupAdd ga = new GroupAdd();
           ga.Show();
            Close();           
        }

        private void btnAdd_Audition_Click(object sender, RoutedEventArgs e)
        {
            AuditionAdd aa = new AuditionAdd();
            aa.Show();
            Close();
        }

        private void btnAdd_Discipline_Click(object sender, RoutedEventArgs e)
        {
            DisciplineAdd da = new DisciplineAdd();
            da.Show();
            Close();
        }

        private void btnAdd_Teacher_Click(object sender, RoutedEventArgs e)
        {
            TeacherAdd ta = new TeacherAdd();
            ta.Show();
            Close();
        }

        private void btnAdd_TypeOfLesson_Click(object sender, RoutedEventArgs e)
        {
            TypeOfLessonAdd tola = new TypeOfLessonAdd();
            tola.Show();
            Close();
        }

        private void btnAdd_Date_Click(object sender, RoutedEventArgs e)
        {
            if(date_Date.SelectedDate == null)
            {
                MessageBox.Show("Вы пытались добавить пустую дату", "Ошибка");
            }
            else
            {
                var item = (from c in database.DateNow
                            where c.Date == date_Date.SelectedDate
                            select c).FirstOrDefault();
                if (item == null)
                {
                    database.DateNow.Add(new DateNow
                    {
                        Date = date_Date.SelectedDate
                    });
                    database.SaveChanges();
                }
                cmbDate.ItemsSource = null;
                List<DateNow> date = database.DateNow.ToList();
                var ordereddate = from b in date
                                  orderby b.Date
                                  select b;
                cmbDate.ItemsSource = ordereddate;
            }
        }
    }
}
