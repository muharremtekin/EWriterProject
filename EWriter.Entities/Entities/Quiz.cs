namespace EWriter.Entities.Entities
{
    public class Quiz
    {
        public Guid QuizId { get; set; }
        public string QuizTitle { get; set; }
        public string QuizDescription { get; set; }
        public Guid PostId { get; set; }
        public virtual Post Post { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}