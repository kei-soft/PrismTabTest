using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism;
using Prism.Commands;
using Prism.Mvvm;

namespace Module2.ViewModels
{
    public class ViewBViewModel : BindableBase, IActiveAware
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public event EventHandler IsActiveChanged;

        private string _title = "ViewB";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value); }
        }

        public ViewBViewModel()
        {
            Message = "View B from your Prism Module";
        }
    }
}
