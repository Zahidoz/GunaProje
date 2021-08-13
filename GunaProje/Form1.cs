using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace GunaProje
{
    public partial class Form1 : Form
    {
        public List<UserControl> StudentList = new List<UserControl>();

        public Form1()
        {

            InitializeComponent();


             Student s1 = new Student(1, "Ceferli Nicat Rasim");
             Student s2 = new Student(2, "Eliyev Emiraslan İsa");
             Student s3 = new Student(3, "Haciyev Ebdul Hormet");
             Student s4 = new Student(4, "Hesenzade İlqar İlham");
             Student s5 = new Student(5, "İdayatov Kenan İlqar");
             Student s6 = new Student(6, "Nebili Nebi Elcin");
             Student s7 = new Student(7, "Rustamov Yusif Habil");
             Student s8 = new Student(8, "Zahid Vahabzade Yusif");
             Student s9 = new Student(9, "Emin Velizade Elvin");


            UserControl1 student1 = new UserControl1(s1);
            StudentList.Add(student1);
            UserControl1 student2 = new UserControl1(s2);
            StudentList.Add(student2);
            UserControl1 student3 = new UserControl1(s3);
            StudentList.Add(student3);
            UserControl1 student4 = new UserControl1(s4);
            StudentList.Add(student4);
            UserControl1 student5 = new UserControl1(s5);
            StudentList.Add(student5);
            UserControl1 student6 = new UserControl1(s6);
            StudentList.Add(student6);
            UserControl1 student7 = new UserControl1(s7);
            StudentList.Add(student7);
            UserControl1 student8 = new UserControl1(s8);
            StudentList.Add(student8);
            UserControl1 student9 = new UserControl1(s9);
            StudentList.Add(student9);

            foreach (var student in StudentList)
            {
                Controls.Add(student);
                panel1.Controls.Add(student);
                student.Controls.Owner.BringToFront();
                student.Dock = DockStyle.Top;
            }

        }


    }
}

