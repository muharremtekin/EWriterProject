namespace EWriter.Entities.Entities
{
    public class Post : BaseEntity
    {
        public string? PostTitle { get; set; }
        public string? PostText { get; set; }

        public Guid ContentTypeId { get; set; }
        public virtual ContentType ContentType { get; set; }

        public Guid GroupId { get; set; }
        public virtual Group Group { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }

    }
}
