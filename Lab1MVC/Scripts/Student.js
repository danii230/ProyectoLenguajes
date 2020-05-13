
//this function loads data in the students' table 
$(document).ready(function () {
  
    loadNationalities();
    loadProvince();
    loadMajors(); 
});



function loadProvince() {

    $(document).ready(function () {
        $.ajax({
            type: "GET",
            url: "/Province/List",
            data: "{}",
            success: function (data) {
                var s = "";
                for (var i = 0; i < data.length; i++) {
                    s += '<option value="' + data[i].ProvinceId + '">' + data[i].Name + '</option>';
                }
                $("#ProvinceDropdown").html(s);
            }
        });
    });
}

function loadCanton() {

    $(document).ready(function () {
        $.ajax({
            type: "GET",
            url: "/Canton/List",
            data: "{}",
            success: function (data) {
                var s = "";
                for (var i = 0; i < data.length; i++) {
                    s += '<option value="' + data[i].CantonId + '">' + data[i].Name + '</option>';
                }
                $("#CantonDropdown").html(s);
            }
        });
    });
}


function AddStudent() {

    var user = {
        //StudentId: $('#studentId').val(),
        Email: $('#Email').val(),
        Password: $('#Password').val(),
        Name: $('#Name').val(),
        LastName: $('#LastName').val(),
        Phone: $('#Phone').val(),
        Province: $('#Province').val(),
        Canton: $('#Canton').val(),
        District: $('#District').val(),
    };

    $.ajax({
        url: "/Student/Add",
        data: JSON.stringify(user),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {

            loadData();
            $('#myModal').modal('hide');
            $('.modal-backdrop').remove();
            SendEmail();

        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    });
}

function SendEmail() {

    var email = $('#Email').val();

        $.ajax({
            url: "/Email/Add",
            data: JSON.stringify(email),
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


function AddProfessor() {

    var user = {
        //StudentId: $('#studentId').val(),
        Email: $('#Email').val(),
        Password: $('#Password').val(),
        Name: $('#Name').val(),
        LastName: $('#LastName').val(),
        Phone: $('#Phone').val(),
        Province: $('#Province').val(),
        Canton: $('#Canton').val(),
        District: $('#District').val(),
    };

    var professor = {
        IsAdmin: $('#IsAdmin').val(),

    };
    $.ajax({
        url: "/Professor/Add",
        data: JSON.stringify(user, professor),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {

            loadData();
            $('#myModal').modal('hide');
            $('.modal-backdrop').remove();
            SendEmail();

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
        Nationality: nationality,
        Major: major
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

    function clearTextBox2() {
        $('#myModalProfessor').modal("show");
        $('#StudentId').val("");
        $('#Email').val("");
        $('#Password').val("");
        $("#Name").val("");
        $("#LastName").val("");
        $("#IsAdmin").val("");
        $("#ProvinceDropdown").val(0);
        $("#CantonDropdown").val(0);
        $("#District").val("");
        $('#btnUpdate').hide();
        $('#btnAdd').show();
        $('#titleUpdate').hide();
        $('#titleAdd').show();
        $('body').addClass("model-open");
        $('.modal-backdrop').add();

    }

    function clearTextBox() {
        $('#myModalStudent').modal("show");
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

    function ModalRequest() {
        $('#myModalRequest').modal("show");
    }



