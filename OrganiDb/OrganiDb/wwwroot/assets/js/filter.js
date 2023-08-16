
// FILTER-BY-CATEGORY
$(document).ready(function () {

    $(document).on("click", ".filter-by-category", function () {
     
        if (!$(this).children().first().hasClass("checked")) {
            $(this).children().first().addClass("checked");
            $(this).children().first().attr("checked", "checked");
        }

        else {
            $(this).children().first().removeClass("checked");
            $(this).children().first().removeAttr("checked");
        }

        let id = $(this).children().first().attr("data-id");

        let parent = $(".filtering-products");

        let productId = $(this).children().first().attr("data-id");

        let data = { id: productId }

        let count = 0;

        let inputs = $(".category-filter")

        if ($(this).children().first().hasClass("checked")) {
            $.ajax({
                url: "Shop/FilterByCategory",
                type: "Get",
                data: data,
                success: function (res) {
                  
                    $.each(inputs, function (index, input) {
                  
                        if ($(input).hasClass("checked")){
                            count++;
                        }
                    })

                    if (count > 1) {
                        parent.append(res);
                    }
                    else {
                        parent.empty();
                        parent.append(res)
                    }

                }
            })
        }

        else {
            $.each(parent.children(), function (index, product) {
           
                if ($(product).attr("category-id") == id) {
                    product.remove();
                    if (parent.children().length == 0) {
                       
                    }
                }
               
            })
        } 
    })
})
// FILTER-BY-CATEGORY

