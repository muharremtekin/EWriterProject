namespace EWriter.Entities.Entities
{
    public class GroupMembership : BaseEntity
    {
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public Guid GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
