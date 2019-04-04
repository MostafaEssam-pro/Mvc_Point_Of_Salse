$(document).ready(function () {
    LodadDate_Department();
});




//----------------------------------------Start Department-------------------------


function LodadDate_Department() {

    $.ajax({
        type: "GET",
        dataType: "json",
        url: "http://localhost:51072/api/Department",
        success: function (data) {
            var html = '';
            $.each(data, function (key, Item) {
                html += '<tr>';
                html += '<td>' + Item.id + '</td>';
                html += '<td>' + Item.name + '</td>';
                html += '<td><a href="#" onclick="return getdeprtById(' + Item.id + ')">Edit</a> | <a href="#" onclick="Delele(' + Item.id + ')">Delete</a></td>';

                html += '<tr/>';

            });
            $('.tbody_Department').html(html);

        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }

    });

}


function Add() {
    var deprtAdd = new Object();
    deprtAdd.Name = $("#Name").val();

    $.ajax({
        type: "POST",
        dataType: "json",
        url: "http://localhost:51072/api/Department",
        data: deprtAdd,
        success: function (Data) {
            LodadDate_Department();
            $("#modals_Department").modal("hide");
            Close();

        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}



function getdeprtById(GetID) {
    $.ajax({
        type: "Get",
        url: "http://localhost:51072/api/Department/" + GetID,
        dataType: "json",
        success: function (Result) {
            $("#Name").val(Result.name);
            $("#modals_Department").modal("show");
            $('#btnUpdate').show();
            $('#btnAdd').hide();

        }, error: function (errormessage) {
            alert(errormessage.responseText);
        }

    });
    return false;
}



function Update() {
    var Updadeprt = new Object();
    Updadeprt.Name = $("#Name").val();

    $.ajax({
        type: "PUT",
        dataType: "json",
        data:Updadeprt,
        url: "http://localhost:51072/api/Department/",
        success: function (Result) {
            LodadDate_Category();
            $("#modals_Department").modal("hide");
            $('#btnUpdate').hide();
            $('#btnAdd').show();
            Close();

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
            url: "http://localhost:51072/api/Department/" + ID,
            type: "DELETE",
            dataType: "json",
            success: function (result) {
                LodadDate_Department();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}


function Close() {

    $("#Name").val("");

}