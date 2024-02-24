using AutoMapper;
using HerwegBrasil.Dtos;
using HerwegBrasil.Models;

namespace HerwegBrasil.Mappings
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping() 
        {
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            
        }
    }
}
