using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDreamFrozen
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void hotelDreamFrozenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hotel_ragi_form h1 = new hotel_ragi_form();
            h1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            food_ragi_form f1 = new food_ragi_form();
            f1.Show();
        }
    }
}
