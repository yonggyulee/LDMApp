using LDMApp.Core.Models;
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
        Task<ICollection<Image>> GetList(string dataset_id);

        [Get("/{dataset_id}/{id}")]
        Task<Image> Get(string dataset_id, string id);

        [Post("/{dataset_id}")]
        Task<Image> Post(string dataset_id, [Body] Image image);

        [Delete("/{dataset_id}/{id}")]
        Task<string> Delete(string dataset_id, string id);

        [Put("/{dataset_id}/{id}")]
        Task<string> Put(string dataset_id, string id, [Body] Image image);
    }
}
