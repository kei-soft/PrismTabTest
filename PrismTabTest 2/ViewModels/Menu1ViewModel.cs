using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace PrismTabTest.ViewModels
{
    public class Menu1ViewModel : BindableBase
    {
        private readonly IDialogService _dialogService;

        public ICommand ConfirmCommand { get; set; }

        private string _title = "Menu1";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public Menu1ViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            ConfirmCommand = new DelegateCommand(OnConfirm);
        }

        private void OnConfirm()
        {
            _dialogService.ShowDialog("ConfirmControl"
                , new DialogParameters($"id=test&password=test2")
                , results =>
                {
                    if (results.Result != ButtonResult.OK) return;
                    //OK 처리
                });
        }
    }
}
