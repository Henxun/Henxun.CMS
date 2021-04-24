layui.use(['table', 'jquery', 'layer', 'form'], function () {
    let table = layui.table, $ = layui.$, layer = layui.layer, form = layui.form;
    table.render({
        elem: '#table',
        url: '/ManagerLog/Get',
        cols: [[
            { type: 'checkbox' },
            { field : 'id', title:'ID', align:'center'},
            { field: 'actionType', title: '类型', align: 'center' },
            { field: 'addTime', title: '时间', align: 'center' },
            { field: 'remark', title: '备注', align: 'center' },
        ]],
        page: true
    })
})