namespace AutenticacaoApi.Services.Interfaces
{
    public interface ITokenBuilder
    {
        string BuildToken(string username);
    }
}
