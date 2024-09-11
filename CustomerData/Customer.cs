/*
     * Defines customer data to be used in application
     * Author: Mackenzie Whitney
     * Date: June 2024
     */
namespace UnitTests
{
    public class Customer
    {
        private int accountNumber;
        private string firstName;
        private string lastName;
        private int numberOfkWhUsed;
        private int nextNo = 100; // static data to generate account numbers

        // constant
        private int TOTAL_WIDTH = 30;

        public int AccountNo { get { return accountNumber; } } // read-only
        public double BillAmount { get { return CalculateCharge(numberOfkWhUsed); } } //read-only
        public string FirstName {
            get { return firstName; }
            set { firstName = (value != null && value != "") ? value : firstName = "Unknown"; } // if not initialized, first name is "Unknown"
        }
        public string LastName {
            get { return lastName; }
            set { lastName = (value != null && value != "") ? value : firstName = "Unknown"; } // if not initialized, last name is "Unknown"
        }

        public int NumberOfkWhUsed { 
            get { return numberOfkWhUsed; } 
            set { numberOfkWhUsed = (value < 0) ? 0 : value; }
        }

        // UI doesn't allow users to add customers with unknown first or last names, or negative kwh used,
        // but we allow it when defining a customer in the code as we wouldn't know what an existing database is like
        public Customer(string firstName, string lastName, int numberOfkWhUsed=0) // if not initialized kWhUsed = 0 
        {
            accountNumber = nextNo++;
            FirstName = firstName;
            LastName = lastName;
            NumberOfkWhUsed = numberOfkWhUsed;
        }

        public override string ToString()
        {
            // padding used to try and align unless one of these strings is longer than a certain width of char
            // the font of the ListBox also has to be monospaced for this to be shown correctly;
            string nameString = $"{FirstName} {LastName}".PadRight(TOTAL_WIDTH, ' ');
            string kwHString = $"Number of kWh: { NumberOfkWhUsed}".PadRight(TOTAL_WIDTH, ' ');
            string billAmtString = $"Bill: {BillAmount.ToString("c")}"; // no need to pad since at the end.
            return $"{nameString}|{kwHString}|{billAmtString}";
        }

        public double CalculateCharge(int numberOfkWhUsed)
        {
            return 12+numberOfkWhUsed*0.07;
        }

    }
}
