
//this function loads data in the students' table 
$(document).ready(function () {
    loadData();
    loadNationalities();
    loadMajors(); 
});

function loadData() {
    $.ajax({
        url: "/Student/List",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            
            dataSet = new Array();
            var html = '';
            $.each(result, function (key, item) {

                data = [
                    item.StudentId,
                    item.Name,
                    item.Age,
                    item.NationalityName,
                    item.MajorName,
                    '<td><a href="#" onclick="return GetById(' + item.StudentId + ')">Edit</a> | <a href="#" onclick="Delete(' + item.StudentId + ')">Delete</a></td>'
                ];

                dataSet.push(data);
            });
            $('#table').DataTable({
                "searching": true,
                data: dataSet,
                "bDestroy": true
            });

        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    })

}

function loadNationalities() {

    $(document).ready(function () {
        $.ajax({
            type: "GET",
            url: "/Nationality/List",
            data: "{}",
            success: function (data) {
                var s = "";
                for (var i = 0; i < data.length; i++) {
                    s += '<option value="' + data[i].NationalityId + '">' + data[i].Name + '</option>';
                }
                $("#NationalitiesDropdown").html(s);
            }
        });
    });  
}

function loadMajors() {

    $(document).ready(function () {
        $.ajax({
            type: "GET",
            url: "/Major/List",
            data: "{}",
            success: function (data) {
                var s = "";
                for (var i = 0; i < data.length; i++) {
                    s += '<option value="' + data[i].MajorId + '">' + data[i].Name + '</option>';
                }
                $("#MajorsDropdown").html(s);
            }
        });
    });
}


function Add() {

    var nationality = {
        NationalityId: $("#NationalitiesDropdown option:selected").val()
    };

    var major = {
        MajorId: $("#MajorsDropdown option:selected").val()
    }

    var student = {
            //StudentId: $('#studentId').val(),
            Name: $('#Name').val(),
            Age: $('#Age').val(),
            StudentNationality: nationality,
            StudentMajor: major
    };
    $.ajax({
         url: "/Student/Add",
         data: JSON.stringify(student),
         type: "POST",
         contentType: "application/json;charset=utf-8",
         dataType: "json",
        success: function (result) {
              
              loadData();
            $('#myModal').modal('hide');
            $('.modal-backdrop').remove();
          
          },
          error: function (errorMessage) {
               alert(errorMessage.responseText);
           }
     });
}

function Update() {

    var nationality = {
        NationalityId: $("#NationalitiesDropdown option:selected").val()
    };

    var major = {
        MajorId: $("#MajorsDropdown option:selected").val()
    }

    var student = {
        StudentId: $('#StudentId').val(),
        Name: $('#Name').val(),
        Age: $('#Age').val(),
        StudentNationality: nationality,
        StudentMajor: major
    };

    $.ajax({
        url: "/Student/Update",
        data: JSON.stringify(student),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
           
            loadData();
            $('#myModal').modal('hide');
        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });
}

//function for deleting student's record
function Delete(id) {
    var alert = confirm("Are you sure you want to delete this record?");
    if (alert) {
        $.ajax({
            url: "/Student/Delete/" + id,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
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


function GetById(studentId) {

    $.ajax({
        url: "/Student/GetById/" + studentId,
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {

            $('#StudentId').val(result.StudentId);
            $('#Name').val(result.Name);
            $('#Age').val(result.Age);
            $("#NationalitiesDropdown").val(result.NationalityId);
            $("#MajorsDropdown").val(result.MajorId);
            $('#myModal').modal('show');
            $('#btnUpdate').show();
            $('#btnAdd').hide();
            $('#titleUpdate').show();
            $('#titleAdd').hide();
        },

        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });
}

function clearTextBox() {
    $('#myModal').modal("show");
    $('#StudentId').val("");
    $('#Name').val("");
    $('#Age').val("");
    $("#NationalitiesDropdown").val(0);
    $("#MajorsDropdown").val(0);
    $('#btnUpdate').hide();
    $('#btnAdd').show();
    $('#titleUpdate').hide();
    $('#titleAdd').show();
    $('body').addClass("model-open");
    $('.modal-backdrop').add();

}



function validateForm(action) {
    let isValid = true;

    if ($('#Name').val().trim() == "") {
        isValid = false;
        $('#Name').css('border-color', 'red');
    } else {
        $('#Name').css('border-color', '#ccc');
    }

    if ($('#Age').val().trim() == "") {
        isValid = false;
        $('#Age').css('border-color', 'red');
    } else {
        $('#Age').css('border-color', '#ccc');
    }
    if ($('#NationalitiesDropdown').val() <= 0 || $('#NationalitiesDropdown').val() == "" || $('#MajorsDropdown').val() == "Please Select") {
        $('#NationalitiesDropdown').css('border-color', 'red');
        isValid = false;
    } else {
        $('#NationalitiesDropdown').css('border-color', 'lightgrey');
    }

    if ($('#MajorsDropdown').val() <= 0 || $('#MajorsDropdown').val() == "" || $('#MajorsDropdown').val() == "Please Select") {
        $('#MajorsDropdown').css('border-color', 'red');
        isValid = false;
    } else {
        $('#MajorsDropdown').css('border-color', 'lightgrey');
    } 

    if (isValid) {
        if (action == 'add') {
            Add();
            $('#myModal').modal('hide');
        } else {
            Update();
        }
    }
}
