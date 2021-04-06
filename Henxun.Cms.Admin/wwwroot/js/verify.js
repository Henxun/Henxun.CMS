layui.use(['form', 'jquery'], function () {
    let form = layui.form, $ = layui.$;
    form.verify({
        userName: function (value, item) { //value：表单的值、item：表单的DOM对象
            if (!new RegExp("^[a-zA-Z0-9_\u4e00-\u9fa5\\s·]+$").test(value)) {
                return '登录名不能有特殊字符';
            }
            if (/(^\_)|(\__)|(\_+$)/.test(value)) {
                return '登录名首尾不能出现下划线\'_\'';
            }
            if (/^\d+\d+\d$/.test(value)) {
                return '登录名不能全为数字';
            }
            if (value.length > 32 || value.length < 4) {
                return '登录名长度必须符合规则';
            }
        },
        captchaCode: function (value, item) { //value：表单的值、item：表单的DOM对象
            if (!new RegExp("^[a-zA-Z0-9_\u4e00-\u9fa5\\s·]+$").test(value)) {
                return '验证码不能有特殊字符';
            }
            if (/(^\_)|(\__)|(\_+$)/.test(value)) {
                return '验证码首尾不能出现下划线\'_\'';
            }
            if (value.length !== 4) {
                return '验证码长度必须符合规则';
            }
        },
        password: function (value, item) { //value：表单的值、item：表单的DOM对象
            if (/(^\_)|(\__)|(\_+$)/.test(value)) {
                return '密码首尾不能出现下划线\'_\'';
            }
            if (value.length > 32 || value.length < 4) {
                return '密码长度必须符合规则';
            }
        },
        rePassword: function (value, item) {
            if ($('input[name=password]').val() != value) {
                return '两次密码输入不一致';
            }
        },
        newPasswordRe: function (value, item) {
            if ($('input[name=newPasswordRe]').val() != value) {
                return '两次密码输入不一致';
            }
        }
    });
})