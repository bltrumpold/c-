using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationClass;
using System.Data;
using System.Data.SqlClient;

namespace personclass
{
    class person
    {
        private string fName;      // | private string used to store first name           |
        private string mName;      // | private string used to store middle name          |
        private string lName;      // | private string used to store last name            |
        private string street1;    // | private string used to store street address       |
        private string street2;    // | private string used to store room location or apt |
        private string city;       // | private string used to store city                 |
        private string state;      // | private string used to store state                |
        private string zip;        // | private string used to store zip-code             |
        private string phone;      // | private string used to store phone number         |
        private string email;      // | private string used to store email address        |
        protected string feedback; // | private string used to store feedback             |




        public string Fname // creates public string that stores fName
        {
            get { return fName; }
            set
            {
                if (!ClassValidation.BadWords(value)) // checks to see if fName contains bad words
                {
                    fName = value;
                }
                else feedback += "\nERROR: First Name contained a bad word";

                if (!ClassValidation.InvalidChar(value)) // checks to see if fName contains an invalid character
                {
                    fName = value;
                }
                else feedback += "\nERROR: First Name contained an invalid character";

                if (ClassValidation.FilledIn(value)) // checks to see if fName is filled in
                {
                    fName = value;
                }
                else feedback += "\nERROR: First Name was not filled in.";
            }
        } // end public string Fname
          //--------------------------------------------------------------------------------

        public string MName // creates public string that stores lName
        {
            get { return mName; }
            set
            {
                if (!ClassValidation.BadWords(value)) // checks to see if MName contains a bad word
                {
                    mName = value;
                }
                else feedback += "\nERROR: Middle Name contained a bad word";

                if (!ClassValidation.InvalidChar(value)) // checks to see if MName contains an invalid character
                {
                    mName = value;
                }
                else feedback += "\nERROR: Middle Name contained an invalid character";

                if (ClassValidation.FilledIn(value)) // checks to see if MName is filled in
                {
                    mName = value;
                }
                else feedback += "\nERROR: Middle Name was not filled in ";


            }
        }// end public string Mname
         //--------------------------------------------------------------------------------

        public string Lname // creates public string that stores lName
        {
            get { return lName; }
            set
            {
                if (!ClassValidation.BadWords(value)) // Checks to see if Lname contains a bad word
                {
                    lName = value;
                }
                else feedback += "\nERROR: Last Name contained a bad word";

                if (!ClassValidation.InvalidChar(value)) // checks to see if Lname contains an invalid character
                {
                    lName = value;
                }
                else feedback += "\nERROR: Last Name contained an invalid character";

                if (ClassValidation.FilledIn(value)) // checks to see if Lname is filled in
                {
                    lName = value;
                }
                else feedback += "\nERROR: Last Name was not filled in ";
            }
        }// end public string Lname
         //--------------------------------------------------------------------------------

        public string Street1 // creates public string that stores street1
        {
            get { return street1; }
            set
            {
                if (!ClassValidation.BadWords(value)) // checks to see if Street1 contains a bad word
                {
                    street1 = value;
                }
                else feedback += "\nERROR: Street Address contained a bad word";

                if (ClassValidation.FilledIn(value)) // checks to see if Street1 is filled in
                {
                    street1 = value;
                }
                else feedback += "\nERROR: Street Address was not filled in ";
            }
        }// end public string Street1
         //--------------------------------------------------------------------------------

        public string Street2 // creates public string that stores street2
        {
            get { return street2; }
            set
            {
                if (!ClassValidation.BadWords(value)) // checks to see in Street2 contains a bad word
                {
                    street2 = value;
                }
                else feedback += "\nERROR: Room/Apt# contained a bad word";

                if (ClassValidation.FilledIn(value)) // checks to see if Street2 is filled in
                {
                    street2 = value;
                }
                else feedback += "\nERROR: Room/Apt# was not filled in ";
            }
        }// end public string Street2
         //--------------------------------------------------------------------------------

        public string City // creates public string that stores city
        {
            get { return city; }
            set
            {
                if (!ClassValidation.BadWords(value)) // checks to see if City contains a bad word
                {
                    city = value;
                }
                else feedback += "\nERROR: City contained a bad word";

                if (!ClassValidation.InvalidChar(value)) // checks to see if City contains an invalid character
                {
                    city = value;
                }
                else feedback += "\nERROR: City contained an invalid character";

                if (ClassValidation.FilledIn(value)) // checks to see if City is filled in
                {
                    city = value;
                }
                else feedback += "\nERROR: City was not filled in ";
            }
        }// end public string City
         //--------------------------------------------------------------------------------

        public string State // creates public string that stores state
        {
            get { return state; }
            set
            {
                if (!ClassValidation.BadWords(value)) // checks to see if State contains a badword
                {
                    state = value;
                }
                else feedback += "\nERROR: State contained a bad word";

                if (ClassValidation.FilledIn(value)) // checks to see if State is filled in
                {
                    state = value;
                }
                else feedback += "\nERROR: State is not filled in ";
            }
        }//end public string State
         //--------------------------------------------------------------------------------

        public string Zip //creates public string that stores zip
        {
            get { return zip; }
            set
            {
                if (!ClassValidation.BadWords(value)) // checks to see if Zip contains a bad word
                {
                    zip = value;
                }
                else feedback += "\nERROR: Zip contained a bad word";

                if (ClassValidation.FilledIn(value)) // checks to see if Zip is filled in
                {
                    zip = value;
                }
                else feedback += "\nERROR: Zip-Code is not filled in ";
            }
        } // end public string Zip
          //--------------------------------------------------------------------------------

