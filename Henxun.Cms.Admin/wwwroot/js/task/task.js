layui.use(['table', 'jquery', 'layer', 'form'], function () {
    var table = layui.table, $ = layui.jquery, layer = layui.layer, form = layui.form;
    var tableInstance = table.render({
        elem: '#table',
        url: '/TaskInfo/Get/',
        toolbar:'#toolbar',
        cols: [[
            { type: 'checkbox' },
            { field:'id', title:'Id', align:'center'},
            { field: 'name', title: '名称', align: 'center' },
            { field: 'group', title: '分组', align: 'center' },
            { field: 'cron', title: 'Cron', align: 'center' },
            {
                field: 'status', title: '状态', align:'center', templet: function (d) {
                    if (d.Status === 0) {
                        return '<input type="checkbox" name="IsRun" value="{{d.Id}}" lay-filter="IsRun" lay-skin="switch" lay-text="启动|停止" checked>'
                    } else {
                        return '<input type="checkbox" name="IsRun" value="{{d.Id}}" lay-filter="IsRun" lay-skin="switch" lay-text="启动|停止">'
                    }
                }
            },
            {
                title: '操作', minWidth: 80, align: 'center', templet: function (d) {
                    return '<div style="display:flex;justify-content:center">' +
                        '<button class="layui-btn layui-bg-green" lay-event="edit">编辑</button>' +
                        '<button class="layui-btn layui-bg-red" lay-event="delete">删除</button></div>';
                }
            }
        ]],
        page:true
    });

    function addTask(edit) {
        var title = '添加任务';
        if (edit) {
            title = '编辑任务';
        }
        var index = layui.layer.open({
            title: title,
            type: 2,
            anim: 1,
            area: ['600px', '550px'],
            content: "/TaskInfo/AddOrModify/",
            closeBtn: 0,
            shadeClose: true,
            moveType: 1,
            success: function (layero, index) {
                var body = layero.getChildFrame('body', index);
                if (edit) {
                    console.log(edit);
                    console.log(body.find(".Name"));
                    body.find("#Id").val(edit.Id);
                    body.find(".Name").val(edit.Name);
                    body.find(".Group").val(edit.Group);
                    body.find(".Assembly").val(edit.Assembly);
                    body.find(".ClassName").val(edit.ClassName);
                    body.find(".Cron").val(edit.Cron);
                    body.find(".StartTime").val(edit.StartTime);
                    body.find(".EndTime").val(edit.EndTime);
                    body.find(".Status").val(edit.Status);
                    body.find(".Description").text(edit.Description);
                    form.render();
                }
            }
        })
    }

    function del(id) {
        if (id.length < 1)
            return;
        $.ajax({
            type: 'post',
            url: '/TaskInfo/Delete/',
            data: { Id: [id] },
            dataType: "json",
            headers: {
                "X-CSRF-TOKEN-yilezhu": $("input[name='AntiforgeryKey_yilezhu']").val()
            },
            success: function (res) {
                layer.msg(res.ResultMsg, { time: 2000 }, function () {
                    tableInstance.reload();
                });
            },
            error: function (error) {
                layer.msg(error.responseText, { icon: 2, area: ['450px', ''], shade: [0.5, '#000', true] });
            }
        })
    }

    function delMulti() {
        var checkStatus = table.checkStatus('table'),
            data = checkStatus.data;
        let ids = [];
        data.forEach(e => {
            ids.push(e.id);
        })
        del(ids);
    }

    function search() {
        let key = document.getElementById('key').value;
        tableInstance.reload({
            where: {
                key: key
            }
        })
    }

    table.on('toolbar(table)', function (obj) {
        var checkStatus = table.checkStatus(obj.config.id);
        switch (obj.event) {
            case 'search':
                search();
                break;
            case 'add':
                addTask();
                break;
            case 'delete':
                delMulti();
                break;
        }
    });

    table.on('tool(table)', function (obj) {
        var layEvent = obj.event, data = obj.data;
        if (layEvent === 'edit') {
            addTask(data);
        } else if (layEvent === 'delete') {
            del(data.Id);
        }
    });
})