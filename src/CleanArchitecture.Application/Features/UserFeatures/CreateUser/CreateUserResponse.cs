namespace CleanArchitecture.Application.Features.UserFeatures.CreateUser;

public class CreateUserResponse
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}