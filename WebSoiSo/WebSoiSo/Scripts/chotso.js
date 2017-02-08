$(function () {
    $('#btnDangky').click(function () {
        var sdt = $('#number').val();
        var nickname = $('#nickname').val();
        var email = $('#email').val();
        var password = $('#password').val();
        var confirm_password = $('#confirm_password').val();
        
        var strError = '';
        if (sdt == '') {
            strError = '<p style="color:red">Hãy nhập Số điện thoại</p>';
        }
        if (nickname == '') {
            strError += '<p style="color:red">Hãy nhập Nickname</p>';
        }
        if (password == '') {
            strError += '<p style="color:red">Hãy nhập Mật khẩu</p>';
        }
        if (confirm_password == '') {
            strError += '<p style="color:red">Hãy nhập Nhập lại mật khẩu</p>';
        }
        if (confirm_password != '' && password != '' && password!=confirm_password) {
            strError += '<p style="color:red">Xác nhận mật khẩu không chính xác</p>';
        }
        if (email == '') {
            strError += '<p style="color:red">Hãy nhập Email</p>';
        }

        if (strError=='')
        {
            $('#frmDK').submit();
        }
        else
        {
            $('#lstError').html(strError);
            $('body,html').animate({ scrollTop: 0 }, 600);
            return false;
        }
    })

    $('#btnDangNhap').click(function () {        
        var nickname = $('#nickname').val();        
        var password = $('#password').val();
        

        var strError = '';
       
        if (nickname == '') {
            strError += '<p style="color:red">Hãy nhập Nickname</p>';
        }
        if (password == '') {
            strError += '<p style="color:red">Hãy nhập Mật khẩu</p>';
        }        

        if (strError == '') {
            $('#frmDangNhap').submit();
        }
        else {
            $('#lstError').html(strError);
            $('body,html').animate({ scrollTop: 0 }, 600);
            return false;
        }
    })
    $('#btnDoiMatKhau').click(function () {
        var old_password = $('#old_password').val();
        var new_password = $('#new_password').val();
        var conf_new_password = $('#conf_new_password').val();

        var strError = '';

        if (old_password == '') {
            strError += '<p style="color:red">Hãy nhập Mật khẩu cũ</p>';
        }
        if (new_password == '') {
            strError += '<p style="color:red">Hãy nhập Mật khẩu mới</p>';
        }
        if (conf_new_password == '') {
            strError += '<p style="color:red">Hãy nhập Nhập lại mật khẩu</p>';
        }
        if (conf_new_password != '' && old_password != '' && new_password != '' && new_password != conf_new_password) {
            strError += '<p style="color:red">Xác nhận mật khẩu không chính xác</p>';
        }
        if (strError == '') {
            $('#frmDoiMatKhau').submit();
        }
        else {
            $('#lstError').html(strError);
            $('body,html').animate({ scrollTop: 0 }, 600);
            return false;
        }
    })
});