using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Danger
    {
        DateTime accDate; // accident date
        string accTimestamp;
        string accType;
        string accLocation;
        string accDescr;

        public DateTime AccDate
        {
            get
            {
                return accDate;
            }

            set
            {
                accDate = value;
            }
        }

        public string AccType
        {
            get
            {
                return accType;
            }

            set
            {
                accType = value;
            }
        }

        public string AccLocation
        {
            get
            {
                return accLocation;
            }

            set
            {
                accLocation = value;
            }
        }

        public string AccDescr
        {
            get
            {
                return accDescr;
            }

            set
            {
                accDescr = value;
            }
        }

        public string AccTimestamp
        {
            get
            {
                return accTimestamp;
            }

            set
            {
                accTimestamp = value;
            }
        }
    }
}
