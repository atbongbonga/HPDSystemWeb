$(function () {

    $.ajax({
        url: '/HPDUtilityWeb/Home/GetErrorCountByIncharge',
        dataType: "json",
        method: 'post',
        success: function (data) {
            var employeeCard = $('#cardEmpLst');
            employeeCard.empty();
            data = JSON.parse(data);
            $(data).each(function (index, emp) {
                employeeCard.append(
                    '<div class="col-xl-3 col-sm-6 mb-3">' +
                    '<div class="card text-white bg-primary o-hidden h-100">' +
                    '<div class="card-body">' +
                    '<div class="card-body-icon">' +
                    '<i class="fas fa-fw fa-briefcase"></i>' +
                    '</div>' +
                    '<div class="text-center" ">' +
                    '<img src="/HPDUtilityWeb/Content/image/Global/icon-image.png" class="rounded-circle" width="200px" height="200px alt="">'+
                    '</div>'+
                    '<div class="mr-5"><h5>' + emp.InCharge + '</h5></div>' +
                    '</div>' +
                    '<a class="card-footer text-white clearfix small z-1" id="EmployeeDetail" data-id="' + emp.InCharge +'" href="#">' +
                    '<p>Issue Commited : <span class="badge badge-danger">' + emp.IssueCount + '</span></p>' +
                    '</a>' +
                    '</div>' +
                    '</div >'
                );
            });
        },
        error: function (err) {
            alert(err);
        }
    });

    $(document).on('click', '#EmployeeDetail',function() {
        var incharge = $(this).attr("data-id");
        $.post("/HPDUtilityWeb/Home/GetErrorCountByInchargeProgram", { InCharge:incharge }, function (data) {
            var employeeCard = $('#cardEmpLst');
            employeeCard.empty();
            data = JSON.parse(data);
            $(data).each(function (index, emp) {
                employeeCard.append(
                    '<div class="col-xl-3 col-sm-6 mb-3">' +
                    '<div class="card text-white bg-success o-hidden h-100">' +
                    '<div class="card-body">' +
                    '<div class="card-body-icon">' +
                    '<i class="fas fa-fw fa-briefcase"></i>' +
                    '</div>' +
                    '<div class="mr-5"><h5>' + emp.ProgramName + '</h5></div>' +
                    '</div>' +
                    '<a class="card-footer text-white clearfix small z-1" id="ProjectDetail" data-id="' + emp.ProgramName + '" href="#">' +
                    '<p>Issue Commited : <span class="badge badge-danger">' + emp.IssueCount + '</span></p>' +
                    '</a>' +
                    '</div>' +
                    '</div >'
                );
            });
        }, "json");
    });

    $(document).on('click', '#ProjectDetail', function () {

        var progname = $(this).attr("data-id");
        $.post("/HPDUtilityWeb/Home/GetErrorListByProgram", { ProgramName: progname }, function (data) {
            var errorlogTbl = $('#errorlogTable');
            errorlogTbl.empty();
            data = JSON.parse(data);
            $(data).each(function (index, err) {
                var docdate = new Date(parseInt(err.DocDate.substr(6)));
                var fdocdate = docdate.getDate() + '/' + (docdate.getMonth() + 1) + '/' + docdate.getFullYear();
                errorlogTbl.append('<tr>' +
                    '<td>' + err.ErrCode + '</td>' +
                    '<td>' + err.ErrMsg + '</td>' +
                    '<td>' + err.DocEntry +'</td>' +
                    '<td>' + err.DocDate +'</td>' +
                    '</tr>'
                );
            });
        }, "json");
        $('#errlogmodal').modal('toggle');
    });

});  