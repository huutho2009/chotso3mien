$(function () {
    $('#btnSave').click(function () {
        var NgayTao = $('#dtpNgayTao').val();
        var strErr;
        if(NgayXo == null)
            strErr = '<p style="color:red">Hãy chọn ngày xổ</p>';
        if(NgayTao == null)
            strErr += '<p style="color:red">Hãy chọn ngày tạo</p>';
        if (strErr == '') {
            $('#frmCreate').submit();
        }
        else {
            $('#lstError').html(strErr);
            $('body,html').animate({ scrollTop: 0 }, 600);
            return false;
        }
    })
});