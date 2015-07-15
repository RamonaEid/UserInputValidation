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
        $("#resultDisplay").attr("class", "text-success lead");
    }

});