@Code
    Layout = "~/_SiteLayout.vbhtml"

End Code
<script>
    $(window).ready(function () {

        if (currentUser != null) {

            var username = currentUser["name"];
            $('#loggedinspan').text("Вход выполнен под пользователем: " + username);
        }
        else {
            $('#loggedinspan').text('');
        };

        $('.form-signin').on('submit', function (e) {
            e.preventDefault();

            var email = $('#email').val();
            var password = $('#password').val();

            try {
                var user = Backendless.UserService.login(email, password, true);
                if (user != null) {
                    console.log("Login: green");
                    window.location = "admin";
                }
                else {
                    console.log("Login: red");
                    alert('Ошибка неправильный логин/пароль');
                }
            }
            catch (e) {
                console.log("Login: red - " + e.message);
                $('#errorLogin').modal('show');
                alert('Ошибка неправильный логин/пароль');
            }
        });
    });

</script>
<div class="row">
    <div class="col-md-4"></div>
    <div class="col-md-4">
        <div class="main-container">
            <form class="form-signin" role="form">
                <h2 class="form-signin-heading">Вход</h2>
                <input type="text" id="email" name="email" class="form-control" placeholder="Email" required="" autofocus=""><br />
                <input type="password" id="password" name="password" class="form-control" placeholder="Пароль" required="">
                @*<a href="../admin/forget">Забыли пароль?</a><br />*@
                <a href="../admin/logout"><span id="loggedinspan"></span></a>
                <hr />
                <button class="btn btn-lg btn-primary btn-block" type="submit">Вход</button>
            </form>
        </div>
    </div>
    <div class="col-md-4"></div>

</div>
