using LDMApp.Core.Models;
using LDMApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LDMApp.Controllers
{
    [ApiController]
    public class ImagesController
    {
        private readonly IImagesApi imagesApi;

        public ImagesController(IImagesApi imagesApi)
        {
            this.imagesApi = imagesApi;
        }

        [HttpGet("/{dataset_id}")]
        public async Task<ICollection<Image>> Get(string dataset_id)
        {
            return await imagesApi.GetList(dataset_id);
        }
    }
}
