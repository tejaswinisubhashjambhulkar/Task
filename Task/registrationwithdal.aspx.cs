using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Task.Dal;
using System.Data;


namespace Task
{
    public partial class registrationwithdal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                binddata();

            }

        }

        protected void rpt_1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
           if (e.CommandName == "edit")
            {
                long id = Convert.ToInt64(e.CommandArgument);
                Session["id"] = id;
                registrationMaster ad = new registrationMaster();
                ad = registrationMaster.getbyid(id);
                txt_date.Value = ad.dateofbirth;
                txt_name.Value = ad.name;
                txt_number.Value = ad.mobileNo;
                txt_gender.Value = ad.gender;
                
                

            }
           if (e.CommandName == "delete")
            {
                long ID = Convert.ToInt64(e.CommandArgument);
                registrationMaster del = new registrationMaster();
                registrationMaster.delete(ID);
                binddata();
            }
        }

        protected void btn_send_Click(object sender, EventArgs e)
        {
            
            if (upload_img.HasFile )
            {
                upload_img.SaveAs(Server.MapPath("images/" + upload_img.FileName));
                image1.ImageUrl = "images/" + upload_img.FileName;
                Session["image"] = image1.ImageUrl;
            }

            registrationMaster ad = new registrationMaster();
            ad.name = txt_name.Value;
            ad.gender = txt_gender.Value.ToString();
            ad.dateofbirth = Convert.ToString(txt_date.Value);
            ad.mobileNo = txt_number.Value.ToString();
            ad.photo = Session["image"].ToString();
          
            ad.created_by = 1;
            ad.created_date = DateTime.Now;
            ad.is_active = true;
            ad.add();
            binddata();
        }

        public void binddata()
        {
            DataTable dt = new DataTable();
            dt = registrationMaster.getall();
            rpt_1.DataSource = dt;
            rpt_1.DataBind();

        }

        public void clear()
        {
            txt_name.Value = "";
             txt_gender.Value = "";
             txt_date.Value = "";
             txt_number.Value  = " ";

        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            long id = Convert.ToInt64( Session["id"]);
            if (upload_img.HasFile)
            {
                upload_img.SaveAs(Server.MapPath("images/" + upload_img.FileName));
                image1.ImageUrl = "images/" + upload_img.FileName;
                Session["image"] = image1.ImageUrl;
            }
            registrationMaster up = new registrationMaster();
            up.name = txt_name.Value;
            up.gender = txt_gender.Value;
            up.mobileNo = txt_number.Value;
            up.photo = Session["image"].ToString();
            up.created_by = 1;
            up.created_date = DateTime.Now;
            up.is_active = true;
            up.update(id);
            binddata();
            clear();
        }
    }
}