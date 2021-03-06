using LDMApp.Controllers;
using LDMApp.Core.Events;
using LDMApp.Services.Interfaces;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LDMApp.Modules.MenuBar.ViewModels
{
    public class MenusViewModel : BindableBase
    {
        private DatasetController datasetController;
        private readonly IDialogService dialogService;
        private readonly IEventAggregator eventAggregator;
        private string _currentDataset;
        public string CurrentDataset
        {
            get { return _currentDataset; }
            set { SetProperty(ref _currentDataset, value); }
        }

        public DelegateCommand ShowDatasetSelectDialogCMD { get; }
        public DelegateCommand ShowDatasetImportDIalogCMD { get; }

        public MenusViewModel(IDatasetApi datasetApi, IDialogService dialogService, IEventAggregator eventAggregator)
        {
            datasetController = new DatasetController(datasetApi);
            this.dialogService = dialogService;
            this.eventAggregator = eventAggregator;
            ShowDatasetSelectDialogCMD = new DelegateCommand(ShowDatasetSelectDialog);
            ShowDatasetImportDIalogCMD = new DelegateCommand(ShowDatasetImportDialog);
        }

        private async void ShowDatasetSelectDialog()
        {
            var datasetList = await datasetController.Get();
            var dparams = new DialogParameters();
            dparams.Add("datasetList", datasetList);

            dialogService.ShowDialog("DatasetSelectDialog", dparams, r =>
            { 
                if (r.Result == ButtonResult.OK)
                {
                    CurrentDataset = r.Parameters.GetValue<string>("selectedDataset");
                    eventAggregator.GetEvent<DatasetSelectedEvent>().Publish(CurrentDataset);
                }
            });
        }

        private void ShowDatasetImportDialog()
        {
            dialogService.ShowDialog("DatasetImportDialog");
        }
    }
}
