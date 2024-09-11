    /*
     * Creates an interface for a user to add or edit customer information 
     * Author: Mackenzie Whitney
     * Date: June 2024
     */
namespace ElectricityBillGUI
{
    public partial class frmAddEditCustomer : Form
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfkWhUsed { get; set; }
        
        public frmAddEditCustomer()
        {
            InitializeComponent();
        }

        // show fields to input from. the defaults are blank when adding a customer
        // values to edit are to be shown when in the edit context.
        public frmAddEditCustomer(frmElectricityBill.Operation operation, string firstName="", string lastName="", int kWhUsed=0) // if values passed in are empty, show defaults
        {
            InitializeComponent();
            Text = $"{operation.ToString()} Customer";
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtkWhUsed.Text = kWhUsed.ToString();
            btnAddEdit.Text = operation.ToString();
            btnAddEdit.Click += btnAddEdit_Click;
        }

        // validate inputs with validator then pass the response back if OK.
        private void btnAddEdit_Click(object? sender, EventArgs e)
        {
            if (Validator.IsPresent(txtFirstName) && // validate first name
                Validator.IsPresent(txtLastName) && // valdiate last name
                Validator.IsPresent(txtkWhUsed) &&
                Validator.IsNonNegativeInt(txtkWhUsed)) // validate kWh Used
            {
                FirstName = txtFirstName.Text;
                LastName = txtLastName.Text;
                NumberOfkWhUsed = Int32.Parse(txtkWhUsed.Text);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
