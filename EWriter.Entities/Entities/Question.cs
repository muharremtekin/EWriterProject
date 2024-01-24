namespace EWriter.Entities.Entities
{
    public class Question : BaseEntity
    {
        public string QuestionText { get; set; }
        public Guid QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
        public virtual ICollection<QuestionInformation> QuestionInformations { get; set; }
        public virtual ICollection<StudentAnswer> StudentAnswers { get; set; }
    }
}
