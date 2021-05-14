using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Input;

using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace PrismTabTest.ViewModels
{
    /// <summary>
    /// 팝업창
    /// </summary>
    public class ConfirmControlViewModel : BindableBase, IDialogAware
    {
        public ICommand OkCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        private string _title = "Popup";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ConfirmControlViewModel()
        {
            OkCommand = new DelegateCommand(OnOk);
            CancelCommand = new DelegateCommand(OnCencel);
        }

        public event Action<IDialogResult> RequestClose;

        private void OnCencel()
        {
            RequestClose?.Invoke(new DialogResult(ButtonResult.Cancel));
        }

        private void OnOk()
        {
            RequestClose?.Invoke(new DialogResult(ButtonResult.OK));
        }

        /// <summary>
        /// 팝업 닫는 조건
        /// </summary>
        /// <returns></returns>
        public bool CanCloseDialog()
        {
            return true;
        }

        /// <summary>
        /// 팝업 종료 후 실행
        /// </summary>
        public void OnDialogClosed()
        {
            //RequestClose?.Invoke( true);
        }

        /// <summary>
        /// 팝업 열리고 난 후 실행
        /// </summary>
        /// <param name="parameters"></param>
        public void OnDialogOpened(IDialogParameters parameters)
        {
            parameters.TryGetValue("id", out string id);
            parameters.TryGetValue("password", out string password);
            Debug.WriteLine($"");
        }
    }
}
