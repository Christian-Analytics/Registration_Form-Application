// Programmer: Christian Castillo
// Description: Registration form interface for Hopkins Film School
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Allows us to use StreamWriter and StreamReader Class
using System;

namespace Castillo_4
{
    public partial class RegistrationForm : Form
    {
        // Declaring class level constants for pricing and maximum classes
        private const decimal LIVE_ACTION_CLASS_PRICE = 79.95m;
        private const decimal ANIMATION_CLASS_PRICE = 99.95m;
        private const int MAXIMUM_CLASSES = 4;

        // Declaring class level variables for use in calculating totals
        private decimal subtotal = 0m;
        private int numberOfClasses = 0;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        // Handle registration form's start up event handler to populate all the boxes based on default selections
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // Declare string array to diplay registrant status options
            string[] registrantStatus = { "Actor", "Producer", "Director", "Animator", "Cinematographer", "Drama Teacher", "Light Technician", "Sound Technician" };
            
            // Use foreach Loop to assign registrant status array to combo box
            foreach (string status in registrantStatus)
            {
                registrantStatusComboBox.Items.Add(status); // Assigns any values from the registrant status array to the combo box
            }

            // Displays costs on form and maximum number of classes based on constants
            liveActionPriceLabel.Text = LIVE_ACTION_CLASS_PRICE.ToString("c");
            animationPriceLabel.Text = ANIMATION_CLASS_PRICE.ToString("c");
            maximumSelectionsLabel.Text = "(max. classes: " + MAXIMUM_CLASSES.ToString() + ")";

            // Displays current date as reported by system clock in registration date masked text box
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            //Calls custom method to populate classes list box
            PopulateList();

            //Calls custom method to update totals based on default selections
            UpdateTotals();
        }

