using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

namespace Task.Dal
{
    public class registrationMaster
    {
        public long  ID { get; set; }
         public string name { get; set; }
         public string gender { get; set; }
         public string dateofbirth { get; set; }
         public string mobileNo { get; set; }
         public string photo { get; set; }
        public long? created_by { get; set; }
        public DateTime? created_date { get; set; }

        public bool?is_active { get; set; }


       public static DataTable getall()
        {
            DataTable dt = new DataTable();
            try
            {
                string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(str))
                {
                    string sql = @"select * from [regist_tbl]";
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql,con))
                    {
                        using (SqlDataReader reder =cmd.ExecuteReader() )
                        {
                            dt.Load(reder);
                        }


                    }
                    con.Close();
                }



            }
            catch(Exception ex)
            {

            }
            return dt; 

        }

       public void add()
        {try
            {
                string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(str))
                {
                    string sql = @"INSERT INTO regist_tbl (name
                                                          ,gender
                                                          ,dateofbirth
                                                          ,mobileNo
                                                          ,photo
                                                          ,created_by
                                                          ,created_date
                                                          ,is_active) values(  @name
                                                                              ,@gender
                                                                              ,@dateofbirth
                                                                              ,@mobileNo
                                                                              ,@photo
                                                                              ,@created_by
                                                                              ,@created_date
                                                                              ,@is_active) ";

                    sql += "select Scope_identity()";
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = name == null ? (Object)DBNull.Value : name;
                        cmd.Parameters.Add("@gender", SqlDbType.NVarChar, 50).Value = gender == null ? (Object)DBNull.Value : gender;
                        cmd.Parameters.Add("@dateofbirth", SqlDbType.NVarChar, 50).Value = dateofbirth == null ? (Object)DBNull.Value : dateofbirth;
                        cmd.Parameters.Add("@mobileNo", SqlDbType.NVarChar, 50).Value = mobileNo == null ? (Object)DBNull.Value : mobileNo;
                        cmd.Parameters.Add("@photo", SqlDbType.NVarChar, 250).Value = photo == null ? (Object)DBNull.Value : photo;
                        cmd.Parameters.Add("@created_by", SqlDbType.BigInt , 8).Value = created_by == null ? (Object)DBNull.Value : created_by;
                        cmd.Parameters.Add("@created_date", SqlDbType.DateTime).Value = created_date == null ? (Object)DBNull.Value : created_date;
                        cmd.Parameters.Add("@is_active", SqlDbType.Bit).Value = is_active == null ? (Object)DBNull.Value : is_active;

                        ID = Convert.ToInt64(cmd.ExecuteScalar());
                    }
                    con.Close();
                }
            }
            catch(Exception ex)
            {

            }

        }

        public  static DataTable  delete(long ID)
        {
            DataTable dt = new DataTable();
            try
            {
                string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(str))
                {
                    string sql = @"delete from [regist_tbl] where ID= @ID";
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql,con))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.BigInt, 8).Value = ID ;

                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }


            }
            catch (Exception ex)
            {

            }
            return dt; 
        }

        public static registrationMaster getbyid(long ID)
        {
            registrationMaster re = new registrationMaster();
            try
            {
                string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(str))
                {
                    string sql = @"  select name
                                              ,gender
                                              ,dateofbirth
                                              ,mobileNo
                                              ,photo
                                              ,created_by
                                              ,created_date
                                              ,is_active  from regist_tbl where ID = @ID  ";
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql,con))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.BigInt).Value = ID == null ? (Object)DBNull.Value : ID;
                        using (SqlDataReader reder = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                        {
                            if (reder.Read())
                            {
                                //re.ID = Convert.ToInt64(reder["ID"]);
                                re.name = reder["name"] == DBNull.Value ? null : reder["name"].ToString();
                                re.gender = reder["gender"] == DBNull.Value ? null : reder["gender"].ToString();
                                re.dateofbirth = reder["dateofbirth"] == DBNull.Value ? null : reder["dateofbirth"].ToString();
                                re.mobileNo = reder["mobileNo"] == DBNull.Value ? null : reder["mobileNo"].ToString();
                                re.photo = reder["photo"] == DBNull.Value ? null : reder["photo"].ToString();
                                re.created_by = reder["created_by"] == DBNull.Value ? (long?)null : Convert.ToInt64(reder["created_by"]);
                                re.created_date = reder["created_date"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reder["created_date"]);
                                re.gender = reder["is_active"] == DBNull.Value ? null : reder["is_active"].ToString();
                            }

                        }

                    }



                }

            }
            catch (Exception ex)
            {

            }
            return re;

        }

       public void update(long ID)
        {

            try
            {
                string str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(str))
                {
                    string sql = @"Update [regist_tbl] set name         = @name
                                                              ,gender       = @gender
                                                              ,dateofbirth  = @dateofbirth
                                                              ,mobileNo     = @mobileNo
                                                              ,photo        = @photo
                                                              ,created_by   = @created_by
                                                              ,created_date = @created_date
                                                              ,is_active    = @is_active where ID=@ID    ";

con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql,con))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.BigInt).Value = ID == null ? (Object)DBNull.Value : ID;

                        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = name == null ? (Object)DBNull.Value : name;
                        cmd.Parameters.Add("@gender", SqlDbType.NVarChar, 50).Value = gender == null ? (Object)DBNull.Value : gender;
                        cmd.Parameters.Add("@dateofbirth", SqlDbType.NVarChar, 50).Value = dateofbirth == null ? (Object)DBNull.Value : dateofbirth;
                        cmd.Parameters.Add("@mobileNo", SqlDbType.NVarChar, 50).Value = mobileNo == null ? (Object)DBNull.Value : mobileNo;
                        cmd.Parameters.Add("@photo", SqlDbType.NVarChar, 250).Value = photo == null ? (Object)DBNull.Value : photo;
                        cmd.Parameters.Add("@created_by", SqlDbType.BigInt, 8).Value = created_by == null ? (Object)DBNull.Value : created_by;
                        cmd.Parameters.Add("@created_date", SqlDbType.DateTime).Value = created_date == null ? (Object)DBNull.Value : created_date;
                        cmd.Parameters.Add("@is_active", SqlDbType.Bit).Value = is_active == null ? (Object)DBNull.Value : is_active;
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();

                }
            }
            catch(Exception ex)
            {

            }

        }

        public static DataTable getbynumber(string mobileNo)
        {
            DataTable dt = new DataTable();
            try
            {
                string str = ConfigurationManager.ConnectionStrings["cosntr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(str))
                {
                    string sql = @"select from regist_tbl where mobileNo=@mobileNo ";
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql,con))
                    {
                        cmd.Parameters.Add("@mobileNo", SqlDbType.NVarChar, 50).Value = mobileNo == null ? (Object)DBNull.Value : mobileNo;
                        using (SqlDataReader reder = cmd.ExecuteReader())
                        {
                            dt.Load(reder);
                        }


                    }
                }


            }
            catch (Exception ex)
            {

            }
            return dt;
        }
    }
}