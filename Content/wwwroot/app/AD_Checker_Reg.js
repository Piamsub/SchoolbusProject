function GetInput() {
    $.post("/Admin/GetInput", {
        id: $('#uerid').val(),
        prefix: $('#prefix').val(),
        firstname: $('#fname').val(),
        lastname: $('#lname').val(),
        address: $('#address').val(),
        subdistrict: $('#subdistrict').val(),
        district: $('#district').val(),
        province: $('#province').val(),
        zipcode: $('#zipcode').val(),
        phone: $('#phone').val(),
        phone2: $('#phone2').val()
    }, function (data) {
        console.log(data);
    })

}