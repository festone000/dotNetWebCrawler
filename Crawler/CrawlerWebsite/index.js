$(document).ready(function () {

    $.ajax({
        url: 'https://www.liepin.com/event/landingpage/soejob4landingpage.json',
        type: "POST",
        dataType: "json",
        data: {
            key: '架构师',
            dqs: ''
        },
        success: function success(data) {
            alert(data)
        },
        error: function error(err) {
            alert(err.statusText)
        }

    });






});