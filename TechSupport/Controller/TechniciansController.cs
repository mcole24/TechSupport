using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;
using TechSupport.DBAccess;

namespace TechSupport.Controller
{
    class TechniciansController
    {
        public TechniciansController() { }

        public static List<Technicians> GetTechnicians()
        {
            return TechniciansData.GetTechnicians();
        }

        public static List<Technicians> GetTechniciansWithIncidents()
        {
            return TechniciansData.GetTechniciansWithIncidents();
        }

        public static Technicians GetTechInfo(int techID)
        {
            return TechniciansData.GetTechInfo(techID);
        }

    }
}
