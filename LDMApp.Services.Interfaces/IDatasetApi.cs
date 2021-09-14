using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDMApp.Services.Interfaces
{
    public interface IDatasetApi
    {
        [Get("/")]
        Task<string> Get();
    }
}
