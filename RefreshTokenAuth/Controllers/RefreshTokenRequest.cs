namespace RefreshTokenAuth.Controllers
{
    public class RefreshTokenRequest
    {
        public object RefreshToken { get; internal set; }
        public object Token { get; internal set; }
    }
}