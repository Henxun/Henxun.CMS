function registerSubmit(controller) {
    layui.use(['form', 'jquery'], function () {
        var form = layui.form, $ = layui.$;
        form.on('submit(confirm)', function (data) {
            console.info(data.field);
            $.ajax({
                type: "POST",
                dataType: "json",
                url: "/"+controller+"/Post",
                data: data.field,
                success: function (result) {
                    if (result.resultCode == 0) {
                        layer.msg(result.resultMsg, { icon: 6, area: ['450px', ''], shade: [0.5, '#000', true] });
                        var index = parent.layer.getFrameIndex(window.name);
                        parent.layer.close(index);//关闭弹出的子页面窗口
                        parent.layui.table.reload('table');
                    } else {
                        layer.msg(result.resultMsg, { icon: 2, area: ['450px', ''], shade: [0.5, '#000', true] });
                    }
                    //window.parent.location.reload();//写在这里的话是只有提交成功了才刷新那个页面
                },
                error: function (err) {
                    layer.msg(err.responseText, { icon: 2, area: ['450px', ''], shade: [0.5, '#000', true] });
                }
            });
            return false;
        });
    })
}