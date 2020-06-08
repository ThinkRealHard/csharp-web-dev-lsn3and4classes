using System;
using System.Collections.Generic;


namespace csharp_web_dev_lsn3and4classes
{

	public class Course
	{
		public string Topic { get; set; }
		public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; } = new List<Student>();

        public override string ToString()
        {
            return "The topic is " + this.Topic + " and the instructor is " + Instructor.FirstName + " " + Instructor.LastName + ". The class enrollment is currently " + enrolledStudents.Count + ".";
        }
        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Course s = obj as Course;
            return s.Topic == Topic;
        }
    }
}
