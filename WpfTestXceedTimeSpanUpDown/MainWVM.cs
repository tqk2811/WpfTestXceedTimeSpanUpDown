using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestXceedTimeSpanUpDown
{
    internal class MainWVM
    {
        public MainWVM()
        {

        }

        public TimeSpan TimeSpan { get; set; } = TimeSpan.FromHours(2);
        public ObservableCollection<TimeVM> TimeList { get; } = new ObservableCollection<TimeVM>()
        {
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
            new TimeVM(),
        };
    }
}
