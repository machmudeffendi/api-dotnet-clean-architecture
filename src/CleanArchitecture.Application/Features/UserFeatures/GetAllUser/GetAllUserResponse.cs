namespace CleanArchitecture.Application.Features.UserFeatures.GetAllUser;

public sealed class GetAllUserResponse
{
    public Guid id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}