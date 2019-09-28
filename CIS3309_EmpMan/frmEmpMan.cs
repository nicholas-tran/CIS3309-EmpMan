//Nicholas Tran && Jimmy Pham
//CIS 3309
//Frank Friedman
//EmpMan Final Project
//4/30/2018
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS3309_EmpMan
{
    public partial class frmEmpMan : Form
    {

        // Attributes for click flags used to check which buttons were pressed
        bool clientClick = false;
        bool managerClick = false;
        bool workerClick = false;
        bool findDisplayClick = false;
        bool editUpdateClick = false;
        bool deleteClick = false;
        string serialFile = "serialFile.bin";

        PersonListClass personList = new PersonListClass();
        DatabaseClass db = new DatabaseClass();
        ValidatorClass newValidator = new ValidatorClass();

        // Tool Tips and tool tips strings
        ToolTip toolTip1 = new ToolTip();
        string ttCreateManager = "Click to enter Make Manager mode to add a Manager to the List of Persons.";
        string ttCreateWorker = "Click to enter Make Worker mode to add a Worker to the List of Persons.";
        string ttCreateClient = "Click to enter Make Client mode to add a Client to the List of Persons.";
        string ttClear = "Click to Clear Form.";
        string ttFind = "Click to Find a Person in the List of Persons.";
        string ttDelete = "Click to Delete Person from the List of Persons.";
        string ttEdit = "Click to Edit a Person's data.";
        string ttExit = "Click to exit application.";

        string ttManagerSalary = "Enter dollars and cents.";
        string ttManagerBonus = "Enter dollars and cents.";
        string ttWorkerHourlyPay = "Enter dollars and cents";
        string ttPersonName = "Enter A .. Z and a .. z ONLY";
        string ttPersonBirthDate = "Enter mm/dd/yyyy";
        string ttPersonID = "Enter Exactly 5 Digits";
        string ttEmployeeJobTitle = "Enter Job Title as text";
        string ttClientType = "Enter Client Type as text";
        string ttSearchID = "Enter ID before using Find, Edit, or Delete buttons.";

        // Unparameterized constructor
        public frmEmpMan()
        {
            InitializeComponent();
        }

        // Event handler for then the form loads.
        private void frmEmpMan_Load(object sender, EventArgs e)
        {
            POManagerClass.readFromFile(out personList, serialFile);
            FormControllerClass.enableDisplay(Globals.newForm);
            // get initial Tooltips
            toolTip1.SetToolTip(btnCreateManager, ttCreateManager);
            toolTip1.SetToolTip(btnCreateWorker, ttCreateWorker);
            toolTip1.SetToolTip(btnCreateClient, ttCreateClient);
            toolTip1.SetToolTip(btnClearEntryForm, ttClear);
            toolTip1.SetToolTip(btnDelete, ttDelete);
            toolTip1.SetToolTip(btnEditUpdate, ttEdit);
            toolTip1.SetToolTip(btnFindDisplay, ttFind);
            toolTip1.SetToolTip(btnExit, ttExit);
            toolTip1.SetToolTip(txtControlManagerSalary, ttManagerSalary);
            toolTip1.SetToolTip(txtControlManagerBonus, ttManagerBonus);
            toolTip1.SetToolTip(txtControlWorkerHourlyPay, ttWorkerHourlyPay);
            toolTip1.SetToolTip(txtControlPersonName, ttPersonName);
            toolTip1.SetToolTip(txtControlPersonBirthDate, ttPersonBirthDate);
            toolTip1.SetToolTip(txtControlPersonID, ttPersonID);
            toolTip1.SetToolTip(txtControlEmployeeJobTitle, ttEmployeeJobTitle);
            toolTip1.SetToolTip(txtControlClientType, ttClientType);
            toolTip1.SetToolTip(txtControlSearchID, ttSearchID);
        }

        // Button event handler for the creating clients
        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            clientClick = true;
            managerClick = false;
            workerClick = false;
            FormControllerClass.activatePerson(this);
            FormControllerClass.activateClient(this);
            FormControllerClass.deactivateEmployee(this);
            FormControllerClass.deactivateManager(this);
            FormControllerClass.deactivateWorker(this);

        }

        // Button event handler for creating managers
        private void btnCreateManager_Click(object sender, EventArgs e)
        {
            managerClick = true;
            clientClick = false;
            workerClick = false;
            FormControllerClass.deactivateClient(this);
            FormControllerClass.deactivateWorker(this);
            FormControllerClass.activatePerson(this);
            FormControllerClass.activateEmployee(this);
            FormControllerClass.activateManager(this);
        }

        // Button event handler for creating workers
        private void btnCreateWorker_Click(object sender, EventArgs e)
        {
            workerClick = true;
            clientClick = false;
            managerClick = false;
            FormControllerClass.deactivateClient(this);
            FormControllerClass.deactivateManager(this);
            FormControllerClass.activatePerson(this);
            FormControllerClass.activateEmployee(this);
            FormControllerClass.activateWorker(this);
        }

        // Button event handler for the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            POManagerClass.writeToFile(ref personList, serialFile);
            MessageBox.Show(personList.ListString());
            Application.Exit();
        }

        // Button event handler to clear the form
        private void btnClearEntryForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form is cleared.");
            FormControllerClass.clear(this);
            FormControllerClass.enableDisplay(Globals.newForm);
        }

        // Button event handler for the OK button
        // Flags used for the Client, Manager, and Worker
        // Depending on which button was pressed, the form changes to what is needed
        // Validation and Insert to SFile and DB done as well
        private void btnOk_Click(object sender, EventArgs e)
        {

            // After the client button is clicked
            // Adds data related to the client to the serializable file and database
            if (clientClick == true)
            {
                //Validating ID
                if (newValidator.IsValidID(txtControlPersonID.Text) == false)
                {
                    MessageBox.Show("Invalid ID");
                    return;
                }

                //Validating name
                if (newValidator.IsValidEnglishCharacters(txtControlPersonName.Text) == false)
                {
                    MessageBox.Show("Invalid name.");
                    return;
                }

                //Validating date
                if (newValidator.IsValidDate(txtControlPersonBirthDate.Text) == false)
                {
                    MessageBox.Show("Invalid date.");
                    return;
                }

                //Validating client
                if (newValidator.IsValidEnglishCharacters(txtControlClientType.Text) == false)
                {
                    MessageBox.Show("Invalid Client Type");
                    return;
                }

                bool foundID = false;
                foreach (PersonClass personObject in personList.getPersonList())
                {
                    if (txtControlPersonID.Text == personObject.personID)
                    {
                        foundID = true;
                    }
                }
                if (foundID == true)
                {
                    MessageBox.Show("Person already inside serializable file.");
                }

                foundID = false;
                db.findDuplicateID(Convert.ToInt32(txtControlPersonID.Text), ref foundID);

                if (foundID == true)
                {
                    MessageBox.Show("Person is already inside Database.");
                    return;
                }

                ClientClass newClient = new ClientClass(txtControlPersonName.Text, txtControlPersonBirthDate.Text, txtControlPersonID.Text, txtControlClientType.Text);
                personList.getPersonList().Add(newClient);
                db.InsertPerson(Convert.ToInt32(txtControlPersonID.Text), txtControlPersonName.Text, txtControlPersonBirthDate.Text);
                db.InsertClient(Convert.ToInt32(txtControlPersonID.Text), txtControlClientType.Text);
                MessageBox.Show("Client has been added.");
            }
            // After the manger button is clicked
            // Adds manager related data to the serializable file and database
            else if (managerClick == true)
            {
                //Validating ID
                if (newValidator.IsValidID(txtControlPersonID.Text) == false)
                {
                    MessageBox.Show("Invalid ID");
                    return;
                }

                //Validating name
                if (newValidator.IsValidEnglishCharacters(txtControlPersonName.Text) == false)
                {
                    MessageBox.Show("Invalid name.");
                    return;
                }

                //Validating date
                if (newValidator.IsValidDate(txtControlPersonBirthDate.Text) == false)
                {
                    MessageBox.Show("Invalid date.");
                    return;
                }

                //Job Title
                if (newValidator.IsValidEnglishCharacters(txtControlEmployeeJobTitle.Text) == false)
                {
                    MessageBox.Show("Invalid Job Title.");
                    return;
                }


                //Salary
                if (newValidator.IsValidCurrency(txtControlManagerSalary.Text) == false)
                {
                    MessageBox.Show("Invalid Manager Currency.");
                    return;
                }

                //Bonus 
                if (newValidator.IsValidCurrency(txtControlManagerBonus.Text) == false)
                {
                    MessageBox.Show("Invalid Manager Bonus.");
                    return;
                }

                //End of Validations

                bool foundID = false;
                foreach (PersonClass personObject in personList.getPersonList())
                {
                    if (txtControlPersonID.Text == personObject.personID)
                    {
                        foundID = true;
                    }
                }
                if (foundID == true)
                {
                    MessageBox.Show("Person already inside serializable file.");
                }

                foundID = false;
                db.findDuplicateID(Convert.ToInt32(txtControlPersonID.Text), ref foundID);

                if (foundID == true)
                {
                    MessageBox.Show("Person is already inside Database.");
                    return;
                }
                ManagerClass newManager = new ManagerClass(txtControlPersonName.Text, txtControlPersonBirthDate.Text, txtControlPersonID.Text, txtControlEmployeeJobTitle.Text, Convert.ToDecimal(txtControlManagerSalary.Text), Convert.ToDecimal(txtControlManagerBonus.Text));
                personList.getPersonList().Add(newManager);
                db.InsertPerson(Convert.ToInt32(txtControlPersonID.Text), txtControlPersonName.Text, txtControlPersonBirthDate.Text);
                db.InsertEmployee(Convert.ToInt32(txtControlPersonID.Text), txtControlEmployeeJobTitle.Text);
                db.InsertManager(Convert.ToInt32(txtControlPersonID.Text), Convert.ToDecimal(txtControlManagerSalary.Text), Convert.ToDecimal(txtControlManagerBonus.Text));
                MessageBox.Show("Manager has been added.");
            }
            // After the worker button has been clicked
            // Data related to the worker is added to the serializable file and database
            else if (workerClick == true)
            {

                //Validating ID
                if (newValidator.IsValidID(txtControlPersonID.Text) == false)
                {
                    MessageBox.Show("Invalid ID");
                    return;
                }

                //Validating name
                if (newValidator.IsValidEnglishCharacters(txtControlPersonName.Text) == false)
                {
                    MessageBox.Show("Invalid name.");
                    return;
                }

                //Validating date
                if (newValidator.IsValidDate(txtControlPersonBirthDate.Text) == false)
                {
                    MessageBox.Show("Invalid date.");
                    return;
                }

                //Job Title
                if (newValidator.IsValidEnglishCharacters(txtControlEmployeeJobTitle.Text) == false)
                {
                    MessageBox.Show("Invalid Job Title.");
                    return;
                }

                //Hourly Pay
                if (newValidator.IsValidCurrency(txtControlWorkerHourlyPay.Text) == false)
                {
                    MessageBox.Show("Invalid Hourly Pay.");
                    return;
                }

                bool foundID = false;
                foreach (PersonClass personObject in personList.getPersonList())
                {
                    if (txtControlPersonID.Text == personObject.personID)
                    {
                        foundID = true;
                    }
                }
                if (foundID == true)
                {
                    MessageBox.Show("Person already inside serializable file.");
                }

                foundID = false;
                db.findDuplicateID(Convert.ToInt32(txtControlPersonID.Text), ref foundID);

                if (foundID == true)
                {
                    MessageBox.Show("Person is already inside Database.");
                    return;
                }


                WorkerClass newWorker = new WorkerClass(txtControlPersonName.Text, txtControlPersonBirthDate.Text, txtControlPersonID.Text, txtControlEmployeeJobTitle.Text, Convert.ToDecimal(txtControlWorkerHourlyPay.Text));
                personList.getPersonList().Add(newWorker);
                db.InsertPerson(Convert.ToInt32(txtControlPersonID.Text), txtControlPersonName.Text, txtControlPersonBirthDate.Text);
                db.InsertEmployee(Convert.ToInt32(txtControlPersonID.Text), txtControlEmployeeJobTitle.Text);
                db.InsertWorker(Convert.ToInt32(txtControlPersonID.Text), Convert.ToDecimal(txtControlWorkerHourlyPay.Text));
                MessageBox.Show("Worker has been added.");
            }
            //After the user clicks on the update button
            //Adds data from the text fields to the serializable file and the database
            else if (editUpdateClick == true)
            {
                //Validating ID
                if (newValidator.IsValidID(txtControlSearchID.Text) == false)
                {
                    MessageBox.Show("Invalid ID");
                    return;
                }

                foreach (PersonClass personObject in personList.getPersonList())
                {
                    if (txtControlSearchID.Text == personObject.personID)
                    {
                        if (personObject.GetType() == typeof(ClientClass))
                        {

                            //Validating client
                            if (newValidator.IsValidEnglishCharacters(txtControlClientType.Text) == false)
                            {
                                MessageBox.Show("Invalid Client Type");
                                return;
                            }

                            DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit the following item?", "Edit Confirmation", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                personObject.Save(Globals.newForm);
                                db.UpdatePerson(txtControlPersonID.Text, txtControlPersonName.Text, txtControlPersonBirthDate.Text);
                                db.UpdateClient(Convert.ToInt32(txtControlPersonID.Text), txtControlClientType.Text);
                                MessageBox.Show("Updating Client.");
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                MessageBox.Show("Edit canceled.");
                            }

                        }
                        if (personObject.GetType() == typeof(ManagerClass))
                        {
                            //Job Title
                            if (newValidator.IsValidEnglishCharacters(txtControlEmployeeJobTitle.Text) == false)
                            {
                                MessageBox.Show("Invalid Job Title.");
                                return;
                            }

                            //Salary
                            if (newValidator.IsValidCurrency(txtControlManagerSalary.Text) == false)
                            {
                                MessageBox.Show("Invalid Manager Currency.");
                                return;
                            }

                            //Bonus 
                            if (newValidator.IsValidCurrency(txtControlManagerBonus.Text) == false)
                            {
                                MessageBox.Show("Invalid Manager Bonus.");
                                return;
                            }


                            DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit the following item?", "Edit Confirmation", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                personObject.Save(Globals.newForm);
                                db.UpdatePerson(txtControlPersonID.Text, txtControlPersonName.Text, txtControlPersonBirthDate.Text);
                                db.UpdateEmployee(Convert.ToInt32(txtControlPersonID.Text), txtControlEmployeeJobTitle.Text);
                                db.UpdateManager(Convert.ToInt32(txtControlPersonID.Text), Convert.ToDecimal(txtControlManagerSalary.Text), Convert.ToDecimal(txtControlManagerBonus.Text));
                                MessageBox.Show("Updating Manager.");
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                MessageBox.Show("Edit canceled.");
                            }

                        }
                        if (personObject.GetType() == typeof(WorkerClass))
                        {

                            //Job Title
                            if (newValidator.IsValidEnglishCharacters(txtControlEmployeeJobTitle.Text) == false)
                            {
                                MessageBox.Show("Invalid Job Title.");
                                return;
                            }

                            //Hourly Pay
                            if (newValidator.IsValidCurrency(txtControlWorkerHourlyPay.Text) == false)
                            {
                                MessageBox.Show("Invalid Hourly Pay.");
                                return;
                            }

                            DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit the following item?", "Edit Confirmation", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {

                                personObject.Save(Globals.newForm);
                                db.UpdatePerson(txtControlPersonID.Text, txtControlPersonName.Text, txtControlPersonBirthDate.Text);
                                db.UpdateEmployee(Convert.ToInt32(txtControlPersonID.Text), txtControlEmployeeJobTitle.Text);
                                db.UpdateWorker(Convert.ToInt32(txtControlPersonID.Text), Convert.ToDecimal(txtControlWorkerHourlyPay.Text));
                                MessageBox.Show("Updating Worker.");
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                MessageBox.Show("Edit canceled.");
                            }
                        }
                    }
                }

            }
            // After the delete button is clicked
            // Person data is removed from the serializable file and the database
            else if (deleteClick == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the following item?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < personList.getPersonList().Count; i++)
                    {
                        if (personList.getPersonList().ElementAt(i).personID == txtControlPersonID.Text)
                        {
                            personList.getPersonList().RemoveAt(i);
                        }
                    }

                    MessageBox.Show("Deleting person with ID: " + txtControlPersonID.Text);
                    db.Delete(Convert.ToInt32(txtControlPersonID.Text));
                    FormControllerClass.clear(Globals.newForm);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Deletion canceled.");
                }
            }
        }

        // Button event handler to display data from Database
        // Validation is also done for the entered ID before data is shown.
        private void btnFindDisplay_Click(object sender, EventArgs e)
        {

            if (newValidator.IsValidID(txtControlSearchID.Text) == false)
            {
                MessageBox.Show("Invalid ID");
                return;
            }

            FormControllerClass.clear(Globals.newForm);
            FormControllerClass.enableDisplay(Globals.newForm);

            bool foundID = false;
            foreach (PersonClass personObject in personList.getPersonList())
            {
                if (txtControlSearchID.Text == personObject.personID)
                {
                    foundID = true;
                }
            }
            if (foundID == false)
            {
                MessageBox.Show("ID not found inside serializable file.");
                return;
            }

            int id = 0;
            string name = "";
            DateTime birthDate = DateTime.Today;
            string type = "";
            string title = "";
            decimal salary = 0;
            decimal bonus = 0;
            decimal hourlyPay = 0;
            bool isPerson = false;
            bool isClient = false;
            bool isEmployee = false;
            bool isManager = false;
            bool isWorker = false;
            db.Select(Convert.ToInt32(txtControlSearchID.Text), ref id, ref name, ref birthDate, ref type, ref title, ref salary, ref bonus, ref hourlyPay,
                ref isPerson, ref isClient, ref isEmployee, ref isManager, ref isWorker);
            if (isPerson == true)
            {
                txtControlPersonID.Text = Convert.ToString(id);
                txtControlPersonName.Text = name;
                txtControlPersonBirthDate.Text = birthDate.ToString("MM/dd/yyyy");
            }
            if(isPerson == false)
            {
                MessageBox.Show("Not found inside database.");
                return;
            }
            if (isClient == true)
            {
                txtControlClientType.Text = type;
            }
            if (isEmployee == true)
            {
                txtControlEmployeeJobTitle.Text = title;
            }
            if (isManager == true)
            {
                txtControlManagerSalary.Text = Convert.ToString(salary);
                txtControlManagerBonus.Text = Convert.ToString(bonus);
            }
            if (isWorker == true)
            {
                txtControlWorkerHourlyPay.Text = Convert.ToString(hourlyPay);
            }

            MessageBox.Show("Find Button Clicked");
            findDisplayClick = true;
            editUpdateClick = false;
            deleteClick = false;
            FormControllerClass.deactivateAddButtons(this);
        }

        // Button event handler for Edit/Update button
        // Validation is done as well as displaying data for the person with matching ID
        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            if (newValidator.IsValidID(txtControlSearchID.Text) == false)
            {
                MessageBox.Show("Invalid ID");
                return;
            }
            FormControllerClass.clear(Globals.newForm);

            bool foundID = false;
            foreach (PersonClass personObject in personList.getPersonList())
            {
                if (txtControlSearchID.Text == personObject.personID)
                {
                    foundID = true;
                }
            }
            if (foundID == false)
            {
                MessageBox.Show("ID not found inside serializable file.");
                return;
            }

            int id = 0;
            string name = "";
            DateTime birthDate = DateTime.Today;
            string type = "";
            string title = "";
            decimal salary = 0;
            decimal bonus = 0;
            decimal hourlyPay = 0;
            bool isPerson = false;
            bool isClient = false;
            bool isEmployee = false;
            bool isManager = false;
            bool isWorker = false;
            db.Select(Convert.ToInt32(txtControlSearchID.Text), ref id, ref name, ref birthDate, ref type, ref title, ref salary, ref bonus, ref hourlyPay,
                ref isPerson, ref isClient, ref isEmployee, ref isManager, ref isWorker);
            if (isPerson == true)
            {
                FormControllerClass.enableDisplay(Globals.newForm);
                txtControlPersonID.Text = Convert.ToString(id);
                txtControlPersonName.Text = name;
                txtControlPersonBirthDate.Text = birthDate.ToString("MM/dd/yyyy");
            }
            if (isPerson == false)
            {
                MessageBox.Show("Not found inside database.");
                return;
            }
            if (isClient == true)
            {
                FormControllerClass.activateClient(Globals.newForm);
                txtControlClientType.Text = type;
            }
            if (isEmployee == true)
            {
                FormControllerClass.activateEmployee(Globals.newForm);
                txtControlEmployeeJobTitle.Text = title;
            }
            if (isManager == true)
            {
                FormControllerClass.activateManager(Globals.newForm);
                txtControlManagerSalary.Text = Convert.ToString(salary);
                txtControlManagerBonus.Text = Convert.ToString(bonus);
            }
            if (isWorker == true)
            {
                FormControllerClass.activateWorker(Globals.newForm);
                txtControlWorkerHourlyPay.Text = Convert.ToString(hourlyPay);
            }

            MessageBox.Show("Update Button Clicked");
            findDisplayClick = false;
            editUpdateClick = true;
            deleteClick = false;
            FormControllerClass.deactivateAddButtons(this);

        }

        // Button event handler for the delete button
        // Displays person data from which the user enters
        // Validates to make sure the entered ID matches and is valid
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (newValidator.IsValidID(txtControlSearchID.Text) == false)
            {
                MessageBox.Show("Invalid ID");
                return;
            }

            FormControllerClass.clear(Globals.newForm);
            FormControllerClass.enableDisplay(Globals.newForm);

            bool foundID = false;
            foreach (PersonClass personObject in personList.getPersonList())
            {
                if (txtControlSearchID.Text == personObject.personID)
                {
                    foundID = true;
                }
            }
            if (foundID == false)
            {
                MessageBox.Show("ID not found inside serializable file.");
                return;
            }

            int id = 0;
            string name = "";
            DateTime birthDate = DateTime.Today;
            string type = "";
            string title = "";
            decimal salary = 0;
            decimal bonus = 0;
            decimal hourlyPay = 0;
            bool isPerson = false;
            bool isClient = false;
            bool isEmployee = false;
            bool isManager = false;
            bool isWorker = false;
            db.Select(Convert.ToInt32(txtControlSearchID.Text), ref id, ref name, ref birthDate, ref type, ref title, ref salary, ref bonus, ref hourlyPay,
                ref isPerson, ref isClient, ref isEmployee, ref isManager, ref isWorker);
            if (isPerson == true)
            {
                txtControlPersonID.Text = Convert.ToString(id);
                txtControlPersonName.Text = name;
                txtControlPersonBirthDate.Text = birthDate.ToString("MM/dd/yyyy");
            }
            if (isPerson == false)
            {
                MessageBox.Show("Not found inside database.");
                return;
            }
            if (isClient == true)
            {
                txtControlClientType.Text = type;
            }
            if (isEmployee == true)
            {
                txtControlEmployeeJobTitle.Text = title;
            }
            if (isManager == true)
            {
                txtControlManagerSalary.Text = Convert.ToString(salary);
                txtControlManagerBonus.Text = Convert.ToString(bonus);
            }
            if (isWorker == true)
            {
                txtControlWorkerHourlyPay.Text = Convert.ToString(hourlyPay);
            }

            MessageBox.Show("Delete Button Clicked.");
            findDisplayClick = false;
            editUpdateClick = false;
            deleteClick = true;
            FormControllerClass.deactivateAddButtons(this);
        }
    }
}
