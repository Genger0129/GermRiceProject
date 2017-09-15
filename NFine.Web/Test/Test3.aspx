<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test3.aspx.cs" Inherits="NFine.Web.Test.Test3" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="/Content/js/jquery/jquery-2.1.1.min.js" type="text/javascript"></script>
    <script src="/Content/js/jquery/jquery.form.js" type="text/javascript"></script>
</head>
<body>
    <form id="form3" method ='post'  action = '#'  runat="server" enctype="multipart/form-data">
    <div>
    <input type="file" class="fileinput" style="width: 150px;font-size: 0.12rem; height: 40px;display: inline-block;" 
        name="FaceInfo"/>
    <p><input type="submit" id="submit3" value="确认" /></p>
    </div>
    </form>
    
    <script type="text/javascript">
        $(function () {
            $("#submit3").click(function () {
                var options = {
                    url: "/api/AppInterface/FaceRecognition",
                    success: function (data) {
                        alert(data.message);
                    }
                };
                $("#form3").ajaxForm(options);
            })
        })
    </script>
</body>
</html>

