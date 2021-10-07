namespace CourseStore.Core.Domain
{
    public class CourseTeacher
    {
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
        public Course Course { get; set; }
        public Teacher Teachr { get; set; }
        public int SortOrder { get; set; }
    }

}