        // Handles live action radio button's checked changed event
        private void liveActionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PopulateList(); // Updates classes displayed based on selection (Live Action or Animation)
            UpdateTotals(); // Updates totals based on new selection (price per class depending on which radio button is selected)
        }

        // Handles the class list box index changed event to update totals based on how many classes are selected
        private void classListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotals(); // Displays costs on form and totals based on selections

        }

        // Handles the clear menu item's event handler to clear the form
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm(); // Calls custom method to clear the form
        }

        // Handles the exit menu item's event handler to prompt a confirmation message
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to exit the program?", // Displays a confirmation message box
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes) // If user confirms they want to close the program, close the program
            {
                this.Close();
            }
        }

        // Handles the save menu item's event handler to display a summary of registration information and write data to external file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declares strings for use in MessageBox.Show method from radio button selected and listbox indices selected
            string classType = "";
            string classSelection = "";
            string paymentType = "";
            string emailRequested = "";

            try // Attempts to assign string variables for use in MessageBox.Show method and write data to external file
            {

                // Assigns class type string based on which radio button is selected by the user
                if(liveActionRadioButton.Checked)
                {
                    classType = liveActionRadioButton.Text;
                }
                else
                {
                    classType = animationRadioButton.Text;
                }

                // Assigns payment type string based on which radio button is selected by the user
                if(cashRadioButton.Checked) 
                {
                    paymentType = cashRadioButton.Text;
                }
                else 
                {
                    paymentType = animationRadioButton.Text;
                }

                // Assigns Yes or No to email requested variable based on user selection
                if(emailReceiptRequestedCheckBox.Checked) 
                {
                    emailRequested = "Yes";
                }
                else
                {
                    emailRequested = "No";
                }

                // Assigns class selection string based on whatever is selected from the class list box
                foreach (string selectedItem in classListBox.SelectedItems)
                {
                    classSelection += selectedItem + "\n";
                }

                // Display an error message if registrant name fields, email address field, or date of birth field is incomplete 
                if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "" || emailAddressTextBox.Text == "" || dateOfBirthMaskedTextBox.MaskCompleted == false)
                {
                    MessageBox.Show("Please ensure first name, last name, email, and date of birth fields are properly inputted.",
                        "Fields left incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (numberOfClasses < 1 || numberOfClasses > MAXIMUM_CLASSES) // If there are no classes or more than 4 (current maximum) classes selected, display an error message
                {
                    MessageBox.Show("1-4 Class Selections are Required.",
                        "Class Selections Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // Display a Message displaying a summary of the registration information and write the summary information to external file
                {
                    // Display a Message Box showing a summary of registration information
                    MessageBox.Show("Registration Summary\n" +
                    "Registration Date: " + dateMaskedTextBox.Text + "\n" +
                    "Registrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" +
                    "Email Address: " + emailAddressTextBox.Text + "\n" +
                    "Date of Birth: " + dateOfBirthMaskedTextBox.Text + "\n" +
                    "Status: " + registrantStatusComboBox.Text + "\n" +
                    "Classes Selected: " + classSelection + "\n" +
                    "Number of Classes: " + numberOfClasses + "\n" +
                    "Price per class: " + pricePerClassLabel.Text + "\n" +
                    "Total Registration Price: " + totalPriceLabel.Text + "\n" +
                    "Payment Type: " + paymentType + "\n" +
                    "Email Receipt Requested: " + emailRequested, 
                    "Registrant Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // Write data to RegistrantData file after displaying the MessageBox
                    StreamWriter outputFile; // Declare StreamWriter object for use in writing file
                    // Write all data to file
                    outputFile = File.AppendText("RegistrationData.txt"); // Specify which file to write to
                    outputFile.WriteLine("Registration Date: " + dateMaskedTextBox.Text);
                    outputFile.WriteLine("Registrant Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text);
                    outputFile.WriteLine("Email Address: " + emailAddressTextBox.Text);
                    outputFile.WriteLine("Date of Birth: " + dateOfBirthMaskedTextBox.Text);
                    outputFile.WriteLine("Status: " + registrantStatusComboBox.Text);
                    outputFile.WriteLine("Classes Selected: " + classSelection);
                    outputFile.WriteLine("Number of Classes: " + numberOfClasses);
                    outputFile.WriteLine("Price per class: " + pricePerClassLabel.Text);
                    outputFile.WriteLine("Total Registration Price: " + totalPriceLabel.Text);
                    outputFile.WriteLine("Payment Type: " + paymentType);
                    outputFile.WriteLine("Email Receipt Requested: " + emailRequested);
                    outputFile.WriteLine(); // Write a blank line to seperate properties for the next time data is written to the file
                    outputFile.Close(); // Close output file after writing data

                    // Calls custom method to clear the form after displaying ShowBox and writing data to Registration Data text file
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                // Display message if error occurs when attempting to assign variables or writing to external file
                MessageBox.Show(ex.Message);
            }
        }

        // Handles the event handler for the about tool menu item
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creates an instance of the AboutForm form Class
            AboutForm myaboutForm = new AboutForm();

            // Display AboutForm instance as modal form
            myaboutForm.ShowDialog();
        }

        // Custom method to populate the classes list box 
        private void PopulateList()
        {
            classListBox.Items.Clear(); // Clears current class list box items
            // Reads data from external files for class list box
            StreamReader inputFile; // Declares object
            try
            {
                if (liveActionRadioButton.Checked) // If live action radio button is selected, display those classes in list box
                {
                    inputFile = File.OpenText("LiveActionClasses.txt"); // Opens Live Action Classes text file
                    while (!inputFile.EndOfStream) // Keeps reading the data until there's no more data
                    {
                        classListBox.Items.Add(inputFile.ReadLine());
                    }
                    inputFile.Close(); // Closes the input file
                }
                else // If animation radio button is selected, display those classes in the list box
                {
                    inputFile = File.OpenText("AnimationClasses.txt"); // Opens Animation Classes text file
                    while (!inputFile.EndOfStream) // Keeps reading the data until there's no more data
                    {
                        classListBox.Items.Add(inputFile.ReadLine());
                    }
                    inputFile.Close(); // Closes the input file
                }
            }
            catch (Exception ex)
            {
                // Displays a message if there are any errors when attempting to read the files
                MessageBox.Show(ex.Message);
            }
        }

        // Custom method to update totals
        private void UpdateTotals()
        {
            numberOfClasses = classListBox.SelectedIndices.Count;
            // Depending on which radio button is checked, display the appropriate price on screen
            if (liveActionRadioButton.Checked)
            {
                pricePerClassLabel.Text = LIVE_ACTION_CLASS_PRICE.ToString("c");
                subtotal = LIVE_ACTION_CLASS_PRICE * numberOfClasses;
            }
            else
            {
                pricePerClassLabel.Text = ANIMATION_CLASS_PRICE.ToString("c");
                subtotal = ANIMATION_CLASS_PRICE * numberOfClasses;
            }

            // Update number of classes and subtotal to appropriate variables
            numberOfClassesLabel.Text = numberOfClasses.ToString();
            totalPriceLabel.Text = subtotal.ToString("c");
        }

        // Custom method to reset the form to its original state
        private void ResetForm()
        {
            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy"); // Resets registration date to current date
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailAddressTextBox.Text = "";
            dateOfBirthMaskedTextBox.Text = null;
            registrantStatusComboBox.SelectedIndex = -1; // No registrant status selected
            liveActionRadioButton.Checked = true; // Selects live action radio button as the default
            classListBox.SelectedItems.Clear(); // Unselects anything that has been selected in the class list box
            cashRadioButton.Checked = true; // Selects cash radio button as the default
            emailReceiptRequestedCheckBox.Checked = false; // Ensures email receipt requested check box is not selected by default

            firstNameTextBox.Focus(); // Sets focus to first data entry control in form
        }
    }
}
