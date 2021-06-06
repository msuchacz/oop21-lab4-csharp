using System;
using System.Collections.Generic;
using Lab4.Interfaces;

namespace Lab4.Models
{
    public class Phone : IDevice
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public OS OperatingSystem { get; set; }
        private List<Application> _installedApplications;

        public Phone()
        {
            _installedApplications = new List<Application>();
        }

        public bool InstallApplication(Application application)
        {
            throw new NotImplementedException();
        }
    }
}