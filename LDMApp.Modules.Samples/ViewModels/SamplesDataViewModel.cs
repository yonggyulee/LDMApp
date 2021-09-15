using LDMApp.Controllers;
using LDMApp.Core.Models;
using LDMApp.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LDMApp.Modules.Samples.ViewModels
{
    public class SamplesDataViewModel : BindableBase
    {
        private SamplesController samplesController;

        private ObservableCollection<Sample> _sampleItems = new ObservableCollection<Sample>();
        public ObservableCollection<Sample> SampleItems 
        {
            get { return _sampleItems; } 
            set { SetProperty(ref _sampleItems, value); } 
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private Sample _currentPositionSampleItem;

        public SamplesDataViewModel(ISamplesApi samplesApi)
        {
            samplesController = new SamplesController(samplesApi);
            setData();
            //getMsg();
        }

        public Sample CurrentPositionSampleItem
        {
            get { return _currentPositionSampleItem; }
            set
            {
                SetProperty(ref _currentPositionSampleItem, value);
            }
        }

        private async void setData()
        {
            var result = await samplesController.GetList("dataset_1");
            SampleItems = new ObservableCollection<Sample>(result);
            CurrentPositionSampleItem = SampleItems.First();
            int s_id = CurrentPositionSampleItem.SampleID;
            string d_id = CurrentPositionSampleItem.DatasetID;
            int s_type = CurrentPositionSampleItem.SampleType;
            string md = CurrentPositionSampleItem.Metadata;
        }


        private Sample _sample;
        public Sample Sample
        {
            get { return _sample; }
            set { SetProperty(ref _sample, value); }
        }

        private ICollection<Sample> _samples { get; set; }

        public async void getMsg()
        {
            _samples = await samplesController.GetList("dataset_1");
            SampleItems = new ObservableCollection<Sample>(_samples);
            Sample = SampleItems.First<Sample>();
            Message = $"s_id : {Sample.SampleID}, d_id : {Sample.DatasetID}, s_type : {Sample.SampleType}, md : {Sample.Metadata}, ic : {Sample.ImageCount}, images : {Sample.images.First()}";
        }
    }
}
