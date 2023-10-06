<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registrationwithdal.aspx.cs" Inherits="Task.registrationwithdal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.min.js"></script>
</head>
<body>

    <form id="form1" runat="server">
        <div class="row offset-3 mt-2">
            <%-- <div class="col-md-12">
                    <div class="col-md-3"></div>
                    <div class="col-md-6">--%>
            <div class="card ">
                <div class="card-body">
                    <h2>Registration Form</h2>
                    <label class="mt-2">Name:</label>
                    <input runat="server" id="txt_name" class="form-control" type="text" /><br />
                    <div class="form-group">
                                <lable for="male">Male</lable>
                                <input type="radio" value="male" name="gender" runat="server" id="txt_gender" />
                                <br />
                                <label for="female">Female</label>
                                <input type="radio" value="female" name="gender" runat="server" id="Radio1" />
                            </div>
                    <label class="mt-1">Date of birth:</label>
                    <input runat="server" type="date" id="txt_date" class="form-control" /><br />
                    <label class="mt-1">Mobile No:</label>
                    <input runat="server" type="text" id="txt_number" class="form-control" /><br />
                    <label class="mt-1">Upload Photo:</label>
                    <asp:Image runat="server" Height="100px" Width="100px" ID="image1" />
                    <asp:FileUpload ID="upload_img" runat="server" /><br />
                    <div class="row mt-3">
                        <%--<div class="col-md-6">--%>
                            <div class="col-md-3">
                                <asp:Button runat="server" ID="btn_send" Text="Send" OnClick="btn_send_Click" class="form-control btn-primary" />
                            </div>
                            <div class="col-md-3">
                                <asp:Button runat="server" ID="btn_update" Text="Update" OnClick="btn_update_Click" class="form-control btn-primary" />
                            </div>
                        <%--</div>--%>
                    </div>
                </div>
            </div>
        </div>
        <%--           <div class="col-md-3"></div>
                    </div>
            </div>--%>


        <div class="row mt-3  offset-2">
            <div class="card">
                <div class="card-body">
                    <table class="table-bordered table-hover  table">
                        <thead>
                            <tr>
                                 <th>ID</th>
                                <th>Name</th>
                                <th>Gender</th>
                                <th>Date of birth</th>
                                <th>Mobile No</th>
                                <th>Photo</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater runat="server" ID="rpt_1" OnItemCommand="rpt_1_ItemCommand">
                                <ItemTemplate>
                                    <tr>   
                                        <td><%#Eval("ID")%></td>
                                        <td><%#Eval("name")%></td>
                                        <td><%#Eval("gender")%></td>
                                        <td><%#Eval("dateofbirth")%></td>
                                        <td><%#Eval("mobileNo")%></td>
                                        <td><%#Eval("photo")%></td>
                                        <td><asp:LinkButton  runat="server"  ID="btn_edit"  CommandName="edit"   CommandArgument='<%#Eval("ID")%>'  >Edit</asp:LinkButton></></td>
                                        <td><asp:LinkButton   runat="server"  ID="btn_delete"  CommandName="delete" CommandArgument='<%#Eval("ID")%>'  >delete</asp:LinkButton></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
