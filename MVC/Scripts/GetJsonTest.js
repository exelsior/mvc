var actionUrl = '@Url.Action("GetJsonTest", "JsonTestController")'
$.getJSON(actionUrl, displayData);

$("h2").append("<li>" + response.Id + " " + response.Name + " " + response.Author + "</li>")