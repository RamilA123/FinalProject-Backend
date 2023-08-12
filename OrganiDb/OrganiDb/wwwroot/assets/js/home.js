// FLAG
let flagHeader = document.querySelector(".flag-header");

let flags = document.querySelectorAll(".flag-item");

flagHeader.addEventListener("click", function () {
    if (this.nextElementSibling.classList.contains("invisible")) {

        this.nextElementSibling.classList.remove("invisible");
        this.nextElementSibling.style.cssText = `
        height: 78px;
        `
    }
    else {
        this.nextElementSibling.classList.add("invisible");
        this.nextElementSibling.style.cssText = `
        height: 0;
        `
    }
})

for (const flag of flags) {

    flag.addEventListener("click", function () {

        let flagText = this.closest(".flags").firstElementChild.firstElementChild.firstElementChild.innerText

        let flagImage = this.closest(".flags").firstElementChild.firstElementChild.children[1].firstElementChild.getAttribute("src");

        this.closest(".flags").firstElementChild.firstElementChild.firstElementChild.innerText = this.firstElementChild.innerText;

        this.closest(".flags").firstElementChild.firstElementChild.children[1].firstElementChild.setAttribute("src", this.lastElementChild.firstElementChild.getAttribute("src"));

        this.firstElementChild.innerText = flagText;

        this.lastElementChild.firstElementChild.setAttribute("src", flagImage);

        if (!this.parentNode.classList.contains("invisible")) {

            this.parentNode.classList.add("invisible");
            this.parentNode.style.cssText = `
            height: 0;
            `
        }
    })
}
// FLAG




// UP-ARROW
let upArrow = document.querySelector(".up-arrow");

upArrow.addEventListener("click", function () {
    window.scrollTo(0,0);
})
// UP-ARROW




// DROPDOWN-MENU
let dropdownTitles = document.querySelectorAll(".drop-down-title")
let dropdownMenues = document.querySelectorAll(".drop-down-menu")

for (const dropdown of dropdownTitles) {
    dropdown.addEventListener("mouseover",function(){
        this.firstElementChild.children[0].style.color = "green";
        this.firstElementChild.children[1].style.width = "100%";
        this.firstElementChild.children[2].style.color = "green";
    })

    dropdown.addEventListener("mouseout",function(){
        this.firstElementChild.children[0].style.color = "";
        this.firstElementChild.children[1].style.width = "0%";
        this.firstElementChild.children[2].style.color = "";
    })
}

for (const dropdown of dropdownMenues) {
    dropdown.addEventListener("mouseover",function(){
        this.previousElementSibling.firstElementChild.children[0].style.color = "green";
        this.previousElementSibling.firstElementChild.children[1].style.width = "100%";
        this.previousElementSibling.firstElementChild.children[2].style.color = "green";
    })

    dropdown.addEventListener("mouseout",function(){
        this.previousElementSibling.firstElementChild.children[0].style.color = "";
        this.previousElementSibling.firstElementChild.children[1].style.width = "0%";
        this.previousElementSibling.firstElementChild.children[2].style.color = "";
    })
}
// DROPDOWN-MENU




// OWL-CAROUSEL
$(document).ready(function () {

    $('.loop').owlCarousel({
        center: true,
        items: 2,
        loop: true,
        margin: 10,
        responsive: {
            600: {
                items: 4
            }
        }
    });

    $('.nonloop').owlCarousel({
        center: true,
        items: 2,
        loop: false,
        margin: 10,
        responsive: {
            600: {
                items: 4
            }
        }
    });

});
// OWL-CAROUSEL




// COUNTDOWN
let targetTime = document.querySelector("#countdown .target-time").innerText;

const targetDate = new Date(targetTime).getTime();

