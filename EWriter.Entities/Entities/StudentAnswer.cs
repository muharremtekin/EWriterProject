namespace EWriter.Entities.Entities
{
    public class StudentAnswer
    {
        public Guid StudentAnswerId { get; set; }
        public Guid AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public Guid QuestionId { get; set; }
        public Guid QuestionQuizId { get; set; }
        public virtual Question Question { get; set; }
    }
}
