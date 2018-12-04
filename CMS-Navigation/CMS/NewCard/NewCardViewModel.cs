using CMS.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.NewCard
{
    public class NewCardViewModel : BaseViewModel
    {
        public NewCardViewModel()
        {
            ActiveViewModel = null;
        }

        private BaseViewModel _activeViewModel;
        public BaseViewModel ActiveViewModel
        {
            get => _activeViewModel;
            set => SetPropertyValue(ref _activeViewModel, value);
        }

    }
}
