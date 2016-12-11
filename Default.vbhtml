@Code
    Layout = "~/_SiteLayout.vbhtml"
    PageData("Title") = ""
End Code

<script>

    var bool = true;
    var check1;

    $(document).ready(function () {
        

        var storage = Backendless.Persistence.of(maintable).find().data;

        document.getElementById("tdid4").innerHTML = storage[0].destination;
        document.getElementById("tdid5").innerHTML = storage[0].data;
        document.getElementById("tdid6").innerHTML = storage[0].time;

        document.getElementById("tdid7").innerHTML = storage[0].destination;
        document.getElementById("tdid8").innerHTML = storage[0].data;
        document.getElementById("tdid9").innerHTML = storage[0].time;

        document.getElementById("tdid1").innerHTML = storage[1].destination;
        document.getElementById("tdid2").innerHTML = storage[1].data;
        document.getElementById("tdid3").innerHTML = storage[1].time;

       

    });

    function handleclick() {
        console.log('works');
        if (bool == false) {
            bool = true;
            document.getElementById('summertime').style.display = 'none';
            document.getElementById('wintertime').style.display = 'block';
        } else {
            bool = false;
            document.getElementById('summertime').style.display = 'block';
            document.getElementById('wintertime').style.display = 'none';
        }
    }

    function setSwitchery(switchElement, checkedBool) {
        if ((checkedBool && !switchElement.isChecked()) || (!checkedBool && switchElement.isChecked())) {
            switchElement.setPosition(true);
            switchElement.handleOnchange(true);
        }
    };

    function getSwitchery(switchElement) {
        return switchElement;
    };
</script>

<div class="header-wrapper">
    <header id="header" class="container-fluid" role="banner">
        <div id="logo" class="pull-left" style="font-size:16px;">
             <span class="logo-topline"><strong>Теплоход "<i>Степан Аржаков</i>"</strong></span>
        </div>

        <div class="pull-right">
            <div id="header-right" style="margin:20px;font-size: 14px;">
                <span><strong><a href="tel:+79142728655">т. 8(914)272-86-55</a></strong></span>
            </div>
        </div>

    </header>
</div>

