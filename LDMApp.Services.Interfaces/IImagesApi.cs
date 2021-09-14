using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LDMApp.Services.Interfaces
{
    public interface IImagesApi
    {
        [Get("/{dataset_id}")]
        Task<string> Get(string dataset_id);
    }
}
