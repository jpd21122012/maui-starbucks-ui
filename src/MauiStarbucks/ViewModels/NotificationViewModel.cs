using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassavaRoots.ViewModels
{
    [INotifyPropertyChanged]
    public partial class NotificationViewModel : BaseViewModel
    {
        public override Task Initialize()
        {
            return Task.CompletedTask;
        }

        public override Task Stop()
        {
            return Task.CompletedTask;
        }
    }
}
