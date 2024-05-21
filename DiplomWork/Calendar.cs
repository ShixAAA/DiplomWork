using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomWork
{
    public partial class Calendar : Form
    {
        int month, year;
        public static int static_month, static_year;

        public Calendar()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays() 
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;


            static_month = month;
            static_year = year;


            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime strtofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(strtofthemonth.DayOfWeek.ToString("d")) ;

            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            daycontainer.Controls.Clear();

            month--;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime strtofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(strtofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }


        private void btnnext_Click(object sender, EventArgs e)
        {
            
            daycontainer.Controls.Clear();

            month++;

            static_month = month;
            static_year = year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;

            DateTime strtofthemonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int dayofweek = Convert.ToInt32(strtofthemonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < dayofweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.Days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
