<!-- <Snippet1> -->
<%@ Page Language="VB" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim circle As New Triplet(5, 7, 3)
        lblCircle.Text = "X position: " & circle.First & _
            "<br />Y position: " & circle.Second & _
            "<br />Radius: " & circle.Third

        Dim labels As New Triplet(Label1, Label2, Label3)
        Label1.Text = "Type: " & labels.First.GetType().ToString()
        Label2.Text = "ToString: " & labels.Second.ToString()
        Label3.Text = "HashCode: " & labels.Third.GetHashCode()
    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Triplet Example</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Circle Dimensions</h3>
        <asp:Label ID="lblCircle" runat="server" /><br /><br />
        <h3>Labels Within a Triplet</h3>
        Note that only object methods are available to members of a triplet regardless of type.<br />
        <asp:Label ID="Label1" runat="server" /><br />
        <asp:Label ID="Label2" runat="server" /><br />
        <asp:Label ID="Label3" runat="server" /></div>
    </form>
</body>
</html>
<!-- </Snippet1> -->