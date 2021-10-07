using System.Collections.Generic;

namespace CourseStore.Core.Domain
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Discount Discount { get; set; }
        public List<Tag> Tags { get; set; }
        public List<CourseTeacher> CourseTeachers { get; set; }
        public List<Comment> Comments { get; set; }
    }

}
