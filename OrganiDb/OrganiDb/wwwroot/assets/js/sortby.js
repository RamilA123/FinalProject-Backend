
// SORTING-PRODUCTS
$(document).ready(function () {

    $(document).on("change", "#sorting", function () {
      
        let optionValue = $(this).val();

        let parent = $(".filtering-products");

        if (optionValue == "descending-by-price") {
            $.ajax({
                url: "Shop/SortByDescendingPrice",
                type: "Get",
                success: function (res) {
                    parent.empty();
                    parent.append(res)
                }
            })
        }

        if (optionValue == "ascending-by-price") {
            $.ajax({
                url: "Shop/SortByAscendingPrice",
                type: "Get",
                success: function (res) {
                    parent.empty();
                    parent.append(res)
                }
            })
        }

        if (optionValue == "ascending-by-name") {
            $.ajax({
                url: "Shop/SortByAscendingName",
                type: "Get",
                success: function (res) {
                    parent.empty();
                    parent.append(res)
                }
            })
        }

        if (optionValue == "descending-by-name") {
            $.ajax({
                url: "Shop/SortByDescendingName",
                type: "Get",
                success: function (res) {
                    parent.empty();
                    parent.append(res)
                }
            })
        }
       
    })
})
// SORTING-PRODUCTS



// SORTING-BLOGS
$(document).ready(function () {

    $(document).on("change", "#sorting", function () {

        let optionValue = $(this).val();

        let parent = $("#blog .sorting-blogs");

        if (optionValue == "ascending-by-title") {
            $.ajax({
                url: "Blog/SortByAscendingTitle",
                type: "Get",
                success: function (res) {
                    parent.empty();
                    parent.append(res)
                }
            })
        }

        if (optionValue == "descending-by-title") {
            $.ajax({
                url: "Blog/SortByDescendingTitle",
                type: "Get",
                success: function (res) {
                    parent.empty();
                    parent.append(res)
                }
            })
        }
    })
})
// SORTING-BLOGS