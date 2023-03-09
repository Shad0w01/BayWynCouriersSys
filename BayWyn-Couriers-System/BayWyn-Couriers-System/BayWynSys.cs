namespace BayWyn_Couriers_System
{
    internal class BayWynSys
    {
        private int c_id;
        private string c_Fname;
        private string c_LName;
        private string c_Tel;
        private string c_Email;
        private int c_NumofOrds;

        public int CourierID
        {
            get
            {
                return c_id;
            }

            set
            {
                c_id = value;
            }
        }

        public string CourierFirstName
        {
            get
            {
                return c_Fname;
            }

            set
            {
                c_Fname = value;
            }
        }

        public string CourierLastName
        {
            get
            {
                return c_LName;
            }

            set
            {
                c_LName = value;
            }
        }

        public string CourierTelephone
        {
            get
            {
                return c_Tel;
            }

            set
            {
                c_Tel = value;
            }
        }

        public string CourierEmail
        {
            get
            {
                return c_Email;
            }

            set
            {
                c_Email = value;
            }
        }
        public int CourierNumofOrders
        {
            get
            {
                return c_NumofOrds;
            }

            set
            {
                c_NumofOrds = value;
            }
        }
    }
}