const countdownInterval = setInterval(function () {

    const currentDate = new Date().getTime();

    const remainingTime = targetDate - currentDate;

    const numberOfDays = Math.floor(remainingTime / (1000 * 60 * 60 * 24));
    const numberOfHours = Math.floor((remainingTime % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
    const numberOfMinutes = Math.floor((remainingTime % (1000 * 60 * 60)) / (1000 * 60));
    const numberOfSeconds = Math.floor((remainingTime % (1000 * 60)) / 1000);

    document.getElementById("days").innerText = numberOfDays;
    document.getElementById("hours").innerText = numberOfHours;
    document.getElementById("minutes").innerText = numberOfMinutes;
    document.getElementById("seconds").innerText = numberOfSeconds;

}, 1000);
// COUNTDOWN




// SHOW-MORE-OR-LESS
$(document).ready(function () {



    //TOP-FEATURED-PRODUCTS

    $(document).on("click", ".show-more-featured", function (e) {
            e.preventDefault();

            let skipCount = $(".featured-products").children().length;

            let featuredParent = $(".featured-products");

            let data = { skip: skipCount }

            $.ajax({
                url: "Home/ShowMoreOrLessForFeatured",
                type: "Get",
                data: data,
                success: function (res) {

                    featuredParent.append(res);

                    let featuredProductCount = $(".featured-products").attr("data-count");

                    if (featuredProductCount == featuredParent.children().length) {
                        $(".show-more-featured").addClass("d-none");
                        $(".show-less-featured").removeClass("d-none");
                    }
                }
            })

        })

    $(document).on("click", ".show-less-featured", function (e) {
            e.preventDefault();

            let skipCount = 0

            let featuredParent = $(".featured-products");

            let data = { skip: skipCount }

            $.ajax({
                url: "Home/ShowMoreOrLessForFeatured",
                type: "Get",
                data: data,
                success: function (res) {

                    featuredParent.empty();
                    featuredParent.append(res);

                    if (skipCount == 0) {
                        $(".show-more-featured").removeClass("d-none");
                        $(".show-less-featured").addClass("d-none");
                    }
                    else {

                    }
                }
            })
       
    })

    //TOP-FEATURED-PRODUCTS




    //TOP-SALE-PRODUCTS

    $(document).on("click", ".show-more-sale", function (e) {
        e.preventDefault();

        let skipCount = $(".sale-products").children().length;

        let saleParent = $(".sale-products");

        let data = { skip: skipCount }

        $.ajax({
            url: "Home/ShowMoreOrLessForSale",
            type: "Get",
            data: data,
            success: function (res) {

                saleParent.append(res);

                let saleProductCount = $(".sale-products").attr("data-count");

                if (saleProductCount == saleParent.children().length) {
                    $(".show-more-sale").addClass("d-none");
                    $(".show-less-sale").removeClass("d-none");
                }
            }
        })

    })

    $(document).on("click", ".show-less-sale", function (e) {
        e.preventDefault();

        let skipCount = 0

        let saleParent = $(".sale-products");

        let data = { skip: skipCount }

        $.ajax({
            url: "Home/ShowMoreOrLessForSale",
            type: "Get",
            data: data,
            success: function (res) {

                saleParent.empty();
                saleParent.append(res);

                if (skipCount == 0) {
                    $(".show-more-sale").removeClass("d-none");
                    $(".show-less-sale").addClass("d-none");
                }
                else {

                }
            }
        })

    })

    //TOP-SALE-PRODUCTS



    //TOP-RATED-PRODUCTS

    $(document).on("click", ".show-more-rated", function (e) {
        e.preventDefault();

        let skipCount = $(".rated-products").children().length;

        let ratedParent = $(".rated-products");

        let data = { skip: skipCount }

        $.ajax({
            url: "Home/ShowMoreOrLessForRated",
            type: "Get",
            data: data,
            success: function (res) {

                ratedParent.append(res);

                let ratedProductCount = $(".rated-products").attr("data-count");

                if (ratedProductCount == ratedParent.children().length) {
                    $(".show-more-rated").addClass("d-none");
                    $(".show-less-rated").removeClass("d-none");
                }
            }
        })

    })

    $(document).on("click", ".show-less-rated", function (e) {
        e.preventDefault();

        let skipCount = 0

        let ratedParent = $(".rated-products");

        let data = { skip: skipCount }

        $.ajax({
            url: "Home/ShowMoreOrLessForRated",
            type: "Get",
            data: data,
            success: function (res) {

                ratedParent.empty();
                ratedParent.append(res);

                if (skipCount == 0) {
                    $(".show-more-rated").removeClass("d-none");
                    $(".show-less-rated").addClass("d-none");
                }
                else {

                }
            }
        })

    })

    //TOP-RATED-PRODUCTS


})
// SHOW-MORE-OR-LESS