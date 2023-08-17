
// SORTING-PRODUCTS
$(document).ready(function () {

    $(document).on("change", "#sorting", function () {
      
        let optionValue = $(this).val();

        let parent = $(".filtering-products");

        let data = { value: optionValue }

        if (optionValue == "descending-by-price") {
            $.ajax({
                url: "Shop/SortByDescendingPrice",
                type: "Get",
                data: data,
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
                data: data,
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
                data: data,
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
                data: data,
                success: function (res) {
                    parent.empty();
                    parent.append(res)
                }
            })
        }
       
    })
})
// SORTING-PRODUCTS
