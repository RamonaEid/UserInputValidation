$(function () {
    var listResults = $("#ResultList").val();
    listResults = "<li>" + listResults.replace(/,/g, "</li><li>") + "</li>";
    $("#listResults").append(listResults);

    $("#inputStr").on("click", function() {
        $(this).val("");
        $("#resultDisplay").html("");
    });

    var resultDisplayText = $("#resultDisplay").html().toString();
    if (resultDisplayText.indexOf("Oops") == -1) {
        // text-success lead
        if (resultDisplayText.indexOf("Bingo") == -1)
            $("#resultDisplay").attr("class", "text-winner lead");
        else
            $("#resultDisplay").attr("class", "text-bingo lead");
    }

});