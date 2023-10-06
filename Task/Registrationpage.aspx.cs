using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.Configuration;

using System.IO;


namespace Task
{
    public partial class Registrationpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        public void run()
        {
            DataTable dt = new DataTable();
           
            if (ViewState["data"] == null)
            {
                DataColumn ID = new DataColumn();
                ID.DataType = System.Type.GetType("System.Int32");
                ID.AutoIncrement = true;
                ID.AutoIncrementSeed = 1;
                ID.AutoIncrementStep = 1;

                dt.Columns.Add(ID);

                dt.Columns.Add("name");
                dt.Columns.Add("mname");
                dt.Columns.Add("lname");
                dt.Columns.Add("email");
                dt.Columns.Add("pass");
                DataRow dr = dt.NewRow();
               
                dr["name"] = txt_name.Text;
                dr["mname"] = txt_mname.Text;
                dr["lname"] = txt_lname.Text;
                dr["email"] = txt_email.Text;
                dr["pass"] = txt_pass.Text;
                dt.Rows.Add(dr);
                ViewState["data"] = dt;
                rpt1.DataSource = dt;
                rpt1.DataBind();
                clear();
            }

            else
            {

                dt = (DataTable)ViewState["data"];
                DataRow dr = dt.NewRow();
                dr["name"] = txt_name.Text;
                dr["mname"] = txt_mname.Text;
                dr["lname"] = txt_lname.Text;
                dr["email"] = txt_email.Text;
                dr["pass"] = txt_pass.Text;
                dt.Rows.Add(dr);
                ViewState["data"] = dt;
                rpt1.DataSource = dt;
                rpt1.DataBind();
                clear();
            }
        }

        protected void btn_send_Click(object sender, EventArgs e)
        {
            run();
        }
        public void clear()
        {
            txt_name.Text = string.Empty;
            txt_mname.Text = null;
            txt_lname.Text = null;
            txt_email.Text = null;
            txt_pass.Text = null;
        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
             
            

         


        }
      

        protected void rpt1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "edit")
            {
                long  id = Convert.ToInt32(e.CommandArgument);

                Session["id"] = id;
                DataTable dt = (DataTable)ViewState["data"];
                var rowGroups = dt.Rows.OfType<DataRow>().OrderBy(r => r["ID"]).GroupBy(r => r["name"]);
                //dt = (from r in dt.AsEnumerable() where Convert.ToInt64(r["ID"]) == id select r).CopyToDataTable();
               
                foreach(DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["Column1"]) == id)
                    {
                        txt_email.Text = dr["email"].ToString();
                        txt_lname.Text = dr["lname"].ToString();
                        txt_mname.Text = dr["mname"].ToString();
                        txt_name.Text = dr["name"].ToString();
                        txt_pass.Text = dr["pass"].ToString();
                    }
                    
                }

            }


            if (e.CommandName == "delete")
            {
                long id = Convert.ToInt64(e.CommandArgument);
                DataTable dt = (DataTable)ViewState["data"];
                foreach(DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt64(dr["Column1"]) == id)
                    {
                        dr.Delete();
                        ViewState["data"] = dt;
                        rpt1.DataSource = dt;
                        rpt1.DataBind();
                        break;
                    }
                }
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {

        }

        protected void btn_update_Click1(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)ViewState["data"];
            long id = Convert.ToInt32(Session["id"]);
            string newname = txt_name.Text;
            foreach(DataRow dr in dt.Rows)
            {
             if(Convert.ToInt32(dr["Column1"]) == id)
                {
                    dr["name"] = txt_name.Text;
                    dr["mname"] = txt_mname.Text;
                    dr["lname"] = txt_lname.Text;
                    dr["email"] = txt_email.Text;
                    dr["pass"] = txt_pass.Text;
                    //dt.Rows.Add(dr);
                    ViewState["data"] = dt;
                    rpt1.DataSource = dt;
                    rpt1.DataBind();
                    clear();
                }
            }
        }
    }
    }