using HerwegBrasil.Dtos;
using HerwegBrasil.Models;

namespace HerwegBrasil.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGeneric<List<BancoResponse>>?> SearchAllBank();
        Task<ResponseGeneric<BancoResponse>?> SearchBank(string code);
    }
}
