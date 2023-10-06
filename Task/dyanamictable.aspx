<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dyanamictable.aspx.cs" Inherits="Task.dyanamictable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            
            <div class="row mt-3">
                <div class="col-md-3"></div>
                <div class="col-md-6">
                <div class="card">
               <div class="card-body">
                   <h3 style="text-align:center"  >Registration form</h3>
                   <label>Name:</label>
                   <input   runat="server"   id="txt_name"  class="form-control" placeholder="Enter your name"/><br />
                   <label>Password:</label>
                   <input runat="server"   id="txt_pass"  type="password"   class="form-control" />
                   <label>Confirm Password:</label>
                   <input runat="server"   id="con_pass"  type="password"   class="form-control" /><br />
                   <label>City:</label>
                    <asp:DropDownList   runat="server" class="form-control" ID="drop_selectcity"> 
                        <asp:ListItem  Text="select City" Value="select City"></asp:ListItem>
                        <asp:ListItem  Text="Nagpur" Value="Nagpur"></asp:ListItem>
                         <asp:ListItem  Text="Pune" Value="Pune"></asp:ListItem>
                         <asp:ListItem  Text="Chandrapur" Value="Chandrapur"></asp:ListItem>
                         
                    </asp:DropDownList><br />
                   <label>Gender:</label>
                  <asp:RadioButtonList runat="server" ID="radiobutton">
                      <asp:ListItem>Male</asp:ListItem>
                      <asp:ListItem>Female</asp:ListItem>

                  </asp:RadioButtonList><br />
                   <label>Gmail:</label>
                   <input   runat="server"  id="txt_mail" class="form-control"  type="text"/><br />
                  <div class="row">
                      <div class="col-md-6">
                          <asp:Button  runat="server"  ID="btn_send" OnClick="btn_send_Click"  Text="Send" class="form-control ; btn-primary"/>
                         <asp:Button  runat="server"  ID="btn_update" OnClick="btn_update_Click"  Text="Update" class="form-control ; btn-primary"/>

                      </div>
                  </div>

                  

               </div>
           </div>
                    </div>
                <div class="col-md-3"></div>
            </div>
           
            <div class="row">
                <div class="card">
                    <div class="card-body">
                        <table>
                            <thead>
                                <tr>
                                    <th>ID</th>
                                    <th>Name </th>
                                     <th>Password</th>
                                     <th>Confirm Password</th>
                                     <th>City</th>
                                     <th>Gender</th>
                                    <th>Email</th>
                                </tr>
                            </thead>
                            <tbody>
                            <asp:Repeater runat="server"  ID="rpt_1"  OnItemCommand="rpt_1_ItemCommand"  >
                                <ItemTemplate>
                                    <tr>
                                        
                                        <td><%#Eval("ID") %></td>
                                        <td><%#Eval("name") %></td>
                                        <td><%#Eval("pass") %></td>
                                        <td><%#Eval("Confirm_pass") %></td>
                                        <td><%#Eval("gender") %></td>
                                        <td><%#Eval("email") %></td>
                                        <td><asp:LinkButton runat="server" ID="btn_edit" CommandName="edit" CommandArgument=""></asp:LinkButton></td>
                                        <td><asp:LinkButton runat="server" ID="delete" CommandName="edit" CommandArgument=""></asp:LinkButton></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
       </div>

        
       
    </form>
</body>
</html>
