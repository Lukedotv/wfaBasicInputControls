using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaBasicInputControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cboName.Text))
            {
                lstNames.Items.Add(cboName.Text);
                cboName.Items.Add(cboName.Text);
                

            }
        }

        private void btnAddToList_KeyDown(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(cboName.Text))
            {
                lstNames.Items.Add(cboName.Text);
                cboName.Items.Add(cboName.Text);


            }
        }
    }
}
