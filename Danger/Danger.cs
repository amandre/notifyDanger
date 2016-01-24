using System;

namespace Dangers
{
    /// <summary>
    ///  Class Danger describes the danger and its specified information.
    ///  These information are:
    ///  accTimestamp            time when danger occured
    ///  accType                 type of the danger
    ///  accLocation             location where this danger had place
    ///  accDescr                briefly describes what exactely happened
    /// </summary>
    public class Danger
    {
        /// accident date
        DateTime accDate;
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
