<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TextboxToGrideView.Practise.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div> <asp:ScriptManager ID="ScriptManager1" runat="server" />

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
   <ContentTemplate>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtADDRESS" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtRoll" runat="server"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
      
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"  BorderWidth="1px" CellPadding="3"  OnDataBound="GridView1_DataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
           
          
         
           
          
           
            <Columns>
                <asp:TemplateField>
                  
                    <ItemTemplate>
                        
                         <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="true" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
           
          
         
           
          
           
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
           
        </asp:GridView>
          <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
          </ContentTemplate>
   <Triggers>
      <asp:AsyncPostbackTrigger ControlID="btnAdd" EventName="Click" />
   </Triggers>
</asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
