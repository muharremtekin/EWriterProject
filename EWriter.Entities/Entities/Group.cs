namespace EWriter.Entities.Entities
{
    public class Group : BaseEntity
    {
        public string GroupName { get; set; }
        public string NormalizedGroupName { get; set; }
        public string GroupDescription { get; set; }
        public string GroupBannerUrl { get; set; }
        public string GroupProfileUrl { get; set; }

        public virtual ICollection<GroupMembership> GroupMemberships { get; set; }
        public virtual ICollection<GroupAdmin> GroupAdmins { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
