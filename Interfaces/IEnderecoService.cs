using HerwegBrasil.Dtos;
using HerwegBrasil.Models;

namespace HerwegBrasil.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGeneric<EnderecoResponse>?> SearchCep(string cep);
    }
}
