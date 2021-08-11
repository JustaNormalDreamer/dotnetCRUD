using techlink.Persons;

namespace techlink.Jwt
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, PersonResource user);
        //string GenerateJSONWebToken(string key, string issuer, UserDTO user);
        bool IsTokenValid(string key, string issuer, string token);
    }
}