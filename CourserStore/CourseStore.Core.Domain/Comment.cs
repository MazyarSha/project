using System;

namespace CourseStore.Core.Domain
{
    public class Comment
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
    }

}
