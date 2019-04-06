$(document).ready(function () {
    jQuery.support.cors = true;

 
    LodadDate_Category();
});






//----------------------------------------Start Category-------------------------


function LodadDate_Category() {

    $.ajax({
        type: "GET",
        dataType: "json",
        url: "http://localhost:51072/api/Category",
      
        success: function (data) {
            var html = '';
            console.log(data);
            $.each(data, function (key, Item) {
                html += '<tr>';
                html += '<td>' + Item.id + '</td>';
                html += '<td>' + Item.name + '</td>';
                html += '<td><a href="#" onclick="return getCatgById(' + Item.id + ')">Edit</a> | <a href="#" onclick="Delele(' + Item.id + ')">Delete</a></td>';

                html += '<tr/>';

            });
            $('.tbody_Category').html(html);

        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }

    });

}



function Add() {

    var CgtAdd = new Object();
    CgtAdd.Name = $("#Category_Name").val();

    $.ajax({
        type: "POST",
        dataType: "json",
        url: "http://localhost:51072/api/Category",
        data: CgtAdd,
        success: function (Data) {
            LodadDate_Category();
            $("#Category_Modal").modal("hide");
            
        },
        error: function (errormessage) {

            alert(errormessage.responseText);

        }

    });
}


function getCatgById(GetID) {
    $.ajax({
        type:"Get",
        url: "http://localhost:51072/api/Category/" + GetID,
        dataType: "json",
        success: function (Result) {
            $("#Category_Name").val(Result.name);
            $("#Category_Modal").modal("show");
            $('#btnUpdate').show();
            $('#btnAdd').hide();

        }, error: function (errormessage) {
            alert(errormessage.responseText);
        }

    });
    return false;
}

function Update() {
    var UpdaCag = new Object();
    UpdaCag.Name = $("#Category_Name").val();

    $.ajax({
        type: "PUT",
        dataType: "json",
        data: JSON.stringify(UpdaCag),
        url: "http://localhost:51072/api/Category/",
        crossDomain: true,
        xhrFields: {
            withCredentials: true
        },
        success: function (Result) {
            LodadDate_Category();
            $("#Category_Modal").modal("hide");
            $('#btnUpdate').hide();
            $('#btnAdd').show();
            $("#Category_Name").val("");

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
            url: "http://localhost:51072/api/Category/" + ID,
            type: "DELETE",
            dataType: "json",
            success: function (result) {
                LodadDate_Category();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}