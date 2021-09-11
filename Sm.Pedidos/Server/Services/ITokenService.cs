using System.Threading.Tasks;

namespace Sm.Pedidos.Server.Services
{
    public interface ITokenService
    {
        Task<string> GenerateTokenAsync(string email);
    }
}
