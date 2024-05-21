using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomWork
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day;


        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void Days(int numbay) 
        {
            lbdays.Text = numbay + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = lbdays.Text;
            EventForm evt = new EventForm();
            evt.Show();
        }
    }
}
