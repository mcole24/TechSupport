using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    class Incidents
    {

        private int incidentID;
        private int customerID;
        private string productCode;
        private int techID;
        private DateTime dateOpened;
        private DateTime dateClosed;
        private string title;
        private string description;
        private string customerName;
        private string technician;

        public Incidents() { }

        public int getIncidentID() { return incidentID; }
        public void setIncidentID(int input) { incidentID = input; }

        public int getCustomerID() { return customerID; }
        public void setCustomerID(int input) { customerID = input; }

        public string getProductCode() { return productCode; }
        public void setProductCode(string input) { productCode = input; }

        public int getTechID() { return techID; }
        public void setTechID(int input) { techID = input; }

        public DateTime getDateOpened() { return dateOpened; }
        public void setDateOpened(DateTime input) { dateOpened = input; }

        public DateTime getDateClosed() { return dateClosed; }
        public void setDateClosed(DateTime input) { dateClosed = input; }

        public string getTitle() { return title; }
        public void setTitle(string input) { title = input; }

        public string getDescription() { return description; }
        public void setDescription(string input) { description = input; }

        public string getCustomerName() { return customerName; }
        public void setCustomerName(string input) { customerName = input; }

        public string getTechnician() { return technician; }
        public void setTechnician(string input) { technician = input; }

    }
}
