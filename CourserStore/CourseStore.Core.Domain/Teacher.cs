using System.Collections.Generic;

namespace CourseStore.Core.Domain
{
    public class Teacher
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<CourseTeacher> CourseTeachers { get; set; }

    }

}
