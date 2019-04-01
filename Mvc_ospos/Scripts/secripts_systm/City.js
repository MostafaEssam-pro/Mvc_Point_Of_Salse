



$(document).ready(function () {
    loadData();
});




function loadData() {

    $.ajax({
        type: "GET",
        url: "http://localhost:51072/api/city",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (Key, Item) {
                html += '<tr>';
                html += '<td>' + Item.id + '</td>';
                html += '<td>' + Item.name + '</td>';
                html += '<td>' + Item.gover + '</td>';
                html += '<td><a href="#" onclick="return getCityById(' + Item.id + ')">Edit</a> | <a href="#" onclick="Delele(' + Item.id + ')">Delete</a></td>';

                html += '</tr>';

            });
         
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}



function Select() {





$.ajax({
    type: "Get",
    url: "http://localhost:51072/api/Government",
    // contentType: "application/json; charset=utf-8",
    dataType: 'json',
    success: function (data) {
        //console.log(data);

        var items = '<option>--Select  City--</option>';
        $.each(data, function (index, val) {
            items += "<option value='" + val.id + "'>" + val.name + "</option>";

        });
        //alert(items);
        $('#listitem').html(items);
    },
    error: function (errormessage) {
        alert(errormessage.responseText);
    }
});

}




function Add() {

    var pro = new Object();
    pro.Name = $('#Namess').val();
    pro.Governments_Id = $('#listitem').val();
    $.ajax({
        type: "POST",
        url: "http://localhost:51072/api/city",
        data: pro,
        //{
            //Name: $('#Namess').val(),
            //Governments_Id: $('#listitem').val()
            
        //},
        dataType: "json",
        success: function (data) {
            console.log("dsadsa " + data);
            $('#modelcity').modal("hide");
            loadData();

            console.log("mostafa");
        },
        error: function (errormessage) {
            console.log("hiiiiiiii");
            alert(errormessage.responseText);
             
        }
           

    });
}


function getCityById(gid) {
    $.ajax({
        url: "http://localhost:51072/api/city/" + gid,
        type: "GET",
        dataType: "json",
        success: function (result) {
            Select();
            $('#Namess').val(result.name);

           
           
            console.log(result.gover);
            $('#modelcity').modal('show');
            $('#btnUpdate').show();
            $('#btnAdd').hide();
        },
        error:
            function (errormessage) {
                alert(errormessage.responseText);
            }
    });
    return false;
}

