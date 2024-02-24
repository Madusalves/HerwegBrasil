using HerwegBrasil.Dtos;
using HerwegBrasil.Models;

namespace HerwegBrasil.Interfaces
{
    public interface IBrasilApi 
    {
        Task<ResponseGeneric<EnderecoResponse>> SearchCep(string cep);
        Task<ResponseGeneric<List<BancoResponse>>> SearchAllBank();
        Task<ResponseGeneric<BancoResponse>> SearchBank(string code);
    }
}
