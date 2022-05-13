using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker.Frontend.Models;

using Wolf.Utility.Core.Bases;

namespace TimeTracker.Frontend.Wpf.ViewModel
{
    public class MainWindowModel : BasePropertyChanged
    {
        private bool isAuthenticated = false;
        private User user = null;

        public bool IsAuthenticated { get => isAuthenticated; set => SetProperty(ref isAuthenticated, value, nameof(IsAuthenticated)); }
        public User User { get => user; set => SetProperty(ref user, value, nameof(User)); }
        
        public MainWindowModel()
        {

        }
    }
}
