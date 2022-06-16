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
    public partial class food_ragi_form : Form
    {
        public food_ragi_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resto_book_tables r1 = new resto_book_tables();
            r1.Show();
        }
    }
}
