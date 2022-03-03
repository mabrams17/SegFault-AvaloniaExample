using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TestProject.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        public MainWindowViewModel()
        {
            ObservableCollection<string> buildUp = new();
            for (var i = 0; i < 1000; i++)
            {
                switch (i)
                {
                    case 0:
                        buildUp.Add("This is the first item");
                        break;
                    case 999:
                        buildUp.Add("This is the last item");
                        break;
                    default:
                        buildUp.Add("This is item " + i );
                        break;
                }
            }

            Rows = buildUp;
        }

        public ObservableCollection<string> Rows { get; set; }


    }
}