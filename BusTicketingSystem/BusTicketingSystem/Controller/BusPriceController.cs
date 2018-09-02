using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using BusTicketingSystem.Model;

namespace BusTicketingSystem.Controller
{
    public class BusPriceController
    {
        private ObservableCollection<BusPrice> busprices;
        public ObservableCollection<BusPrice> BusPrices
        {
            get { return busprices; }
            set { busprices = value; }
        }


        public BusPriceController()
        {

            BusPrices = new ObservableCollection<BusPrice>();

            Data _context1 = new Data();

            foreach (var buspri in _context1.BPrces)
            {
                BusPrices.Add(buspri);
            }
        }
    }
}

