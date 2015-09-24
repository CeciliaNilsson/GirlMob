using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GirlMobContactList
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        private const string myConnectionString = (@"Data Source=ACADEMY27-VM\SQLEXPRESS; Initial Catalog=Contacts;Integrated Security=SSPI");
        SqlConnection myConnection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        private string action;
        private int id;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void InitContactForm(string action, int id = 0)
        {
            this.action = action;
            this.id = id;

            switch (action)
            {
                case "Add":
                    SetAddMode();
                    break;
                case "Update":
                    if (id != 0)
                    {
                        SetUpdateMode();
                    }
                    else
                    {
                        SetLockedMode();
                        LabelError.Text = "No valid ID was given.";
                    }
                    break;
                case "Delete":
                    if (id != 0)
                    {
                        SetDeleteMode();
                    }
                    else
                    {
                        SetLockedMode();
                        LabelError.Text = "No valid ID was given.";
                    }
                    break;
                default:
                    break;
            }

        }

        private void SetAddMode()
        {
            ButtonChangeable.Text = "Add";

            //LabelTitle.Text = "Add contact";
            //LabelID.Visible = false;
            //LabelIDValue.Visible = false;
        }

        private void SetUpdateMode()
        {
            throw new NotImplementedException();
        }

        private void SetDeleteMode()
        {
            throw new NotImplementedException();
        }

        private void SetLockedMode(bool setLock = false)
        {
            foreach (var control in this.Controls)
                if (control is TextBox)
                    ((TextBox)control).Enabled = setLock;
                else if (control is Button)
                    ((Button)control).Enabled = setLock;

        }

    }
}