using LDMApp.Core.Models;
using LDMApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LDMApp.Controllers
{
    [ApiController]
    public class SamplesController
    {
        private readonly ISamplesApi samplesApi;

        public SamplesController(ISamplesApi samplesApi)
        {
            this.samplesApi = samplesApi;
        }

        [HttpGet("/{dataset_id}")]
        public async Task<ICollection<Sample>> GetList(string dataset_id)
        {

            var result = await samplesApi.GetList(dataset_id);

            return result;
        }
    }
}
