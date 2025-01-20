using System;
using System.Windows.Forms;

namespace WinForms_Calculator
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1( )
        {
            InitializeComponent( );
        }

        private void sevenButton_Click( object sender , EventArgs e )
        {
            textBox1.Text = "7";
        }
    }
}
