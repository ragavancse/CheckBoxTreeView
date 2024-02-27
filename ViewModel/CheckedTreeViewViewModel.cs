﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TreeViewSample.Base;
using TreeViewSample.Model;

namespace TreeViewSample.ViewModel
{
    public class CheckedTreeViewViewModel : ViewModelBase
    {
        public CheckedTreeViewViewModel()
        {
            Items = new ObservableCollection<CountriesInfo>();
            CheckedClick = new RelayCommand<CountriesInfo>(OnCheck);
            var country1 = new CountriesInfo { State = "Australia", IsParent = true };
            var country2 = new CountriesInfo { State = "Brazil", IsParent = true };
            var country3 = new CountriesInfo { State = "China", IsParent = true };
            var country4 = new CountriesInfo { State = "France", IsParent = true };
            var country5 = new CountriesInfo { State = "India", IsParent = true };
            var country6 = new CountriesInfo { State = "USA", IsParent = true };
            var country7 = new CountriesInfo { State = "UK", IsParent = true };
            var country8 = new CountriesInfo { State = "Russia", IsParent = true };
            var country9 = new CountriesInfo { State = "Canada", IsParent = true };
            var country10 = new CountriesInfo { State = "Germany", IsParent = true };

            var aus_state1 = new CountriesInfo { State = "New South Wales" };
            var aus_state2 = new CountriesInfo { State = "Victoria" };
            var aus_state3 = new CountriesInfo { State = "South Autralia" };
            var aus_state4 = new CountriesInfo { State = "Western Australia" };

            var brazil_state1 = new CountriesInfo { State = "Parana" };
            var brazil_state2 = new CountriesInfo { State = "Ceara" };
            var brazil_state3 = new CountriesInfo { State = "Acre" };

            var china_state1 = new CountriesInfo { State = "Guangzhou" };
            var china_state2 = new CountriesInfo { State = "Shanghai" };
            var china_state3 = new CountriesInfo { State = "Beijing" };
            var china_state4 = new CountriesInfo { State = "Shantou" };

            var france_state1 = new CountriesInfo { State = "Pays de la Loire" };
            var france_state2 = new CountriesInfo { State = "Aquitaine" };
            var france_state3 = new CountriesInfo { State = "Brittany" };
            var france_state4 = new CountriesInfo { State = "Lorraine" };

            var ind_State1 = new CountriesInfo { State = "Assam" };
            var ind_State2 = new CountriesInfo { State = "Bihar" };
            var ind_State3 = new CountriesInfo { State = "Tamil Nadu" };
            var ind_State4 = new CountriesInfo { State = "Punjab" };

            var usa_state1 = new CountriesInfo { State = "New York" };
            var usa_state2 = new CountriesInfo { State = "California" };
            var usa_state3 = new CountriesInfo { State = "Texas" };
            var usa_state4 = new CountriesInfo { State = "Washington" };
            var usa_state5 = new CountriesInfo { State = "Florida" };

            var uk_state1 = new CountriesInfo { State = "England" };
            var uk_state2 = new CountriesInfo { State = "Wales" };
            var uk_state3 = new CountriesInfo { State = "Scotland" };
            var uk_state4 = new CountriesInfo { State = "Northern Ireland" };

            var russia_state1 = new CountriesInfo { State = "Mordovia" };
            var russia_state2 = new CountriesInfo { State = "Chechnya" };
            var russia_state3 = new CountriesInfo { State = "Tatarstan" };
            var russia_state4 = new CountriesInfo { State = "Dagestan" };

            var canada_state1 = new CountriesInfo { State = "Alberta" };
            var canada_state2 = new CountriesInfo { State = "Manitoba" };
            var canada_state3 = new CountriesInfo { State = "New Brunswick" };
            var canada_state4 = new CountriesInfo { State = "Quebec" };

            var germany_state1 = new CountriesInfo { State = "Berlin" };
            var germany_state2 = new CountriesInfo { State = "Hamburg" };
            var germany_state3 = new CountriesInfo { State = "Bremen" };
            var germany_state4 = new CountriesInfo { State = "Lower Saxony" };

            country1.Models.Add(aus_state1);
            country1.Models.Add(aus_state2);
            country1.Models.Add(aus_state3);
            country1.Models.Add(aus_state4);

            country2.Models.Add(brazil_state1);
            country2.Models.Add(brazil_state2);
            country2.Models.Add(brazil_state3);

            country3.Models.Add(china_state1);
            country3.Models.Add(china_state2);
            country3.Models.Add(china_state3);
            country3.Models.Add(china_state4);

            country4.Models.Add(france_state1);
            country4.Models.Add(france_state2);
            country4.Models.Add(france_state3);
            country4.Models.Add(france_state4);

            country5.Models.Add(ind_State1);
            country5.Models.Add(ind_State2);
            country5.Models.Add(ind_State3);
            country5.Models.Add(ind_State4);

            country6.Models.Add(usa_state1);
            country6.Models.Add(usa_state2);
            country6.Models.Add(usa_state3);
            country6.Models.Add(usa_state4);
            country6.Models.Add(usa_state5);

            country7.Models.Add(uk_state1);
            country7.Models.Add(uk_state2);
            country7.Models.Add(uk_state3);
            country7.Models.Add(uk_state4);

            country8.Models.Add(russia_state1);
            country8.Models.Add(russia_state2);
            country8.Models.Add(russia_state3);
            country8.Models.Add(russia_state4);

            country9.Models.Add(canada_state1);
            country9.Models.Add(canada_state2);
            country9.Models.Add(canada_state3);
            country9.Models.Add(canada_state4);

            country10.Models.Add(germany_state1);
            country10.Models.Add(germany_state2);
            country10.Models.Add(germany_state3);
            country10.Models.Add(germany_state4);

            Items.Add(country1);
            Items.Add(country2);
            Items.Add(country3);
            Items.Add(country4);
            Items.Add(country5);
            Items.Add(country6);
            Items.Add(country7);
            Items.Add(country8);
            Items.Add(country9);
            Items.Add(country10);

            CheckedItems = new ObservableCollection<CountriesInfo>();
        }

        public ObservableCollection<CountriesInfo> CheckedItems { get; set; }

        public ObservableCollection<CountriesInfo> Items { get; set; }

        public ICommand CheckedClick { get; set; }

        private void OnCheck(CountriesInfo country)
        {
            if (country.IsChecked)
                CheckedItems.Add(country);
            else
                CheckedItems.Remove(country);

            if (country.IsParent && country.IsChecked)
            {
                foreach (var item in country.Models)
                {
                    item.IsChecked = true;
                    if (!CheckedItems.Contains(item))
                        CheckedItems.Add(item);
                }
            }
            else if (country.IsParent)
            {
                foreach (var item in country.Models)
                {
                    item.IsChecked = false;
                    if (CheckedItems.Contains(item))
                        CheckedItems.Remove(item);
                }
            }

        }

    }
}
