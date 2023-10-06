<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newregistrationform.aspx.cs" Inherits="Task.newregistrationform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="row">
                <div class="card">
               <div class="card-body">
                   <h3 style="text-align:center;"  ></h3>
                   <label class="mt-2">Name:</label>
                   <input   runat="server"   id="txt_name"  class="form-control" placeholder="Enter your name"/><br />
                   <label>Password:</label>
                   <input runat="server"   id="txt_pass"  type="password"   class="form-control" /><br />
                   <label>Confirm Password:</label>
                   <input runat="server"   id="con_pass"  type="password"   class="form-control" /><br />
                   <label>City:</label>
                    <asp:DropDownList   runat="server" class="form-control"> 
                        <asp:ListItem  Text="select City" Value="select City"></asp:ListItem>
                        <asp:ListItem  Text="Nagpur" Value="Nagpur"></asp:ListItem>
                         <asp:ListItem  Text="Pune" Value="Pune"></asp:ListItem>
                         <asp:ListItem  Text="Chandrapur" Value="Chandrapur"></asp:ListItem>
                         
                    </asp:DropDownList><br />
                  <asp:RadioButtonList runat="server" ID="radiobutton">
                      <asp:ListItem>Male:</asp:ListItem>
                      <asp:ListItem>Female:</asp:ListItem>

                  </asp:RadioButtonList><br />
                   <label>Gmail:</label>
                   <input   runat="server"  id="txt_mail" class="form-control"  type="text"/><br />
                  <div class="row">
                      <div class="col-md-6">
                          <asp:Button  runat="server"  ID="btn_send"  Text="Send" class="form-control ; btn-primary"/>
                      </div>
                  </div>

                  

               </div>
           </div>
            </div>
           
       

        </div>
    </form>
</body>
</html>
