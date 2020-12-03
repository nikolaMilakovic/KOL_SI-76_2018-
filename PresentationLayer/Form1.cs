using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly StudentBussiness studentBusiness;


        public Form1()
        {
            InitializeComponent();
            this.studentBusiness = new StudentBussiness();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RefreshData()
        {
            List<Student> students = this.studentBusiness.GetAllStudets();
            listBoxStudents.Items.Clear();

            foreach (Student s in students)
            {
                listBoxStudents.Items.Add(s.Id + ". " + s.Name + "(" +s.IndexNumber+ ") ="+ s.AverageMark);
            }

        }

        private void buttonInsertStudent_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = TextBoxName.Text;
            s.IndexNumber = TextBoxIndexNumber.Text;
            s.AverageMark = Convert.ToDecimal(TextBoxAverageMark.Text);

            if (studentBusiness.InsertStudent(s))
            {
                RefreshData();
            }
            else
                MessageBox.Show("Otislo sve u kurac");
        }

        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
