using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using BusTicketingSystem.Model;


namespace BusTicketingSystem.Controller
{
    public class BusScheduleController
    {
        private ObservableCollection<BusSchedule> busschedules;
       public ObservableCollection<BusSchedule> BusSchedules {
            get {return busschedules; }
            set { busschedules = value; }
        }
     

        public BusScheduleController()
        {

            BusSchedules = new ObservableCollection<BusSchedule>();

            Data _context = new Data();

            foreach (var bussched in _context.BSched)
            {
                BusSchedules.Add(bussched);
            }
        }
    }
}
