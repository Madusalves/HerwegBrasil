using AutoMapper;
using HerwegBrasil.Dtos;
using HerwegBrasil.Interfaces;
using HerwegBrasil.Models;

namespace HerwegBrasil.Services
{
   /* public class BrasilApiService : IBancoService
    {     
        
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasil;

        public BrasilApiService(IMapper mapper)
        {
            _mapper = mapper;
            
        }
        public async Task<ResponseGeneric<BancoResponse>> SearchBank(string code)
        {
            var banco = await _brasil.SearchBank(code);

            return _mapper.Map<ResponseGeneric<BancoResponse>>(banco);
        }

        public async Task<ResponseGeneric<List<BancoResponse>>> SearchAllBank()
        {

            var bancos = await _brasil.SearchAllBank();

            return _mapper.Map<ResponseGeneric<List<BancoResponse>>>(bancos);




        }

    }*/
}
