using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPire_Training
{
    public class Instrument
    {
        public enum InstrumentType
        {
            Dumbbel,
            Barbell
        }

        //Fields
        private string instrumentName;
        private int weigth;
        private InstrumentType type;

        //Properties
        #region properties
        public string InstrumentName
        {
            get { return instrumentName; }
            set { instrumentName = value; }
        }

        public int Weigth
        {
            get { return weigth; }
            set { weigth = value; }
        }

        public InstrumentType Type
        {
            get { return type; }
            set { type = value; }
        }
        #endregion

        //Constructor
        public Instrument(string instrumentName, int weigth, InstrumentType type)
        {
            this.instrumentName = instrumentName;
            this.weigth = weigth;
            this.type = type;
        }
    }
}