using AutoMapper;
using HerwegBrasil.Dtos;
using HerwegBrasil.Interfaces;
using HerwegBrasil.Models;

namespace HerwegBrasil.Services
{
    public class BancoService : IBancoService
    {
            private readonly IMapper? _mapper;
            private readonly IBrasilApi? _brasilApi;

            public BancoService(IMapper? mapper, IBrasilApi? brasilApi)
            {
                _mapper = mapper;
                _brasilApi = brasilApi;
            }

        public async Task<ResponseGeneric<List<BancoResponse>>?> SearchAllBank()
        {
            var bancos = await _brasilApi!.SearchAllBank();
            return _mapper?.Map<ResponseGeneric<List<BancoResponse>>?>(bancos);
        }

       

        public async Task<ResponseGeneric<BancoResponse>?> SearchBank(string code)
        {
            var banco = await _brasilApi!.SearchBank(code);
            return _mapper?.Map<ResponseGeneric<BancoResponse>?>(banco);
        }
    }
}
