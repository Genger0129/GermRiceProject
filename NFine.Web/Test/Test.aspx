<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="NFine.Web.Test.Test" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="/Content/js/jquery/jquery-2.1.1.min.js" type="text/javascript"></script>
    <script src="/Content/js/jquery/jquery.form.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" method ='post'  action = '#'  runat="server" enctype="multipart/form-data">
    <div>
    <input type="text" name="uid" value="9f2ec079-7d0f-4fe2-90ab-8b09a8302aba"/>
    <input type="text" name="ukey" value="9f2ec079-7d0f-4fe2-90ab-8b09a8302abb"/>
    <input type="text" name="account" value="TestAccount"/>
    <input type="text" name="pwd" value="aaa"/>
    <input type="text" name="F_NickName" value="TestAccount"/>
    <input type="text" name="F_MobilePhone" value="1"/>
    <input type="text" name="F_Birthday" value="2017-09-15"/>
    <input type="text" name="F_Gender" value="男"/>
    <input type="file" class="fileinput" style="width: 150px;font-size: 0.12rem; height: 40px;display: inline-block;" 
        name="FaceInfo"/>
    <p><input type="submit" id="submit1" value="确认" /></p>
    </div>
    </form>
    <form id="form2" method ='post'  action = '#'  runat="server" enctype="multipart/form-data">
    <div>
    <input type="text" name="SubjectId" value="c3b55c9c-ee5a-4930-b4d4-cb108ef5ac56"/>
    <input type="file" class="fileinput" style="width: 150px;font-size: 0.12rem; height: 40px;display: inline-block;" 
        name="FaceInfo"/>
    <p><input type="submit" id="submit2" value="确认" /></p>
    </div>
    </form>
    <form id="form3" method ='post'  action = '#'  runat="server" enctype="multipart/form-data">
    <div>
    <input type="file" class="fileinput" style="width: 150px;font-size: 0.12rem; height: 40px;display: inline-block;" 
        name="FaceInfo"/>
    <p><input type="submit" id="submit3" value="确认" /></p>
    </div>
    </form>
    <form id="form4" method ='post'  action = '#'  runat="server" enctype="multipart/form-data">
    <div>
    <input type="text" name="SubjectId" value="c3b55c9c-ee5a-4930-b4d4-cb108ef5ac56"/>
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
            $("#submit1").click(function () {
                var options = {
                    url: "/api/AppInterface/AddSubject",
                    success: function (data) {
                        alert(data.message);
                    }
                };
                $("#form1").ajaxForm(options);
            })
            $("#submit2").click(function () {
                var options = {
                    url: "/api/AppInterface/FaceRecognitionSubject",
                    success: function (data) {
                        alert(data.message);
                    }
                };
                $("#form2").ajaxForm(options);
            })
            $("#submit3").click(function () {
                var options = {
                    url: "/api/AppInterface/FaceRecognition",
                    success: function (data) {
                        alert(data.message);
                    }
                };
                $("#form3").ajaxForm(options);
            })
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

