using HerwegBrasil.Dtos;
using HerwegBrasil.Interfaces;
using HerwegBrasil.Models;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;

namespace HerwegBrasil.Rest
{
    public class BrasilApiRest : IBrasilApi
    {



        public async Task<ResponseGeneric<BancoResponse>> SearchBank(string code)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{code}");

            var response = new ResponseGeneric<BancoResponse>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<BancoResponse>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DataReturn = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }

            }
            return response;
        }

        public async Task<ResponseGeneric<EnderecoResponse>> SearchCep(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response = new ResponseGeneric<EnderecoResponse>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<EnderecoResponse>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DataReturn = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }

            }
            return response;

        }


        public async Task<ResponseGeneric<List<BancoResponse>>> SearchAllBank()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/");

            var response = new ResponseGeneric<List<BancoResponse>>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<BancoResponse>>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DataReturn = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErrorReturn = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }

            }
            return response;
        }
    }
}

