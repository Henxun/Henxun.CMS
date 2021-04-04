layui.use(['form', 'jquery'], function () {
    var form = layui.form, $ = layui.$;
    form.on('submit(add)', function (data) {
        console.log(data.field);
        $.ajax({
            type: "POST",
            dataType: "json",
            url: "/Manager/Post",
            data: data.field,
            success: function (result) {
                console.log(result);
                layer.msg(result.msg, { icon: 6, area: ['450px', ''], shade: [0.5, '#000', true] });
                var index = parent.layer.getFrameIndex(window.name);
                parent.layer.close(index);//关闭弹出的子页面窗口
                window.parent.location.reload();//写在这里的话是只有提交成功了才刷新那个页面                
                $(window.parent.document.getElementById('usersTable')).load('#usersTable');
            },
            error: function (err) {
                layer.msg(err.responseText, { icon: 2, area: ['450px', ''], shade: [0.5, '#000', true] });
            }
        });
        return false;
    })
})