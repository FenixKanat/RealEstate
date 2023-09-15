using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate
{
    public partial class Form1 : Form
    {
        Residential residential;
        Institutional institutional;
        Commercial commercial;

        public Form1()
        {
            InitializeComponent();
            initializeGUI();
        }

        private void initializeGUI() {
            this.Text += " by Fenix Kanat";
            listBox1.Text = String.Empty;

            //Textboxes for details
            idTB.Text = String.Empty;
            roomsTB.Text = String.Empty;
            sizeTb.Text = String.Empty;
            rentTB.Text = String.Empty;

            //Textboxes for address
            streetTB.Text = String.Empty;
            cityTB.Text = String.Empty;
            zipTB.Text = String.Empty;

                }


        private bool checkResidentialID() {


            int number = 0;
            bool check = true;

            if (int.TryParse(idTB.Text, out number) && number >= 0)
            {
                residential.Id = number;
            }
            else {
                MessageBox.Show("invalid ID");
                check = false;
            }

            return check=true;
        }

        private bool checkResidentialRooms() {
            int number = 1;
            bool check = true;

            if (int.TryParse(roomsTB.Text, out number) && number >= 1)
            {
                residential.getRoom = number;
            }
            else {
                MessageBox.Show("invalid number of room");
                check = false;
            }

            return check = true; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Change_Click(object sender, EventArgs e)
        {

        }

        private void commercial_Enter(object sender, EventArgs e)
        {

        }

        private void residential_Enter(object sender, EventArgs e)
        {

        }

        private void institutional_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Zipcode_Click(object sender, EventArgs e)
        {

        }

        private void idTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
