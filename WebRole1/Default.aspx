<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebRole1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 <h2>Excercise 2</h2>
    <asp:Label ID="Message" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <div style="left:auto;right:auto;">
    <asp:Table ID="Table1" runat="server" Width="700px" 
            style="text-align: center; margin-left: 130px" >
        <asp:TableHeaderRow Width="350px">
            <asp:TableHeaderCell>Action</asp:TableHeaderCell>
            <asp:TableHeaderCell>IO</asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="GetAverageBtn" Text="Get Current Average" runat="server" onclick="GetAverageBtn_Click"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Label ID="AverageGrade" runat="server" />
            </asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell><br /></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow BorderStyle="Dashed">
            <asp:TableCell><br /></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="UpdateGradeBtn" Text="Update Student Grade" runat="server" onclick="UpdateGradeBtn_Click"/>
            </asp:TableCell><asp:TableCell HorizontalAlign="Right">
                    Enter student ID: <asp:TextBox ID="StudentID" runat="server" />
                    <br />
                    Enter student grade: <asp:TextBox ID="Grade" runat="server" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</div>            
</asp:Content>
