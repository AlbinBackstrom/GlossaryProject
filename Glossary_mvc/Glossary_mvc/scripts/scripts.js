$("#btn-add").click(function () {
    $(".tmp").append('<div class="row block"><div class="col-md-4 col-md-offset-4"><input type="text" class="form-control"></div><div class="col-md-4"><input type="text" class="form-control"></div></div>')
});

$("#btn-remove").click(function () {
    $(".block:last-child").last().remove();
})
