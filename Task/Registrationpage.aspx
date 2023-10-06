<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrationpage.aspx.cs" Inherits="Task.Registrationpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.min.js"></script>
    
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
            <div class="row">
            <div class="container">
                <div class="card">
                    <div class="card-body">
                        <h2 class="align-content-center">Registration page</h2>
                        <label class="mt-1">Name:</label><br />
                        <asp:TextBox runat="server" ID="txt_name" Class="form-control" ></asp:TextBox><br />
                        <label class="mt-1">Middel name:</label>
                        <asp:TextBox runat="server" ID="txt_mname" Class="form-control" ></asp:TextBox><br />
                        <label class="mt-1">Last Name:</label>
                        <asp:TextBox runat="server" ID="txt_lname" Class="form-control" ></asp:TextBox><br />
                        <label class="mt-1">Email:</label>
                        <asp:TextBox runat="server" ID="txt_email" Class="form-control" ></asp:TextBox>
                        <label class="mt-1">Password:</label>
                        <asp:TextBox runat="server" ID="txt_pass" Class="form-control" ></asp:TextBox>
                        <div class="row">
                            <div class="col-md-6">
                                <div class="col-md-3">
                              <asp:Button runat="server" OnClick="btn_send_Click"  ID="btn_send" Class="form-control text-center mt-2 btn-primary" Text="Send"  />
                                </div>
                                <div class="col-md-3">
                              <asp:Button runat="server" OnClick="btn_update_Click1"  ID="btn_update" Class="form-control text-center mt-2 btn-primary" Text="update"  />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
                </div>
            <div class="row">
                <div class="card">
                    <div class="card-body">
                        <table class="table-bordered table-hover">
                    <thead>
                        <tr>
                            <td>ID</td>
                            <th>Name</th>
                             <th>Middel name</th>
                             <th>Last Name</th>
                             <th>Email</th>
                             <th>Password</th>
                           
                        </tr>
                    </thead>
                    <asp:Repeater  ID="rpt1" runat="server"  OnItemCommand="rpt1_ItemCommand">
                        <ItemTemplate>
                            <tbody>
                                <tr>
                                    <td><%#Eval("Column1")%></td>
<%--                                    <td><%#(((RepeaterItem)Container).ItemIndex+1).ToString()%></td>--%>
                                       <td><%#Eval("name")%></td>
                                        <td><%#Eval("mname")%></td>
                                        <td><%#Eval("lname")%></td>
                                        <td><%#Eval("email")%></td>
                                        <td><%#Eval("pass")%></td>
                                     <td> 
        <asp:LinkButton ID="btn_edit" runat="server" OnClick="btn_edit_Click" CommandName="edit" CommandArgument='<%#(((RepeaterItem)Container).ItemIndex+1).ToString()%>'>Edit</asp:LinkButton></td>
         <td><asp:LinkButton ID="btn_delete" runat="server" OnClick="btn_delete_Click" CommandName="delete"  CommandArgument='<%#(((RepeaterItem)Container).ItemIndex+1).ToString()%>'>delete</asp:LinkButton>
                            </td>
                                </tr>
                            </tbody>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
                    </div>
                </div>                
            </div>        
    </form>
</body>
</html>
