// ADD-PRODUCT-TO-BASKET
$(document).ready(function () {
    $(document).on("click", ".product-add-to-cart", function (e) {
        e.preventDefault();

        let productId = $(this).attr("data-id");

        let data = { id: productId }

        $.ajax({
            url: "Cart/AddToCart",
            type: "Post",
            data: data,
            success: function (res) {
                $(".cart-count").text(res);
            }
            })
    })
})
// ADD-PRODUCT-TO-BASKET



// DELETE-PRODUCT-FROM-BASKET
$(document).ready(function () {
    $(document).on("submit", ".delete-product", function (e) {

        e.preventDefault();

        $(this).parent().parent().remove();

        let productId = $(this).attr("data-id");

        let data = { id: productId }

        $.ajax({
            url: "Cart/DeleteFromCart",
            type: "Post",
            data: data,
            success: function (res) {
          
                $(".cart-count").text(res.grandTotalCount);
                if (res.grandTotalCount != 0) {
                    $(".grand-total-price").text(res.grandTotalPrice);
                }
                else {
                    $(".cart").addClass("d-none");
                    $(".cart-empty").removeClass("d-none"); 
                }              
            }
        })
    })
})
// DELETE-PRODUCT-FROM-BASKET





