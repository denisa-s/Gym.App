using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Input;
using Proiect1.Models;

namespace Proiect1.ViewModel
{
    public class GymPageViewModel
    {
        public GymPageViewModel(INavigation navigation)
        {
            this.navigation = navigation;
        }
        private INavigation navigation;

    }
}
