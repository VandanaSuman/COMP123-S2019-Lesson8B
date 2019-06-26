using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8B
{
    public partial class Lab8Form : Form
    {
        // Class Properties
        public string Username { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// This is the constructor for lab 8 form
        /// </summary>
        public Lab8Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the submit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Username = NameTextBox.Text;
            UserAge = float.Parse(AgeTextBox.Text);
            Outputlabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
            //float floatResult;
            //bool result;
            //result = float.TryParse(AgeTextBox.Text, out floatResult);
            ClearForm();
        }

        /// <summary>
        /// This method clears the form
        /// </summary>

        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SubmitButton.Enabled = false;
        }

        /// <summary>
        /// This is the event handler for the age text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            //simple input validation

                try
                {
                    float.Parse(AgeTextBox.Text);
                    SubmitButton.Enabled = true;
                }
                catch 
                {

                    SubmitButton.Enabled = false;
                }
                
        }

        /// <summary>
        /// This is the event handler for the lab 8 form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Lab8Form_Load(object sender, EventArgs e)
        {
            //SubmitButton.Enabled = false;
            ClearForm();
        }

        /// <summary>
        /// Event handler for the name text box TextChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.MaxLength < 2) ? false : true;
        }
    }
}
