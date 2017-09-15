<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test2.aspx.cs" Inherits="NFine.Web.Test.Test2" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="/Content/js/jquery/jquery-2.1.1.min.js" type="text/javascript"></script>
    <script src="/Content/js/jquery/jquery.form.js" type="text/javascript"></script>
</head>
<body>
    <form id="form2" method ='post'  action = '#'  runat="server" enctype="multipart/form-data">
    <div>
    <input type="text" name="SubjectId" value="32c3e1d3-0cc4-4f26-aaeb-490f30e8f3b8"/>
    <input type="file" class="fileinput" style="width: 150px;font-size: 0.12rem; height: 40px;display: inline-block;" 
        name="FaceInfo"/>
    <p><input type="submit" id="submit2" value="确认" /></p>
    </div>
    </form>
    
    <script type="text/javascript">
        $(function () {
            $("#submit2").click(function () {
                var options = {
                    url: "/api/AppInterface/FaceRecognitionSubject",
                    success: function (data) {
                        alert(data.message);
                    }
                };
                $("#form2").ajaxForm(options);
            })
        })
    </script>
</body>
</html>

