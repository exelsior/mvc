
$.getJSON("/JsonTest/GetJsonTest", function (response)
{
    if (response != null) {
        $("h2").append("<li>" + response.Id + " "/* + response.Name + " " + response.Author*/ + "</li>")
    }
});




/*function displayData(response)
{
    alert(response);
    if (response != null)
    {
        $("h2").append("<li>" + response.Id + " " + response.Name + " " + response.Author + "</li>")
    }
}*/