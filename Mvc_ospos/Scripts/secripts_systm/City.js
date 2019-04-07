
$(document).ready(function () {
    loadData();
    Select();
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
        dataType: "json",
        success: function (data) {
            $('#modelcity').modal("hide");
            loadData();
            clearTextBox();
        },
        error: function (errormessage) {
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
           
            $('#id').val(result.id);
            $('#Namess').val(result.name);
            $("#listitem").val(result.gover);
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

function Update() {

    var proupdate = new Object();
    proupdate.id = $("#id").val();
    proupdate.Name = $('#Namess').val();
    proupdate.Governments_Id = $('#listitem').val();
    $.ajax({
        
        url: "http://localhost:51072/api/city",
    
        data: JSON.stringify(proupdate),
        
        headers: {
            "Content-Type": "application/json",
            "X-HTTP-Method-Override": "PUT"
        },
        success: function (proupdate) {
            loadData();
            $('#modelcity').modal('hide');
            clearTextBox();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);

        }

    });
}




function Delele(ID) {
    var ans = confirm("Are you sure you want to delete this Record?");
    if (ans) {
        $.ajax({
            url: "http://localhost:51072/api/city/" + ID,
            type: "DELETE",
            dataType: "json",
            success: function (result) {
                loadData();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}


function clearTextBox() {
    $('#Namess ').val("");
    $("#listitem").val($("#listitem option:first").val());
    $('#btnUpdate').hide();
    $('#btnAdd').show();

}

function Close() {

    clearTextBox();
}