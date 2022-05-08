using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Fields
        private Button currButton;
        private Form activeForm;
        
        //Constructor
        public Form1()
        {
            InitializeComponent();
        }

        //Methods
        private void openForm(Form newForm,object btnSender)
        {
           if(activeForm!=null)
            {
                activeForm.Close();
            }
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            this.panelMainDesktop.Controls.Add(newForm);
            this.panelMainDesktop.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
            lblTitle.Text = newForm.Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new Car(), sender);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openForm(new Inventory(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
 
        private void btnStorage_Click(object sender, EventArgs e)
        {
            openForm(new Motorcycle(), sender);
        }

        private void panelMainDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        if (activeForm!=null)
            {
                activeForm.Close();
            }
        Reset();
        }

        private void Reset()
        {
            lblTitle.Text = "Parking Lot";
            currButton = null;
        }
    }
}
