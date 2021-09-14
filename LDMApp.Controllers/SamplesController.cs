using LDMApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        public async Task<string> Get(string dataset_id)
        {
            return await samplesApi.Get(dataset_id);
        }
    }
}