<div id="contentpage" class="content container-fluid cr1059-off" role="main">




    <!-- LH_RES skin: null:null -->
    <div>

        <div class="row">

            <div>

                <div id="flightmanager" class="portlet flightmanager col-md-4 col-md-offset-8">
                    <div class="tab-contents">
                        <div id="flightmanager-tabpanel-1" class="tab-pane active text-center" role="tabpanel" aria-labelledby="flightmanager-tab-1" style="font-family:'Times New Roman', Times, serif">
                            <br/>
                            <h2>Предварительная продажа</h2> 
                            <h2>билетов кассы ГАВС</h2>
                            <h2><a href="http://www.gavs.yakutia.ru" class="more-link">www.gavs.yakutia.ru</a></h2>
                            <h2>г. Якутск, ул. Орджоникидзе 8</h2>
                            <br/>
                           <h3>пн-пт <strong>08<sup>00</sup>-19<sup>00</sup></strong></h3>
                            <h3>сб-вс <strong>09<sup>00</sup>-17<sup>00</sup></strong></h3>



                        </div>

                    </div>
                </div>






                <div id="HomepageStage" class="portlet stage ">
                    <div class="stagearea" >
                        <div id="slider" class="slider slick-initialized slick-slider" aria-live="off" role="toolbar" aria-busy="false">

                            <!----> <div aria-live="polite" class="slick-list draggable" style="height: 612px;">
                                <div class="slick-track" role="listbox" style="opacity: 1; width: 100%;">
                                    
                                    <div class="image stageteaser slick-slide" data-slick-index="2" tabindex="-1" role="option" aria-describedby="slick-slide32" aria-hidden="true">
                                        <div class="background-image">
                                            <img src="~/Images/97192.jpg" title="" alt="" class="" border="0"><div class="shadow"></div>
                                        </div>
                                        <div class="overlaytext">
                                            <div class="rte-content">
                                                <rte2011>
                                                    
                                                      <h3>  <span class="text-size-stage2014-large wt_ln" style="color:darkblue;text-shadow: 1px 1px 2px white;">Регулярные отправления, недорогие билеты </span>
                                                    </h3>

                                                </rte2011>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div><!---->
                            <!-- static teaser -->

                        </div>
                    </div>
                </div>




            </div>

            
        </div>



        <div class="personalized-teasers" style="display:flex;justify-content:center;align-items:center;" >




                <!-- LhQuicklinksPortlet 7_CO19VHUC6VJQ10A3J5FMQT0GQ0 -->
                <!----> <div id="pers_m" class="quicklinks-box personalized-teaser portlet col-lg-4 col-md-6 col-sm-12">
                    <div class="lh-layerhandler" data-lh-layerhandler="bg,noMenu,transitionProperty:height,transitionDuration:0.3s">
                        <div class="box-wrapper">
                            <div class="box">
                                        <h2 class="h3 wt_ln">Расчетное время прибытия т/х</h2>
                                <br/>
                                        <table class="table" style="margin-top:10px;">
                                            <thead>
                                                <tr>
                                                    <td>Пункт назначения</td>
                                                    <td>Дата</td>
                                                    <td>Время</td>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td id="tdid1"></td>
                                                    <td id="tdid2"></td>
                                                    <td id="tdid3"></td>
                                                </tr>
                                            </tbody>
                                        </table>
                            </div>
                        </div>
                    </div>
                </div><!---->
                <!-- PersonalInfoBoxPortlet 7_CO19VHUC6VJQ10A3J5FMQT0GQ2 -->



                <div id="pers_r" class="personal-info-box personalized-teaser portlet col-lg-4 hidden-md hidden-sm hidden-xs">
                    <div class="box-wrapper">
                        <div class="box">
                            <h2 class="h3 wt_ln">Принимаем груз к перевозке</h2> 
                            <h2 class="h3 wt_ln">Якутск-Жиганск</h2>
                                <table class="table" style="margin-top:5px;">
                                    <thead>
                                        <tr>
                                            <td>Место на схеме</td>
                                            <td>Дата</td>
                                            <td>Время</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td id="tdid4"></td>
                                            <td id="tdid5"></td>
                                            <td id="tdid6"></td>
                                        </tr>
                                    </tbody>
                                </table>
                        </div>
                    </div>
                </div>

           
        </div>

        <div id="showmewhensmall" class="personalized-teasers" style="display:none;justify-content:center;align-items:center;">





            <div id="pers_r" class="quicklinks-box personalized-teaser portlet col-lg-4 col-md-6 col-sm-12">
                <div class="box-wrapper">
                    <div class="box">
                        <h2 class="h3 wt_ln">Принимаем груз к перевозке</h2>
                        <h2 class="h3 wt_ln">Якутск-Жиганск</h2>
                        <table class="table" style="margin-top:5px;">
                            <thead>
                                <tr>
                                    <td>Место на схеме</td>
                                    <td>Дата</td>
                                    <td>Время</td>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td id="tdid7"></td>
                                    <td id="tdid8"></td>
                                    <td id="tdid9"></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>


        </div>



        





    </div>

    <div class="text-center">
        <h2>Схема проезда</h2>
        <h2>к месту предварительного приема груза</h2>
    </div>

    <div class="background-image">
        <img src="/Images/scheme.jpg" width="100%" title="" alt="" class="" border="0">

    </div>
    <br/><br/>
    <div class="text-center shadowBox">
        <h2>Расписания</h2>
        <p>(вкл. летнее/зимнее время:) </p>
        <div style="width:65px;height:auto;margin:0 auto;">
            <div class="onoffswitch">
                <input type="checkbox" name="onoffswitch" class="onoffswitch-checkbox" onclick="handleclick();" id="myonoffswitch" checked>
                <label class="onoffswitch-label" for="myonoffswitch"></label>
            </div>
        </div>
        

        <div id="wintertime" style="display:block;">
            <div class="table-responsive">
                <table class="table table-bordered table-responsive">
                    <tbody>
                        <tr>
                            <td colspan="3">
                                <p><strong>движение от Якутска</strong></p>
                            </td>
                            <td rowspan="3">
                                <p><strong>остановочные</strong></p>
                                <p><strong>пункты</strong></p>
                                <p>&nbsp;</p>
                            </td>
                            <td colspan="3">
                                <p><strong>движение от Жиганска</strong></p>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">
                                <p><strong>расстояние</strong></p>
                                <p><strong>км.</strong></p>
                            </td>
                            <td colspan="2">
                                <p><strong>время</strong></p>
                            </td>
                            <td rowspan="2">
                                <p><strong>расстояние</strong></p>
                                <p><strong>км.</strong></p>
                            </td>
                            <td colspan="2">
                                <p><strong>время</strong></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p><strong>прибытия</strong></p>
                            </td>
                            <td>
                                <p><strong>отправления</strong></p>
                            </td>
                            <td>
                                <p><strong>прибытия</strong></p>
                            </td>
                            <td>
                                <p><strong>отправления</strong></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p><strong>0</strong></p>
                            </td>
                            <td>
                                <p><strong>-</strong></p>
                            </td>
                            <td>
                                <p><strong>1с.06:00</strong></p>
                            </td>
                            <td>
                                <p><strong>Якутск</strong></p>
                            </td>
                            <td>
                                <p><strong>772</strong></p>
                            </td>
                            <td>
                                <p><strong>4с.18:00</strong></p>
                            </td>
                            <td>
                                <p><strong>-</strong></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p><strong>335</strong></p>
                            </td>
                            <td>
                                <p><strong>1с.19:30</strong></p>
                            </td>
                            <td>
                                <p><strong>1с.20:00</strong></p>
                            </td>
                            <td>
                                <p><strong>Сангар</strong></p>
                                <p>(р-н аэропорта)</p>
                            </td>
                            <td>
                                <p><strong>437</strong></p>
                            </td>
                            <td>
                                <p><strong>3с.21:00</strong></p>
                            </td>
                            <td>
                                <p><strong>3с.21:30</strong></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p><strong>560</strong></p>
                            </td>
                            <td>
                                <p><strong>2с.04:30</strong></p>
                            </td>
                            <td>
                                <p><strong>2с.05:00</strong></p>
                            </td>
                            <td>
                                <p><strong>о.Медвежий</strong></p>
                            </td>
                            <td>
                                <p><strong>212</strong></p>
                            </td>
                            <td>
                                <p><strong>3с.06:30</strong></p>
                            </td>
                            <td>
                                <p><strong>3с.07:00</strong></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p><strong>666</strong></p>
                            </td>
                            <td>
                                <p><strong>2с.09:30</strong></p>
                            </td>
                            <td>
                                <p><strong>2с.10:00</strong></p>
                            </td>
                            <td>
                                <p><strong>Картылабыт</strong></p>
                            </td>
                            <td>
                                <p><strong>106</strong></p>
                            </td>
                            <td>
                                <p><strong>3с.00:00</strong></p>
                            </td>
                            <td>
                                <p><strong>3с.00:30</strong></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p><strong>772</strong></p>
                            </td>
                            <td>
                                <p><strong>2с.14:30</strong></p>
                            </td>
                            <td>
                                <p><strong>-</strong></p>
                            </td>
                            <td>
                                <p><strong>Жиганск</strong></p>
                            </td>
                            <td>
                                <p><strong>0</strong></p>
                            </td>
                            <td>
                                <p><strong>-</strong></p>
                            </td>
                            <td>
                                <p><strong>2с.18:00</strong></p>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>

            <div class="table-responsive">
                <table class="table table-bordered">
                    <tbody>
                        <tr>
                            <td>
                                <p><strong>отп.</strong></p>
                            </td>
                            <td>
                                <p><strong>июль</strong></p>
                            </td>
                            <td>
                                <p><strong>август</strong></p>
                            </td>
                            <td>
                                <p><strong>сентябрь</strong></p>
                            </td>
                            <td>
                                <p><strong>окт.</strong></p>
                            </td>
                            <td rowspan="3">
                                <p>&nbsp;</p>
                                <p>&nbsp;</p>
                            </td>
                            <td>
                                <p><strong>приб.</strong></p>
                            </td>
                            <td>
                                <p><strong>июль</strong></p>
                            </td>
                            <td>
                                <p><strong>август</strong></p>
                            </td>
                            <td>
                                <p><strong>сентябрь</strong></p>
                            </td>
                            <td>
                                <p><strong>окт.</strong></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p><strong>из Як.</strong></p>
                            </td>
                            <td>
                                <p><strong>2</strong><strong>1</strong><strong>,2</strong><strong>6</strong><strong>,3</strong><strong>1</strong></p>
                            </td>
                            <td>
                                <p><strong>5,9,14,18,23,28</strong></p>
                            </td>
                            <td>
                                <p><strong>1,6,11,16,22,27</strong></p>
                            </td>
                            <td>
                                <p><strong>2</strong></p>
                            </td>
                            <td>
                                <p><strong>в Як.</strong></p>
                            </td>
                            <td>
                                <p><strong>2</strong><strong>4</strong><strong>,2</strong><strong>9</strong></p>
                            </td>
                            <td>
                                <p><strong>3,8,12,17,21,26,31</strong></p>
                            </td>
                            <td>
                                <p><strong>4,9,14,19,25,30</strong></p>
                            </td>
                            <td>
                                <p><strong>5</strong></p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p><strong>из Жиг.</strong></p>
                            </td>
                            <td>
                                <p><strong>2</strong><strong>2</strong><strong>,</strong><strong>27</strong></p>
                            </td>
                            <td>
                                <p><strong>1,6,10,15,19,24,29</strong></p>
                            </td>
                            <td>
                                <p><strong>2,7,12,17,23,28</strong></p>
                            </td>
                            <td>
                                <p><strong>3</strong></p>
                            </td>
                            <td>
                                <p><strong>в Жиг.</strong></p>
                            </td>
                            <td>
                                <p><strong>2</strong><strong>2</strong><strong>,2</strong><strong>7</strong></p>
                            </td>
                            <td>
                                <p><strong>1,6,10,15,19,24,29</strong></p>
                            </td>
                            <td>
                                <p><strong>2,7,12,17,23,28</strong></p>
                            </td>
                            <td>
                                <p><strong>3</strong></p>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>

        <div id="summertime" style="display:none;">
            <div class="table-responsive">
                <table class="table table-bordered">
                    <tbody>
                        <tr>
                            <td colspan="3" width="422">
                                движение от Якутска
                            </td>
                            <td rowspan="3" width="141">
                                остановочные<br/>
                                пункты<br />
                                <p>&nbsp;</p>
                            </td>
                            <td colspan="3" width="423">
                                движение от Жиганска<br />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2" width="141">
                                расстояние<br />
                                км<br />
                            </td>
                            <td colspan="2" width="282">
                               время<br />
                            </td>
                            <td rowspan="2" width="141">
                                расстояние<br />
                                км.<br />
                            </td>
                            <td colspan="2" width="282">
                                время<br />
                            </td>
                        </tr>
                        <tr>
                            <td width="141">
                                прибытия<br/>
                            </td>
                            <td width="141">
                                отправления<br/>
                            </td>
                            <td width="141">
                                прибытия<br/>
                            </td>
                            <td width="141">
                                отправления<br/>
                            </td>
                        </tr>
                        <tr>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 0<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1с.23:30<br/>
                            </td>
                            <td width="141">
                                Якутск<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 772<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 5с.13:00<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -<br/>
                            </td>
                        </tr>
                        <tr>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 335<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2с.13:00<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2с.13:30<br/>
                            </td>
                            <td width="141">
                                Сангар<br/>
                                <p>(р-н аэропорта)</p>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 437<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 4с.16:00<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp; 4с.16:30<br/>
                            </td>
                        </tr>
                        <tr>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 560<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2с.22:00<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2с.22:30<br/>
                            </td>
                            <td width="141">
                                о.Медвежий<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 212<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 4с.01:30<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp; 4с.02:00<br/>
                            </td>
                        </tr>
                        <tr>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 666<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 3с.03:00<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 3с.03:30<br/>
                            </td>
                            <td width="141">
                                Картылабыт<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 106<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 3с.19:00<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp; 3с.19:30<br/>
                            </td>
                        </tr>
                        <tr>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 772<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 3с.08:00<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -<br/>
                            </td>
                            <td width="141">
                                Жиганск<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 0<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -<br/>
                            </td>
                            <td width="141">
                                &nbsp;&nbsp;&nbsp;&nbsp; 3с.13:00<br/>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>

            <div class="table-responsive">
                <table class="table table-responsive">
                    <tbody>
                        <tr>
                            <td width="136">
                                &nbsp;отправление<br/>
                            </td>
                            <td width="145">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; июнь<br/>
                            </td>
                            <td width="122">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; июль<br/>
                            </td>
                            <td rowspan="3" width="97">
                                <p>&nbsp;</p>
                            </td>
                            <td width="127">
                                &nbsp;&nbsp; прибытие<br/>
                            </td>
                            <td width="139">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; июнь<br/>
                            </td>
                            <td width="139">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; июль<br/>
                            </td>
                        </tr>
                        <tr>
                            <td width="136">
                                &nbsp;&nbsp; из Якутска<br/>
                            </td>
                            <td width="145">
                                6,11,16,21,26<br/>
                            </td>
                            <td width="122">
                                1,6,11,16<br/>
                            </td>
                            <td width="127">
                                &nbsp;&nbsp;&nbsp;&nbsp; в Якутск<br/>
                            </td>
                            <td width="139">
                                &nbsp;10,15,20,25,30<br/>
                            </td>
                            <td width="139">
                                5,10,15,20<br/>
                            </td>
                        </tr>
                        <tr>
                            <td width="136">
                                &nbsp;из Жиганска<br/>
                            </td>
                            <td width="145">
                                8,13,18,23,28<br/>
                            </td>
                            <td width="122">
                                3,8,13,18<br/>
                            </td>
                            <td width="127">
                                &nbsp;&nbsp; в Жиганск<br/>
                            </td>
                            <td width="139">
                                8,13,18,23,28<br/>
                            </td>
                            <td width="139">
                                3,8,13,18<br/>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>

            <h2>Примечание: Отправление в рейс 06.06. 2016г. и 11.07.2016 будет  произведено позже на 35 минут, т.е. в 00ч 05м 07.06.2016г и 12.07.16г соответственно.</h2>
        </div>

        
    </div>

    <br/><br/>

    <div class="text-center shadowBox">
        <h2>Тарифы</h2>
        <p><strong>&nbsp;</strong></p>
        <span style="color:darkred; font-size: 24px;">Цены на билеты для взрослых</span>
        <div  style="overflow:hidden;clear:both;">
        

            <div>
                <p style="font-size:20px;"><strong>из Якутска &rarr; в Жиганск</strong></p>
                <div class="table-responsive">
                    <table class="table table-bordered table-striped">
                        <tbody>
                            <tr>
                                <td width="103">
                                    <p>класс</p>
                                </td>
                                <td width="100">
                                    <p>Якутск</p>
                                </td>
                                <td width="106">
                                    <p>о.Медвежий</p>
                                </td>
                                <td width="106">
                                    <p>Картылабыт</p>
                                </td>
                                <td width="102">
                                    <p>Жиганск</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="103">
                                    <p>1. 2м.каюта</p>
                                </td>
                                <td width="100">
                                    <p>1 кл.</p>
                                </td>
                                <td width="106">
                                    <p>7800</p>
                                </td>
                                <td width="106">
                                    <p>7900</p>
                                </td>
                                <td width="102">
                                    <p>8000</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="103">
                                    <p>2. 4м.каюта</p>
                                </td>
                                <td width="100">
                                    <p>2 кл.</p>
                                </td>
                                <td width="106">
                                    <p>6800</p>
                                </td>
                                <td width="106">
                                    <p>6900</p>
                                </td>
                                <td width="102">
                                    <p>7000</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="103">
                                    <p>3. плацкарт</p>
                                </td>
                                <td width="100">
                                    <p>3 кл.</p>
                                </td>
                                <td width="106">
                                    <p>6100</p>
                                </td>
                                <td width="106">
                                    <p>6200</p>
                                </td>
                                <td width="102">
                                    <p>6300</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="103">
                                    <p>&nbsp; 4. сидячий</p>
                                </td>
                                <td width="100">
                                    <p>4 кл.</p>
                                </td>
                                <td width="106">
                                    <p>5600</p>
                                </td>
                                <td width="106">
                                    <p>5700</p>
                                </td>
                                <td width="102">
                                    <p>5800</p>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <p>&nbsp;</p>



            </div>
            <div>
                <p style="font-size:20px;"><strong>в Якутск &rarr; из Жиганска</strong></p>
                <div class="table-responsive">
                    <table class="table table-bordered table-striped">
                        <tbody>
                            <tr>
                                <td width="93">
                                    <p>Якутск</p>
                                </td>
                                <td width="93">
                                    <p>о.Медвежий</p>
                                </td>
                                <td width="93">
                                    <p>Картылабыт</p>
                                </td>
                                <td width="93">
                                    <p>Жиганск</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="93">
                                    <p>1 кл.</p>
                                </td>
                                <td width="93">
                                    <p>7800</p>
                                </td>
                                <td width="93">
                                    <p>7900</p>
                                </td>
                                <td width="93">
                                    <p>8000</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="93">
                                    <p>2 кл.</p>
                                </td>
                                <td width="93">
                                    <p>5800</p>
                                </td>
                                <td width="93">
                                    <p>5900</p>
                                </td>
                                <td width="93">
                                    <p>6000</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="93">
                                    <p>3 кл.</p>
                                </td>
                                <td width="93">
                                    <p>5100</p>
                                </td>
                                <td width="93">
                                    <p>5200</p>
                                </td>
                                <td width="93">
                                    <p>5300</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="93">
                                    <p>4 кл.</p>
                                </td>
                                <td width="93">
                                    <p>4600</p>
                                </td>
                                <td width="93">
                                    <p>4700</p>
                                </td>
                                <td width="93">
                                    <p>4800</p>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        
        </div>
        <div style="overflow:hidden;clear:both;">


            <div>
                <p style="font-size:20px;"><strong>Якутск &harr; Сангар</strong></p>
                <div class="table-responsive">
                    <table class="table table-bordered table-striped">
                        <tbody>
                            <tr>
                                <td>
                                    <p>Якутск</p>
                                </td>
                                <td>
                                    <p>Сангар</p>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <p>4 кл.</p>
                                </td>
                                <td>
                                    <p>3200</p>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <p>&nbsp;</p>



            </div>
            <div>
                <p style="font-size:20px;"><strong>Жиганск &harr; Сангар</strong></p>

                <div class="table-responsive">
                    <table class="table table-bordered table-striped">
                        <tbody>
                            <tr>
                                <td>
                                    <p>Жиганск</p>
                                </td>
                                <td>
                                    <p>Картылабыт</p>
                                </td>
                                <td>
                                    <p>о.Медвежий</p>
                                </td>
                                <td>
                                    <p>Сангар</p>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <p>4 кл.</p>
                                </td>
                                <td>
                                    <p>1300</p>
                                </td>
                                <td>
                                    <p>2000</p>
                                </td>
                                <td>
                                    <p>4400</p>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <p>&nbsp;</p>
            </div>

            <p><strong>&nbsp;</strong></p>
            <span style="color:darkgreen; font-size: 24px;">Цены на билеты для детей</span>

            <div>
                <p style="font-size:20px;"><strong>из Якутска &rarr; в Жиганск</strong></p>
                <div class="table-responsive">
                    <table class="table table-striped table-bordered">
                        <tbody>
                            <tr>
                                <td width="103">
                                    <p>класс</p>
                                </td>
                                <td width="100">
                                    <p>Якутск</p>
                                </td>
                                <td width="106">
                                    <p>о.Медвежий</p>
                                </td>
                                <td width="106">
                                    <p>Картылабыт</p>
                                </td>
                                <td width="102">
                                    <p>Жиганск</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="103">
                                    <p>1. 2м.каюта</p>
                                </td>
                                <td width="100">
                                    <p>1 кл.</p>
                                </td>
                                <td width="106">
                                    <p>4600</p>
                                </td>
                                <td width="106">
                                    <p>4700</p>
                                </td>
                                <td width="102">
                                    <p>4800</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="103">
                                    <p>2. 4м.каюта</p>
                                </td>
                                <td width="100">
                                    <p>2 кл.</p>
                                </td>
                                <td width="106">
                                    <p>4000</p>
                                </td>
                                <td width="106">
                                    <p>4100</p>
                                </td>
                                <td width="102">
                                    <p>4200</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="103">
                                    <p>3. плацкарт</p>
                                </td>
                                <td width="100">
                                    <p>3 кл.</p>
                                </td>
                                <td width="106">
                                    <p>3600</p>
                                </td>
                                <td width="106">
                                    <p>3700</p>
                                </td>
                                <td width="102">
                                    <p>3800</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="103">
                                    <p>&nbsp; 4. сидячий</p>
                                </td>
                                <td width="100">
                                    <p>4 кл.</p>
                                </td>
                                <td width="106">
                                    <p>3300</p>
                                </td>
                                <td width="106">
                                    <p>3400</p>
                                </td>
                                <td width="102">
                                    <p>3500</p>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>

            <div>
                <p style="font-size:20px;"><strong>в Якутск &rarr; из Жиганска</strong></p>
                <div class="table-responsive">
                    <table class="table table-bordered table-striped">
                        <tbody>
                            <tr>
                                <td width="93">
                                    <p>Якутск</p>
                                </td>
                                <td width="93">
                                    <p>о.Медвежий</p>
                                </td>
                                <td width="93">
                                    <p>Картылабыт</p>
                                </td>
                                <td width="93">
                                    <p>Жиганск</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="93">
                                    <p>1 кл.</p>
                                </td>
                                <td width="93">
                                    <p>4600</p>
                                </td>
                                <td width="93">
                                    <p>4700</p>
                                </td>
                                <td width="93">
                                    <p>4800</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="93">
                                    <p>2 кл.</p>
                                </td>
                                <td width="93">
                                    <p>3400</p>
                                </td>
                                <td width="93">
                                    <p>3500</p>
                                </td>
                                <td width="93">
                                    <p>3600</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="93">
                                    <p>3 кл.</p>
                                </td>
                                <td width="93">
                                    <p>3000</p>
                                </td>
                                <td width="93">
                                    <p>3100</p>
                                </td>
                                <td width="93">
                                    <p>3200</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="93">
                                    <p>4 кл.</p>
                                </td>
                                <td width="93">
                                    <p>2700</p>
                                </td>
                                <td width="93">
                                    <p>2800</p>
                                </td>
                                <td width="93">
                                    <p>2900</p>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <p>&nbsp;</p>
            </div>

            <div>
                <p style="font-size:20px;"><strong>Якутск &harr; Сангар</strong></p>
                <div class="table-responsive">
                    <table class="table table-bordered table-striped">
                        <tbody>
                            <tr>
                                <td>
                                    <p>Якутск</p>
                                </td>
                                <td>
                                    <p>Сангар</p>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <p>4 кл.</p>
                                </td>
                                <td>
                                    <p>1900</p>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <p>&nbsp;</p>
            </div>
            <div>
                <p style="font-size:20px;"><strong>Жиганск &harr; Сангар</strong></p>
                <div class="table-responsive">
                    <table class="table table-bordered table-striped">
                        <tbody>
                            <tr>
                                <td>
                                    <p>Жиганск</p>
                                </td>
                                <td>
                                    <p>Картылабыт</p>
                                </td>
                                <td>
                                    <p>о.Медвежий</p>
                                </td>
                                <td>
                                    <p>Сангар</p>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <p>4 кл.</p>
                                </td>
                                <td>
                                    <p>800</p>
                                </td>
                                <td>
                                    <p>1200</p>
                                </td>
                                <td>
                                    <p>2700</p>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <p class="text-left">Примечание: дети от 5 до 10 лет по детским билетам, старше 10 лет по билетам для взрослых.</p>
            </div>
            <p>&nbsp;</p>

            <div>
                <span style="color:darkblue; font-size: 24px;">Стоимость провоза груза за 10 кг в рублях             </span>
                <div class="table-responsive">
                    <table class="table table-striped table-bordered">
                        <tbody>
                            <tr>
                                <td width="106">&nbsp;</td>
                                <td width="106">
                                    <p>о.Медвежий</p>
                                </td>
                                <td width="106">
                                    <p>&nbsp;Картылабыт</p>
                                </td>
                                <td width="106">
                                    <p>&nbsp;&nbsp; Жиганск</p>
                                </td>
                            </tr>
                            <tr>
                                <td width="106">
                                    <p>&nbsp;&nbsp;&nbsp;&nbsp; Якутск</p>
                                </td>
                                <td width="106">
                                    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 140</p>
                                </td>
                                <td width="106">
                                    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 140</p>
                                </td>
                                <td width="106">
                                    <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 140</p>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class="text-left">
                    <p>Примечание: дети от 5 до 10 лет по детским билетам, старше 10 лет по билетам для взрослых.</p>
                    <p>1. норма бесплатного багажа – 36 кг.</p>
                    <p>2. стоимость объемного груза 4500 рублей за м<sup>3</sup>.</p>
                    <p>3. минимальная стоимость партии груза, без сопровождающего – 500 руб.</p>
                </div>
            </div>
        </div>
        </div>


    <br/>
    <br/>
</div>


