using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.CreateUser;

public record CreateUserRequest(string Email, string Name) : IRequest<CreateUserResponse>;