using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stephen_s_Cars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //prepopulating the department combobox
            cboTypes.Items.Add("Compact");
            cboTypes.Items.Add("Minivan");
            cboTypes.Items.Add("Luxary");
            cboTypes.Text = "Compact";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //no error checking
            Cars c = new Cars(cboTypes.Text,
                txtName.Text,
                (double)numUDMPG.Value);
            lstOut.Items.Add(c);
            lstOut.Items.Add(c.CarType);
        }
    }
}
