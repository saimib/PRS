$(document).ready(function () {


    $("#KioskContent_Headimg").hover(function () {
        $("#picleft").html("<img src=\"../Images/11.1.1.png\" />");
        $("#picright").html("<img src=\"../Images/11.2.1.png\" />");
    }, function () {
        $("#picleft").html("<img src=\"../Images/11.1.png\" />");
        $("#picright").html("<img src=\"../Images/11.2.png\" />");
    });

    $("#KioskContent_chestimg").hover(function () {
        $("#picleft").html("<img src=\"../Images/11.1.2.png\" />");

    }, function () {
        $("#picleft").html("<img src=\"../Images/11.1.png\" />");

    });

    $("#KioskContent_Abdomenimg").hover(function () {
        $("#picleft").html("<img src=\"../Images/11.3.1.png\" />");

    }, function () {
        $("#picleft").html("<img src=\"../Images/11.1.png\" />");

    });


    $("#KioskContent_scrotumimg").hover(function () {
        $("#picleft").html("<img src=\"../Images/11.1.4.png\" />");

    }, function () {
        $("#picleft").html("<img src=\"../Images/11.1.png\" />");

    });

    $("#KioskContent_backimg").hover(function () {
        $("#picright").html("<img src=\"../Images/11.2.2.png\" />");

    }, function () {
        $("#picright").html("<img src=\"../Images/11.2.png\" />");

    });

    $("#KioskContent_bottomimg").hover(function () {
        $("#picright").html("<img src=\"../Images/11.2.3.png\" />");

    }, function () {
        $("#picright").html("<img src=\"../Images/11.2.png\" />");

    });

    $("#KioskContent_armimg").hover(function () {
        $("#picleft").html("<img src=\"../Images/12.1.png\" />");
        $("#picright").html("<img src=\"../Images/12.2.png\" />");
    }, function () {
        $("#picleft").html("<img src=\"../Images/11.1.png\" />");
        $("#picright").html("<img src=\"../Images/11.2.png\" />");
    });

    $("#KioskContent_legimg").hover(function () {
        $("#picleft").html("<img src=\"../Images/11.1.6.png\" />");
        $("#picright").html("<img src=\"../Images/11.2.5.png\" />");
    }, function () {
        $("#picleft").html("<img src=\"../Images/11.1.png\" />");
        $("#picright").html("<img src=\"../Images/11.2.png\" />");
    });

    var i = 0;
    $("#KioskContent_imgbtnNp").hover(function () {
        $(this).css("background-color", "black");
    }, function () {

        $(this).css("background-color", "#bdbdbd");

    });

    $("#KioskContent_imgbtnMp").hover(function () {
        $("#KioskContent_imgbtnNp").css("background-color", "black");
        $(this).css("background-color", "black");
    }, function () {
        $("#KioskContent_imgbtnNp").css("background-color", "#bdbdbd");
        $(this).css("background-color", "#bdbdbd")

    });

    $("#KioskContent_imgbtnMdp").hover(function () {
        $("#KioskContent_imgbtnNp").css("background-color", "black");
        $("#KioskContent_imgbtnMp").css("background-color", "black");
        $(this).css("background-color", "black");
    }, function () {
        $("#KioskContent_imgbtnNp").css("background-color", "#bdbdbd");
        $("#KioskContent_imgbtnMp").css("background-color", "#bdbdbd");
        $(this).css("background-color", "#bdbdbd");
    });

    $("#KioskContent_imgbtnSp").hover(function () {
        $("#KioskContent_imgbtnNp").css("background-color", "black");
        $("#KioskContent_imgbtnMp").css("background-color", "black");
        $("#KioskContent_imgbtnMdp").css("background-color", "black");
        $(this).css("background-color", "black");
    }, function () {
        $("#KioskContent_imgbtnNp").css("background-color", "#bdbdbd");
        $("#KioskContent_imgbtnMp").css("background-color", "#bdbdbd");
        $("#KioskContent_imgbtnMdp").css("background-color", "#bdbdbd");
        $(this).css("background-color", "#bdbdbd");
    });

    $(".slab").click(function () {
        $(this).css({ "background-color": "white", "color": "black" });
    });



    $('#downclick').click(function () {

        $('#KioskContent_Button1').remove();

        $('.listbox').append("<input type=\"submit\" name=\"ctl00$KioskContent$ctl06\" value=\"Leg\" class=\"slab\"/>");
    });

   





});