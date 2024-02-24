using AutoMapper;
using HerwegBrasil.Dtos;
using HerwegBrasil.Interfaces;
using HerwegBrasil.Models;

namespace HerwegBrasil.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper? _mapper;
        private readonly IBrasilApi? _brasilApi;

        public EnderecoService(IMapper? mapper, IBrasilApi? brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGeneric<EnderecoResponse>?> SearchCep(string cep)
        {
            var endereco = await _brasilApi!.SearchCep(cep);
            return _mapper!.Map<ResponseGeneric<EnderecoResponse>>(endereco);
        }
    }
}
