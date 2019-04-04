
$(document).ready(function () {
    Select_Category();
    Select_Suppliers();
    loadDataItem();

});


function loadDataItem() {
    $.ajax({
        type: "GET",
        url: "http://localhost:51072/api/Item",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (Key, Item) {
                html += '<tr>';
                html += '<td>' + Item.id + '</td>';
                html += '<td>' + Item.name + '</td>';
                html += '<td>' + Item.stock + '</td>';
                html += '<td>' + Item.catg + '</td>';
                html += '<td>' + Item.supl + '</td>';
                html += '<td><a href="#" onclick="return getItemById(' + Item.id + ')">Edit</a> | <a href="#" onclick="Delele(' + Item.id + ')">Delete</a></td>';
                html += '</tr>';
            });

            $('.tbody_Item').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}


function Select_Category() {
    $.ajax({
        type: "Get",
        url: "http://localhost:51072/api/Category",
        // contentType: "application/json; charset=utf-8",
        dataType: 'json',
        success: function (data) {
            //console.log(data);

            var items = '<option>--Select  Category--</option>';
            $.each(data, function (index, val) {
                items += "<option value='" + val.id + "'>" + val.name + "</option>";
            });
            //alert(items);
            $('#Categorys_Id').html(items);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}


function Select_Suppliers() {

    $.ajax({
        type: "Get",
        url: "http://localhost:51072/api/Supplier",
    
        dataType: 'json',
        success: function (data) {
            var items = '<option>--Select  Supplier--</option>';
            $.each(data, function (index, val) {
                items += "<option value='" + val.id + "'>" + val.name + "</option>";
            });
            //alert(items);
            $('#Suppliers_Id').html(items);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}



function Add(){
    var AddItem = new Object();
    AddItem.Name_item = $("#Name_item").val();
    AddItem.Barcode = $("#Barcode").val();
    AddItem.Categorys_Id = $("#Categorys_Id").val();
    AddItem.Suppliers_Id = $("#Suppliers_Id").val();
    AddItem.Stock_Type = $("#Stock_Type").val();
    $.ajax({
        type: "POST",
        dataType: "json",
        url: "http://localhost:51072/api/Item",
        data: AddItem,
        success: function (Data) {
            loadDataItem();
            clearTextBox();
            $("#modals_item").modal("hide");       
        }, error: function (errormessage) {

            alert(errormessage.responseText);
        }


    });

}





function getItemById(GetID) {
    $.ajax({
        type: "Get",
        url: "http://localhost:51072/api/item/" + GetID,
        dataType: "json",
        success: function (Result) {
            $("#Name_item").val(Result.name);
            $("#Barcode").val(Result.Bar);
            $("#Categorys_Id").val(Result.catg);
            $("#Suppliers_Id").val(Result.supl);
            $("#Stock_Type").val(Result.stock_ty);
            $("#modals_item").modal("show");
            $('#btnUpdate').show();
            $('#btnAdd').hide();

        }, error: function (errormessage) {
            alert(errormessage.responseText);
        }

    });
    return false;
}


function Close() {

    clearTextBox();

}



function clearTextBox() {
    $('#Name_item ').val("");
    $('#Barcode ').val("");
    $("#Categorys_Id").val($("#Categorys_Id option:first").val());
    $("#Suppliers_Id").val($("#Suppliers_Id option:first").val());
    $("#Stock_Type").val($("#Stock_Type option:first").val());
    $('#btnUpdate').hide();
    $('#btnAdd').show();

}