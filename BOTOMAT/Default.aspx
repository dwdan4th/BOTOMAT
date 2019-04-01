<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BOTOMAT._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div><h1>LeaderBoard</h1></div>
 
    <div>Create Robot</div>
    <fieldset>
        <label for="robotName">Name</label><input type="text" id="robotName" style="width:200px" />	
        <select name="Robot Description" id="desc">
		<option value="1">UNIPEDAL</option>
		<option value="2">BIPEDAL</option>
		<option value="3">QUADRUPEDAL</option>
		<option value="4">ARACHNID</option>
        <option value="5">RADIAL</option>
        <option value="6">AERONAUTICAL</option>
	</select>
 <%--       <input type="button" onclick="CreateRobotClick()" />  --%>

    </fieldset>

</asp:Content>
