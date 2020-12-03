using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBussiness
    {
        private readonly StudentRepository studentRepository;

        public StudentBussiness()
        {
            this.studentRepository = new StudentRepository();
        }

        public List<Student> GetAllStudets()
        {
            return this.studentRepository.GetAllStudents();

        }

        public Boolean InsertStudent(Student s)
        {
            if (this.studentRepository.InsertStudent(s) > 0)

                return true;

            return false;
        }

        public List<Student> GetStudentsAvgMark(decimal AvaregeMark)
        {
            return this.studentRepository.GetAllStudents()
               .Where(s => AvaregeMark > s.AverageMark).ToList();
        }

    }

}
