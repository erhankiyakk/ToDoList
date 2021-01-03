        $(document).ready(function () {
            $("#addButton").click(function () {
                var newToDo = $("#addToList").val();
                var x = $("#myTask").html();
                if (newToDo.length>0){
                    var y = "<tr><td class= 'col' >" + newToDo +
                        '</td><td class= "col"><button class="btn btn-light">' +
                        '<i class="fas fa-trash-alt"></i></button></td ></tr >';
                    $("#myTask").html(x + y);
                    $("#addToList").val("");
                }
            });
            $(document).on("click", "button.btn-light", function () {
                $(this).parent().parent().remove();
            });
        });