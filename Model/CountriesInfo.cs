using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeViewSample.Base;

namespace TreeViewSample.Model
{
    public class CountriesInfo : ViewModelBase
    {
        public CountriesInfo()
        {
            Models = new ObservableCollection<CountriesInfo>();
        }

        private ObservableCollection<CountriesInfo> models;
        public ObservableCollection<CountriesInfo> Models
        {
            get
            {
                return models;
            }

            set
            {
                models = value;
                this.OnPropertyChanged();
            }
        }

        public bool IsChecked
        {
            get => isChecked;
            set
            {
                isChecked = value; OnPropertyChanged();

                if (IsParent && value)
                {
                    foreach (var item in Models)
                    {
                        item.IsChecked = true;
                    }
                }
                else if (IsParent)
                {
                    foreach (var item in Models)
                    {
                        item.IsChecked = false;
                    }

                }
            }
        }

        public bool IsParent
        {
            get => isParent;
            set
            {
                isParent = value;
                this.OnPropertyChanged();
            }
        }


        private string state;
        private bool isParent;
        private bool isChecked;

        /// <summary>
        /// Gets or sets a value indicating the state of the TreeViewItem.
        /// </summary>
        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
                this.OnPropertyChanged();
            }
        }
    }
}
