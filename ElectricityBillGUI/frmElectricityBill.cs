    /*
     * Creates an interface for a user to see customer information,
     * statistics, and show buttons to add/edit/delete customer information
     * Author: Mackenzie Whitney
     * Date: June 2024
     */
using UnitTests;

namespace ElectricityBillGUI
{
    public partial class frmElectricityBill : Form
    {
        public enum Operation { Add, Edit };
        int lastIndex = 0;
        List<Customer> customers = new List<Customer>();

        public frmElectricityBill()
        {
            InitializeComponent();
        }

        private void frmElectricityBill_Load(object sender, EventArgs e)
        {
            customers.Add(new Customer("Test", "User", 100)); // test user using full constructor.
            customers.Add(new Customer("Hello", "World")); // test without specifying kWh
            customers.Add(new Customer("Mister", "Negative", -100)); // test bad kWh
            UpdateDisplay();
        }

        // initializes display and statistics
        private void UpdateDisplay()
        {
            lstCustomers.Items.Clear();
            foreach (Customer customer in customers)
            {
                lstCustomers.Items.Add(customer); // calls ToString() method of Customer class
            }
            // when editing customer, make sure the selection doesn't change.
            lstCustomers.SelectedIndex = lastIndex;
            DisplayStatistics(); 
        }

        // display statistics on the page. made separate from UpdateDisplay for readability
        private void DisplayStatistics()
        {
            // show number of customers
            txtNumCustomers.Text = customers.Count.ToString();

            // show kWh count
            int kWhCount = 0;
            foreach (Customer customer in customers)
            {
                kWhCount += customer.NumberOfkWhUsed;
            }
            txtkWhUsed.Text = kWhCount.ToString();

            // show Average bill amount
            if (customers.Count == 0) // to prevent division by 0 error
            {
                txtAvgBillAmt.Text = "0";
            }
            else
            {
                double sumBillAmt = 0;
                foreach (Customer customer in customers)
                {
                    sumBillAmt += customer.BillAmount;
                }
                double avgBillAmt = sumBillAmt / customers.Count;
                txtAvgBillAmt.Text = avgBillAmt.ToString("c");
            }
        }

        // add customer passes in Add enum to frmAddEditCustomer form
        // when response is OK, add customer to list and update display
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer addCustomer = new frmAddEditCustomer(Operation.Add);
            DialogResult result = addCustomer.ShowDialog();
            if (result == DialogResult.OK)
            {
                customers.Add(new Customer(addCustomer.FirstName, addCustomer.LastName, addCustomer.NumberOfkWhUsed));
            }
            UpdateDisplay();

        }

        // edit customer passes in Edit enum to frmAddEditCustomer form
        // when response is OK, edit customer on list and update display
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            // ensure customer is selected
            if (lstCustomers.SelectedIndex == -1) // no selection
            {
                MessageBox.Show("You must select a customer first");
                lstCustomers.Focus();
            }
            else
            {
                lastIndex = lstCustomers.SelectedIndex;
                Customer customer = customers[lastIndex];
                frmAddEditCustomer editCustomer = new frmAddEditCustomer(Operation.Edit, customer.FirstName, customer.LastName, customer.NumberOfkWhUsed);
                DialogResult result = editCustomer.ShowDialog();
                if (result == DialogResult.OK)
                {
                    customer.FirstName = editCustomer.FirstName;
                    customer.LastName = editCustomer.LastName;
                    customer.NumberOfkWhUsed = editCustomer.NumberOfkWhUsed;
                }
                UpdateDisplay();
            }

        }

        // delete customer from the listbox
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            // ensure customer is selected
            if (lstCustomers.SelectedIndex == -1) // no selection
            {
                MessageBox.Show("You must select a customer first");
                lstCustomers.Focus();
            }
            else
            {
                Customer customer = customers[lstCustomers.SelectedIndex];
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete customer?", 
                    "Confirmation", 
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    customers.RemoveAt(lstCustomers.SelectedIndex);
                }
                lastIndex = -1;
                UpdateDisplay();
            }
        }
    }
}
