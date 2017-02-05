using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    class Incidents
    {

        public Incidents() { }

        public int IncidentID { get; set; }

        public int CustomerID { get; set; }

        public string ProductCode { get; set; }

        public int TechID { get; set; }

        public DateTime DateOpened { get; set; }

        public DateTime DateClosed { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string CustomerName { get; set; }

        public string Technician { get; set; }

    }
}
