<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test4.aspx.cs" Inherits="NFine.Web.Test.Test4" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="/Content/js/jquery/jquery-2.1.1.min.js" type="text/javascript"></script>
    <script src="/Content/js/jquery/jquery.form.js" type="text/javascript"></script>
</head>
<body>
    <form id="form4" method ='post'  action = '#'  runat="server" enctype="multipart/form-data">
    <div>
    <input type="text" name="SubjectId" value="32c3e1d3-0cc4-4f26-aaeb-490f30e8f3b8"/>
    <input type="text" name="pwd" value="aaa"/>
    <input type="text" name="F_NickName" value="TestAccount"/>
    <input type="text" name="F_MobilePhone" value="1"/>
    <input type="text" name="F_Birthday" value="2017-09-15"/>
    <input type="text" name="F_Gender" value="男"/>
    <input type="file" class="fileinput" style="width: 150px;font-size: 0.12rem; height: 40px;display: inline-block;" 
        name="F_HeadIcon"/>
    <input type="file" class="fileinput" style="width: 150px;font-size: 0.12rem; height: 40px;display: inline-block;" 
        name="FaceInfo"/>
    <p><input type="submit" id="submit4" value="确认" /></p>
    </div>
    </form>
    
    <script type="text/javascript">
        $(function () {
            $("#submit4").click(function () {
                var options = {
                    url: "/api/AppInterface/EditSubject",
                    success: function (data) {
                        alert(data.message);
                    }
                };
                $("#form4").ajaxForm(options);
            })
        })
    </script>
</body>
</html>

