<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 23px;
        }
        .style2
        {
            height: 53px;
        }
        .style3
        {
            height: 72px;
        }
    </style>
</head>
<body bgcolor="White" style="height: 454px; width: 758px">
    <form id="form1" runat="server">
    <asp:SiteMapDataSource id="nav1" runat="server" />
    <table style="width: 100%; height: 517px;">
        <tr>
            <td class="style2" colspan="3" bgcolor="#FFF2FF">
                &nbsp;
                &nbsp;
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style3" colspan="3" align="left" bgcolor="#FFFFCC" valign="top">
            <asp:Menu ID="Menu11" runat="server" DataSourceId="nav1" />
            </td>
        </tr>
        <tr>
            <td bgcolor="#CCEEFF">
                &nbsp;
            </td>
            <td bgcolor="#CCEEFF">
                &nbsp;
            </td>
            <td bgcolor="#CCEEFF">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;
            </td>
            <td class="style1">
                &nbsp;
            </td>
            <td class="style1">
                &nbsp;
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
