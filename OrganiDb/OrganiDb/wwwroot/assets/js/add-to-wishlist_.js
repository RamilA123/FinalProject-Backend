
// ADD-PRODUCT-TO-WISHLIST
$(document).ready(function () {

    $(document).on("click", ".add-to-wishlist", function (e) {

        e.preventDefault();


        let productId = $(this).attr("data-id");

        let wishlist = $(this);
    
        let data = { id: productId }

        $.ajax({
            url: "/Wishlist/AddToWishlist",
            type: "Post",
            data: data,
            success: function (res) {
                $(".wishlist-count").text(res);
                wishlist.children().eq(1).addClass("d-none");
                wishlist.children().last().removeClass("d-none");
                Swal.fire({
                    position: 'center',
                    icon: 'success',
                    title: 'Product added to wishlist',
                    showConfirmButton: false,
                    timer: 1000
                })
            }
        })
    })
})
// ADD-PRODUCT-TO-WISHLIST



// DELETE-PRODUCT-FROM-WISHLIST
$(document).ready(function () {

    $(document).on("click", ".product-delete-from-wishlist", function () {

        $(this).parent().parent().remove();

        let productId = $(this).attr("data-id");

        let data = { id: productId }

        $.ajax({
            url: "/Wishlist/DeleteFromWishlist",
            type: "Post",
            data: data,
            success: function (res) {
                $(".wishlist-count").text(res.grandTotalCount);
                if (res.grandTotalCount == 0) {
                    $(".wishlist-products").addClass("d-none");
                    $(".wishlist-empty").removeClass("d-none");
                }
            }
        })
    })
})
// DELETE-PRODUCT-FROM-WISHLIST


