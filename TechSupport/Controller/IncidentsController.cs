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

        public void AddIncident(Incidents inc)
        {
            IncidentsData.AddIncident(inc);
        }

        public static Incidents GetIncident(int incidentID)
        {
            return IncidentsData.GetIncident(incidentID);
        }

        public static bool CloseIncident(int incidentID)
        {
            return IncidentsData.CloseIncident(incidentID);
        }

        public static bool UpdateIncident(Incidents oldInc, Incidents newInc)
        {
            return IncidentsData.UpdateIncident(oldInc, newInc);
        }

        public static List<Incidents> GetIncidentsByTechnician(int TechID)
        {
            return IncidentsData.GetIncidentsByTechnician(TechID);
        }


    }
}
