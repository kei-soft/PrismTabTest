using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism;
using Prism.Commands;
using Prism.Mvvm;

namespace Module1.ViewModels
{
    public class ViewAViewModel : BindableBase, IActiveAware
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public event EventHandler IsActiveChanged;

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value); }
        }

        private string _title = "ViewA";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        public ViewAViewModel()
        {
            Message = "View A from your Prism Module";
        }
    }
}
