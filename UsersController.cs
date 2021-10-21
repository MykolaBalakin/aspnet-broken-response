using Microsoft.AspNetCore.Mvc;

namespace AspNetBrokenResponse;

public record UserApiModel(
    string FirstName,
    string LastName,
    string FullName,
    string Description,
    string LocalizedDescription,
    string[] Roles);

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly UserRepository _userRepository;

    public UsersController(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public IEnumerable<UserApiModel> Index()
    {
        var users = _userRepository.GetAll();
        return users.Select(ToApiModel);
    }

    private static UserApiModel ToApiModel(User user)
    {
        return new UserApiModel(
            user.FirstName,
            user.LastName,
            $"{user.FirstName} {user.LastName}",
            user.Description,
            user.Description,
            user.Roles.Select(role => role.Name).ToArray());
    }
}