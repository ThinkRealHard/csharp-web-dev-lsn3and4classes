using System;

namespace csharp_web_dev_lsn3and4classes
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double placeholder = this.Gpa * this.NumberOfCredits;
            double coursePlaceholder = courseCredits * grade;
            this.NumberOfCredits += courseCredits;
            this.Gpa = (placeholder + coursePlaceholder) / this.NumberOfCredits;
        }

        public string GetGradeLevel(int credits)
        {
            if(NumberOfCredits >= 90)
            {
                return "Senior";
            }
            else if((NumberOfCredits >= 60) && (NumberOfCredits < 90))
            {
                return "Junior";
            }
            else if((NumberOfCredits >= 30) && (NumberOfCredits < 60))
            {
                return "Sophmore";
            }
            else if((NumberOfCredits >= 0) && (NumberOfCredits < 30))
            {
                return "Freshman";
            }

            return "grade level tbd";
        }

        public override string ToString()
        {
            return Name + " is a " + this.GetGradeLevel(this.NumberOfCredits) + ", with a GPA of " + Gpa;
        }

        public override bool Equals(object obj)
        {
            if(obj == this)
            {
                return true;
            }

            if(obj == null)
            {
                return false;
            }

            if(obj.GetType() != this.GetType())
            {
                return false;
            }

            Student s = obj as Student;
            return s.StudentId == StudentId;
        }
    }
}
