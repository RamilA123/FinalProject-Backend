
// ADD-PRODUCT-TO-WISHLIST
$(document).ready(function () {

    $(document).on("click", ".add-to-wishlist", function (e) {

        e.preventDefault();

        console.log("Ramil")

        let productId = $(this).attr("data-id");

        let data = { id: productId }

        $.ajax({
            url: "/Wishlist/AddToWishlist",
            type: "Post",
            data: data,
            success: function (res) {
                $(".wishlist-count").text(res);
                Swal.fire({
                    position: 'center',
                    icon: 'success',
                    title: 'Product added to wishlist',
                    showConfirmButton: false,
                    timer: 1500
                })
            }
        })
    })
})
// ADD-PRODUCT-TO-WISHLIST

