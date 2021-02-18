using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReserverProject.Models;
using AutoMapper;

namespace ReserverProject.Controllers
{
    [ApiController]
    [Route("{API}/")]
    public class ApiController : Controller
    {
        private readonly HttpClient _client;
        private readonly AutoMapper.Mapper _mapper;

        public ApiController(HttpClient client, AutoMapper.Mapper mapper)
        {
            this._client = client;
            this._mapper = mapper;
        }
        
        [HttpGet]
        [Route("getList")]
        public async Task<List<CountryViewModel>> GetList()
        {
            var response = await _client.GetAsync("https://api.covid19api.com/summary");
            var content = _mapper.Map<ApiModel>(response.Content);
            List<Countries> countries = content.Countries;
            List<CountryViewModel> result = (List<CountryViewModel>)countries.Select(x => new CountryViewModel(x.TotalConfirmed - x.TotalRecovered, x.Country)).ToList().OrderBy(X => X.ActiveCases).Take(10);
            return result;
        }
    }
}
