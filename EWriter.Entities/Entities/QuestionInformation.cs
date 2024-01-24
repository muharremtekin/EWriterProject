namespace EWriter.Entities.Entities
{
    public class QuestionInformation : BaseEntity
    {
        public string QuestionInformationTitle { get; set; }
        public string QuestionInformationDescription { get; set; }
        public Guid QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}