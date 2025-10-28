using System.Net.Http.Json;
using StudentBloggClient.Models.Users;
using StudentBloggClient.Services.Auth;

namespace StudentBloggClient.Services.Api;

public class UsersApiClient(HttpClient httpClient, IBasicAuthStore authStore) : IUsersApiClient
{
    private readonly HttpClient _httpClient = httpClient;
    private readonly IBasicAuthStore _authStore = authStore;
    
    public async Task<IReadOnlyList<UserDto>> GetUsersAsync(int pageNumber = 1, int pageSize = 10, CancellationToken ct = default)
    {
        var url = $"api/v1/users?pageNumber={pageNumber}&pageSize={pageSize}";
        using var req = new HttpRequestMessage(HttpMethod.Get, url);
        
        //send http req
        using var res = await _httpClient.SendAsync(req, ct);
        
        var result = await res.Content.ReadFromJsonAsync<List<UserDto>>(ct);

        return result ?? [];
    }

    public async Task<UserDto?> GetUserByIdAsync(int pageNumber, int pageSize)
    {
        throw new NotImplementedException();
    }

    public async Task<UserDto?> RegisterUserAsync(UserDto user, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public async Task<UserDto?> UpdateUserAsync(UserDto user, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public async Task<UserDto?> DeleteUserAsync(int id, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
}