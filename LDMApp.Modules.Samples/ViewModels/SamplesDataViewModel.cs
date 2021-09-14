using LDMApp.Controllers;
using LDMApp.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LDMApp.Modules.Samples.ViewModels
{
    public class SamplesDataViewModel : BindableBase
    {
        private SamplesController samplesController;
        public SamplesDataViewModel(ISamplesApi samplesApi)
        {
            samplesController = new SamplesController(samplesApi);
        }
    }
}
