$('a').click(function () {
    $('a').removeClass('selected'); // remove selected from any other item first
    $(this).addClass('selected'); //add selected to the one just clicked.
});