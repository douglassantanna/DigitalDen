using Flurl;
using Flurl.Http;
using static DigitalDen.WebApp.Pages.FetchUsers;

namespace HttpServices.Users;
public class UserApiClient
{
    public async Task<List<ViewUser>> GetUsersAsync()
    {
        try
        {
            var users = await "http://localhost:5235/"
                .AppendPathSegment("api/user/get-all")
                .GetJsonAsync<List<ViewUser>>();
            return users;
        }
        catch (FlurlHttpException ex)
        {
            throw ex;
        }
    }
}