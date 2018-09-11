using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using personclass;
using System.Data.SqlClient;

namespace WindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int PersonV2_ID)
        {
            InitializeComponent();

            PersonV2 temp = new PersonV2();
            SqlDataReader dr = temp.FindPersonV2(PersonV2_ID);

            while (dr.Read())
            {
                FirstName.Text = dr["Fname"].ToString();
                middle.Text = dr["MName"].ToString();
                last.Text = dr["Lname"].ToString();
                address.Text = dr["Street1"].ToString();
                apt.Text = dr["Street2"].ToString();
                city.Text = dr["City"].ToString();
                state.Text = dr["State"].ToString();
                zip.Text = dr["Zip"].ToString();
                homephone.Text = dr["Phone"].ToString();
                emailaddress.Text = dr["Email"].ToString();
                cellPhone.Text = dr["CellPhone"].ToString();
                facebook.Text = dr["Facebook"].ToString();

                lblP_ID.Text = dr["PersonV2_ID"].ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonV2 temp = new PersonV2();

            temp.Fname = FirstName.Text;
            temp.MName = middle.Text;
            temp.Lname = last.Text;
            temp.Street1 = address.Text;
            temp.Street2 = apt.Text;
            temp.City = city.Text;
            temp.State = state.Text;
            temp.Zip = zip.Text;
            temp.Phone = homephone.Text;
            temp.Email = emailaddress.Text;
            temp.CellPhone = cellPhone.Text;
            temp.Facebook = facebook.Text;


            if (!temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.AddRecord(); // if there are no errors add to database
            }
            else
            {
                lblFeedback.Text = temp.Feedback; // if the form contains errors ouput feedback
            }
        }
    }
}
