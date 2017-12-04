using System;
using System.Windows.Forms;

namespace Asteroids
{
    public partial class Login : Form
    {
        /// <summary>
        /// Called when the login dialog has been completed, returning the host
        /// and name entered by the user.
        /// </summary>
        /// 
        /// <param name="host">the host given by the user</param>
        /// <param name="name">the name given by the user</param>
        public delegate void Completed(string host, string name);

        /// <summary>
        /// Used to check if a given name is valid.
        /// </summary>
        /// 
        /// <param name="name">the name to validate</param>
        /// 
        /// <returns>true, iff the given name is valid, otherwise false</returns>
        public delegate bool ValidateName(string name);

        private Completed completed;
        private ValidateName validateName;

        public Login(Completed completed, ValidateName validateName)
        {
            InitializeComponent();

            this.completed = completed ?? throw new ArgumentNullException("Login dialog cannot have a null complete delegate");
            this.validateName = validateName ?? (s => true);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if(hostInput.Text.Length == 0)
            {
                MessageBox.Show("You need to enter a host", "Error");
            }
            else if(!validateName(nameInput.Text))
            {
                MessageBox.Show("The name you entered is not valid", "Error");
            }
            else
            {
                completed(hostInput.Text, nameInput.Text);
                Close();
            }
        }
    }
}
