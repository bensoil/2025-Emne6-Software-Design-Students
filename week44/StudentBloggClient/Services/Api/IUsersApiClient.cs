using StudentBloggClient.Models.Users;

namespace StudentBloggClient.Services.Api;

public interface IUsersApiClient
{
    Task<IReadOnlyList<UserDto>> GetUsersAsync(int pageNumber = 1, int pageSize = 10, CancellationToken ct = default);
    Task<UserDto?> GetUserByIdAsync(int pageNumber = 1, int pageSize = 10);
    Task<UserDto?> RegisterUserAsync(UserDto user, CancellationToken ct = default);
    Task<UserDto?> UpdateUserAsync(UserDto user, CancellationToken ct = default);
    Task<UserDto?> DeleteUserAsync(int id, CancellationToken ct = default);
}