        public string Phone // creates public string that stores phone
        {
            get { return phone; }
            set
            {
                if (!ClassValidation.BadWords(value)) // Checks to see if Phone contains a bad word
                {
                    phone = value;
                }
                else feedback += "\nERROR: Phone Number contained a bad word";

                if (ClassValidation.FilledIn(value)) // checks to see if Phone is filled in
                {
                    phone = value;
                }
                else feedback += "\nERROR: Phone Number is not filled in ";
            }
        } // end public string Phone
          //--------------------------------------------------------------------------------

        public string Email // creates publiv string that stores email
        {
            get { return email; }
            set
            {
                if (!ClassValidation.BadWords(value)) // Checks to see if email contains a bad word
                {
                    email = value;
                }
                else feedback += "\nERROR: Email contained a bad word";

                if (ClassValidation.ValidEmail(value)) // checks to see if Email contains a valid emailaddress
                {
                    email = value;
                }
                else feedback += "\nERROR: That Email was not valid";

                if (ClassValidation.FilledIn(value)) // checks to see if Email is filled in
                {
                    email = value;
                }
                else feedback += "\nERROR: Email was not filled in ";
            }
        } // end public string Email
    }


    class PersonV2 : person
    {

        private string cellPhone; // | private string used to store cellphone number     |
        private string facebook;  // | private string used to store facebook             |

        //------------------------------------------------------------------------------
        public string CellPhone
        {
            get { return cellPhone; }

            set
            {
                if (!ClassValidation.BadWords(value)) // checks to see if CellPhone contains a bad word
                {
                    cellPhone = value;
                }
                else feedback += "\nERROR: Cell Phone number contained a bad word.";

                if (ClassValidation.FilledIn(value)) // checks to see if CellPhone is filled in
                {
                    cellPhone = value;
                }
                else feedback += "\nERROR: Cell Phone was not filled in ";
            }

        }// end public string CellPhone----------------------------------------------------------

        public string Facebook
        {
            get { return facebook; }

            set
            {
                if (!ClassValidation.BadWords(value)) // checks to see if Facebook contains a bad word
                {
                    facebook = value;
                }
                else
                {
                    feedback += "\nERROR: Facebook ID has a bad word in it.";
                }

                if (ClassValidation.FilledIn(value)) // checks to see if Facebook is filled in
                {
                    facebook = value;
                }
                else feedback += "\nERROR: Facebook ID was not filled in";
            }
        } // end public string Facebook----------------------------------------------------------

        public string Feedback // creates public string Feedback
        {
            get { return feedback; }

        }

        public PersonV2() // sets string equal to nothing
        {
            Fname = "";
            MName = "";
            Lname = "";
            Street1 = "";
            Street2 = "";
            City = "";
            State = "";
            Zip = "";
            Phone = "";
            Email = "";
            CellPhone = "";
            Facebook = "";
            feedback = "";

        }


        public string AddRecord() // connect to database / store infromation to database
        {
            string strResult = "";

            SqlConnection Conn = new SqlConnection();

            Conn.ConnectionString = @"Server=sql.neit.edu,4500;Database=SE245_BTrumpold;User Id=SE245_BTrumpold;Password=008001574";

            string strSQL = "INSERT INTO PersonV2 (Fname, MName, Lname, Street1, Street2, City, State, Zip, Phone, Email, CellPhone, Facebook) VALUES (@Fname, @MName, @Lname, @Street1, @Street2, @City, @State, @Zip, @Phone, @Email, @CellPhone, @Facebook)";

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn;

            comm.Parameters.AddWithValue("@Fname", Fname);
            comm.Parameters.AddWithValue("@MName", MName);
            comm.Parameters.AddWithValue("@Lname", Lname);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zip", Zip);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@CellPhone", CellPhone);
            comm.Parameters.AddWithValue("@Facebook", Facebook);


            try
            {
                Conn.Open();


                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} records";
                Conn.Close();

            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }
            finally
            {

            }
            return strResult;
        }

        public DataSet SearchPersonv2(string strFname, string strLname)
        {
            DataSet ds = new DataSet();

            SqlCommand comm = new SqlCommand();

            String strSQL = "Select PersonV2_ID, Fname, MName, Lname, Street1, Street2, City, State, Zip, Phone, Email, CellPhone, Facebook From PersonV2 WHERE 0=0";

            if (strFname.Length > 0)
            {
                strSQL += " AND Fname Like @Fname";
                comm.Parameters.AddWithValue("@Fname", "%" + strFname + "%");
            }

            if (strLname.Length > 0)
            {
                strSQL += " AND Lname LIKE @Lname";
                comm.Parameters.AddWithValue("@Lname", "%" + strLname + "%");
            }

            SqlConnection conn = new SqlConnection();

            string strConn = @GetConnected();
            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = strSQL;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;

            conn.Open();
            da.Fill(ds, "PersonV2_Temp");
            conn.Close();

            return ds;
        }

        public SqlDataReader FindPersonV2(int intpersonV2_ID)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string strConn = GetConnected();

            string sqlString = "SELECT * From PersonV2 Where PersonV2_ID = @PersonV2_ID";

            conn.ConnectionString = strConn;

            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@PersonV2_ID", intpersonV2_ID);

            conn.Open();

            return comm.ExecuteReader();
        }

        private string GetConnected() // enables the program to connect to the db through a string
        {
            return "Server=sql.neit.edu,4500;Database=SE245_BTrumpold;User Id=SE245_BTrumpold;Password=008001574";
        }


    }// end class PersonV2

}
