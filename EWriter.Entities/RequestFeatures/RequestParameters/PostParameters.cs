namespace EWriter.Entities.RequestFeatures.RequestParameters;

public class PostParameters : RequestParameters
{
    public Guid? UserId { get; set; }
    public Guid? GroupId { get; set; }
}
