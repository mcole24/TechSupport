using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DBAccess;
using TechSupport.Model;

namespace TechSupport.Controller
{
    class IncidentsController
    {

        public IncidentsController() { }

        public List<Incidents> DisplayOpenIncidents(){
            return IncidentsData.DisplayOpenIncidents();
        }

    }
}
