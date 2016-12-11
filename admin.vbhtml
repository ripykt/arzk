@Code
    Layout = "~/_SiteLayout.vbhtml"
End Code

<script>

    function maintable(args) {
        args = args || {},
        this.data = args.data || "",
        this.destination = args.destination || "",
        this.time = args.time || "";
    }

    $(document).ready(function () {
        if (Backendless.UserService.getCurrentUser() == null) {
            window.location = "../login"
        } else {
            //currentUser = Backendless.UserService.getCurrentUser();

            

        }

        var storage = Backendless.Persistence.of(maintable).find().data;
        console.log(storage[0]);

        document.getElementById("dest_D33E4F90-6C59-416E-FF91-6E923BF00800").value = storage[0].destination;
        document.getElementById("date_D33E4F90-6C59-416E-FF91-6E923BF00800").value = storage[0].data;
        document.getElementById("time_D33E4F90-6C59-416E-FF91-6E923BF00800").value = storage[0].time;

        document.getElementById("dest_43B2A071-5FDB-8849-FF07-6D2F4CCBBF00").value = storage[1].destination;
        document.getElementById("date_43B2A071-5FDB-8849-FF07-6D2F4CCBBF00").value = storage[1].data;
        document.getElementById("time_43B2A071-5FDB-8849-FF07-6D2F4CCBBF00").value = storage[1].time;
    });

    function save() {
        var dest1 = document.getElementById("dest_D33E4F90-6C59-416E-FF91-6E923BF00800").value;
        var dest2 = document.getElementById("dest_43B2A071-5FDB-8849-FF07-6D2F4CCBBF00").value;

        var date1 = document.getElementById("date_D33E4F90-6C59-416E-FF91-6E923BF00800").value;
        var date2 = document.getElementById("date_43B2A071-5FDB-8849-FF07-6D2F4CCBBF00").value;

        var time1 = document.getElementById("time_D33E4F90-6C59-416E-FF91-6E923BF00800").value;
        var time2 = document.getElementById("time_43B2A071-5FDB-8849-FF07-6D2F4CCBBF00").value;

        var storage = Backendless.Persistence.of(maintable).find().data;

        storage[0].destination = dest1;
        storage[0].data = date1;
        storage[0].time = time1;
        Backendless.Persistence.of(maintable).save(storage[0]);

        storage[1].destination = dest2;
        storage[1].data = date2;
        storage[1].time = time2;
        Backendless.Persistence.of(maintable).save(storage[1]);


    }
</script>

<div class="text-center" style="margin:40px;">
    <h2>Вводите нужные данные и нажимайте "Отправить"</h2>
</div>
<div class="table-responsive" style="margin:auto;width:50%;">
    <table class="table table-bordered">
        <thead>
            <tr>
                <td>Пункт назначения:</td>
                <td>Дата:</td>
                <td>Время:</td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td id="tabb1"><input id="dest_D33E4F90-6C59-416E-FF91-6E923BF00800" type="text" value="" style="width:80%" /></td>
                <td id="tabb2"><input id="date_D33E4F90-6C59-416E-FF91-6E923BF00800" type="text" value="" style="width:80%" /></td>
                <td id="tabb3"><input id="time_D33E4F90-6C59-416E-FF91-6E923BF00800" type="text" value="" style="width:80%" /></td>
            </tr>
        </tbody>
    </table>
</div>
<div class="table-responsive" style="margin:auto;width:50%;">
    <table class="table table-bordered">
        <thead>
            <tr>
                <td>Место на схеме:</td>
                <td>Дата:</td>
                <td>Время:</td>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td id="tabb1"><input id="dest_43B2A071-5FDB-8849-FF07-6D2F4CCBBF00" type="text" value="" style="width:80%" /></td>
                <td id="tabb2"><input id="date_43B2A071-5FDB-8849-FF07-6D2F4CCBBF00" type="text" value="" style="width:80%" /></td>
                <td id="tabb3"><input id="time_43B2A071-5FDB-8849-FF07-6D2F4CCBBF00" type="text" value="" style="width:80%" /></td>
            </tr>
        </tbody>
    </table>
</div>

<div class="text-center">
    <button class="btn btn-primary" onclick="save();">Отправить</button>
</div>

<div style="width:50%;margin:auto" class="text-center">

    <div class="pull-left">
        <h2><a href="~/">Вернуться на главную</a></h2>
    </div>

    <div class="pull-right">
        <h2><a href="logout.vbhtml">Выйти из системы</a></h2>
    </div>

</div>