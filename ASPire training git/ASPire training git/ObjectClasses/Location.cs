using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPire_Training
{
    public class Location
    {
        //Fields
        private string locationName;
        private string postalcode;
        private string houseNumber;

        //Properties
        #region properties
        public string LocationName
        {
            get { return locationName; }
            set { locationName = value; }
        }

        public string Postalcode
        {
            get { return postalcode; }
            set { postalcode = value; }
        }

        public string HouseNumber
        {
            get { return houseNumber; }
            set { houseNumber = value; }
        }
        #endregion

        //Constructor
        public Location(string locationName, string postalcode, string houseNumber)
        {
            this.locationName = locationName;
            this.postalcode = postalcode;
            this.houseNumber = houseNumber;
        }
    }
}