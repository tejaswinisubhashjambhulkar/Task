using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

namespace Task
{
    public partial class dyanamictable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

            }
        }

        protected void rpt_1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        public void clear()
        {
            txt_mail.Value = string.Empty;
            txt_name.Value = string.Empty;
            txt_pass.Value = string.Empty;
            con_pass.Value = string.Empty;
            radiobutton.SelectedValue = string.Empty;
            radiobutton.Items[0].Selected = false;
            drop_selectcity.SelectedIndex = 0;
        }

        public void bindrepeater()
        {
          
        }

        protected void btn_send_Click(object sender, EventArgs e)
        {
           
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("name");
            dt.Columns.Add("pass");
            dt.Columns.Add("Confirm_pass");
            dt.Columns.Add("gender");
            dt.Columns.Add("email");
            DataRow dr = dt.NewRow();
            
             
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {

        }
    }
}