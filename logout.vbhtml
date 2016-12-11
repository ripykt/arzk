@Code
    Layout = "~/_SiteLayout.vbhtml"
End Code
<script>
    Backendless.UserService.logout();

    $(window).ready(function () {
        document.getElementById('loader_div').style.display = 'none';
    });
</script>
<h2 class="form-signin-heading">Вы вышли из системы</h2>

<a href="~/">Вернуться на главную</a>
