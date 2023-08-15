
// ADD-PRODUCT-TO-BASKET
$(document).ready(function () {

    $(document).on("click", ".product-add-to-cart", function (e) {
   
        e.preventDefault();
      
        let productId = $(this).attr("data-id");

        let data = { id: productId }

        $.ajax({
            url: "/Cart/AddToCart",
            type: "Post",
            data: data,
            success: function (res) {
              
                $(".cart-count").text(res);
                Swal.fire({
                    position: 'center',
                    icon: 'success',
                    title: 'Product added to cart',
                    showConfirmButton: false,
                    timer: 1000
                })
            }
            })
    })
})
// ADD-PRODUCT-TO-BASKET





// DELETE-PRODUCT-FROM-BASKET
$(document).ready(function () {

    $(document).on("click", ".product-delete-from-cart", function () {

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
                    $(".cart-products").addClass("d-none");
                    $(".cart-empty").removeClass("d-none");
                }
            }
        })
    })
})
// DELETE-PRODUCT-FROM-BASKET





// INCREASE-DECREASE-PRODUCT-COUNT
$(document).ready(function () {

    $(document).on("click", "#cart-table .plus", function () {
      
        let productId = $(this).attr("data-id");

        let totalPrice = $(this).parent().parent().next().next();

        let inputValue = $(this).next();

        let data = { id: productId }

        $.ajax({
            url: "Cart/IncreaseCount",
            type: "Get",
            data: data,
            success: function (res) {
                inputValue.val(res.productCount);
                $(".cart-count").text((res.grandTotalCount));
                $(".grand-total-price").text(res.grandTotalPrice);
                totalPrice.text("$" + res.totalPrice);
            }
        })
    })

    $(document).on("click", "#cart-table .minus", function () {
        
        let productId = $(this).attr("data-id");

        let totalPrice = $(this).parent().parent().next().next();

        let inputValue = $(this).prev();

        let data = { id: productId }

        $.ajax({
            url: "Cart/DecreaseCount",
            type: "Get",
            data: data,
            success: function (res) {
                inputValue.val(res.productCount);
                $(".cart-count").text((res.grandTotalCount));
                $(".grand-total-price").text(res.grandTotalPrice);
                totalPrice.text("$" + res.totalPrice);
            }
        })
    })
})
// INCREASE-DECREASE-PRODUCT-COUNT





