using System;
using System.Windows.Forms;

namespace Asteroids
{
    public partial class AsteroidsFrame : Form
    {
        public AsteroidsFrame()
        {
            InitializeComponent();

            Show();
            new Login(Completed, null).Show();
        }

        public void Completed(string host, string name)
        {
            System.Diagnostics.Debug.WriteLine($"host: {host}\nname: {name}");
        }
    }
}
