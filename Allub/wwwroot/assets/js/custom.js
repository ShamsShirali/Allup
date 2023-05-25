$(document).ready(function () {
    let page = window.location.pathname.split('/')[1];

    console.log(page.length)

    if (page.length == 0) {
        $('.Home').addClass('active');
    }
    else {
        $('.' + page).addClass('active');
    }
})