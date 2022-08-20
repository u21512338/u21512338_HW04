$(document).ready(function () {

    $(".money").show();
    $(".food").hide();
    $(".clothing").hide();


    $("#donationType").on("change", function () {
        var val = $(this).val();
        if (val == "1") {
            $(".money").show();
            $(".food").hide();
            $(".clothing").hide();
        }
        if (val == "2") {
            $(".food").show();
            $(".money").hide();           
            $(".clothing").hide();
        }
        if (val == "3") {
            $(".clothing").show();
            $(".money").hide();
            $(".food").hide();            
        }

    });
})