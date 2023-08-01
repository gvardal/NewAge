namespace JWTAuthenticationManager.Models
{
    public class AuthenticationResponse
    {
        public string Username { get; set; } = string.Empty;
        public string Jwttoken { get; set; } = string.Empty;
        public int ExpiresIn { get; set; } 
    }
}
