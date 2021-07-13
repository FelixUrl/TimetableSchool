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

namespace SampleApp
{
    /// <summary>
    /// Логика взаимодействия для WindowAdd.xaml
    /// </summary>
    
    public partial class WindowEdit : MetroWindow
    {
        SchoolEntities2 database = new SchoolEntities2();
        Timetable timetable_timebuffer;
        public WindowEdit(Timetable tt)
        {
            InitializeComponent();
            this.timetable_timebuffer = tt;

            cmbGroup.ItemsSource = database.Groups.ToList();
            List<Groups> gr = database.Groups.ToList();
            cmbGroup.ItemsSource = gr;
            cmbGroup.SelectedIndex = gr.FindIndex(x => x.ID == timetable_timebuffer.Groups1.ID);

            cmbAudition.ItemsSource = database.Audition.ToList();
            List<Audition> ga = database.Audition.ToList();
            cmbAudition.ItemsSource = ga;
            cmbAudition.SelectedIndex = ga.FindIndex(x => x.ID == timetable_timebuffer.Audition1.ID);

            cmbDiscipline.ItemsSource = database.Discipline.ToList();
            List<Discipline> gd = database.Discipline.ToList();
            cmbDiscipline.ItemsSource = gd;
            cmbDiscipline.SelectedIndex = gd.FindIndex(x => x.ID == timetable_timebuffer.Discipline1.ID);

            cmbTeacher.ItemsSource = database.Teacher.ToList();
            List<Teacher> gt = database.Teacher.ToList();
            cmbTeacher.ItemsSource = gt;
            cmbTeacher.SelectedIndex = gt.FindIndex(x => x.ID == timetable_timebuffer.Teacher1.ID);

            cmbNumber.ItemsSource = database.Lesson.ToList();
            List<Lesson> gn = database.Lesson.ToList();
            cmbNumber.ItemsSource = gn;
            cmbNumber.SelectedIndex = gn.FindIndex(x => x.ID == timetable_timebuffer.Lesson1.ID);

            cmbTypeOfLesson.ItemsSource = database.TypeOfLesson.ToList();
            List<TypeOfLesson> gg = database.TypeOfLesson.ToList();
            cmbTypeOfLesson.ItemsSource = gg;
            cmbTypeOfLesson.SelectedIndex = gg.FindIndex(x => x.ID == timetable_timebuffer.TypeOfLesson1.ID);
        }
        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
        private void btn_Apply_Click(object sender, RoutedEventArgs e)
        {
            Timetable Edits = database.Timetable.Where(x => x.ID_Timetable == timetable_timebuffer.ID_Timetable).SingleOrDefault();
            Edits.TypeOfLesson = (cmbTypeOfLesson.SelectedValue as TypeOfLesson).ID;
            Edits.Lesson= (cmbNumber.SelectedValue as Lesson).ID;
            Edits.Teacher = (cmbTeacher.SelectedValue as Teacher).ID;
            Edits.Discipline = (cmbDiscipline.SelectedValue as Discipline).ID;
            Edits.Audition = (cmbAudition.SelectedValue as Audition).ID;
            Edits.Groups = (cmbGroup.SelectedValue as Groups).ID;
            database.SaveChanges();
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}

