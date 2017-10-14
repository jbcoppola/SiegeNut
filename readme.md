# SiegeNut

###### Live project demo: [http://siegenut.gearhostpreview.com/]

## Overview

SiegeNut is an MVC ASP.NET application of a fictional website for a company which buys and sells siege equipment. The concept was one I originally used in a previous project, and I wanted to come back and fully flesh out the concept now that my knowlege of MVC is more advanced. 

The site features account authentication, CRUD functionality for products and reviews, and a live database. Everything is viewable without logging in, but in order to create a new review or product the user must log in as an admin or create their own ordinary user account. There is a custom five-star rating system for reviews, and users have the ability to link to pictures for products. The UI is fully responsive at any screen size.

Users can search for a particular review by selecting a field and searching for either text or by rating (a number 0 to 5). They can also sort the listed reviews by field or in ascending/descending order. Users can only edit and delete their own reviews, unless they are an admin, in which they can edit or delete any review or product.

The project took about three weeks start to finish.

## Resources used

- Microsoft-MVC
- SQL database
- Javascript
- jQuery
- Bootstrap 3.3.7
- HTML5 / CSS

## Challenges

1. **Challenge:** Implementing a five-star clickable rating system

   **Solution:** This is a feature that I really wanted but isn't part of any MVC package, leaving me to implement it myself. The solution I came up with was to first create four images, a full and empty version of the left and right halves of a star. By using a double nested for loop in razor, filled half-star images are placed for every half point in a review, and the rest of the images are empty stars until they reach 5. Every star image also has its rating as the value property, so the first star is .5, the second is 1, etc. When on the review edit page, hovering over a particular image will trigger a jquery script which replaces all stars up to that value with full stars, with the higher value stars empty. It reverts if the cursor moves without clicking. Clicking on the image will set the rating to that value and briefly highlight all the stars by changing their background color. 

2. **Challenge:** Allow searching and sorting of reviews

   **Solution:** Searching is a key part of many of the features I wanted to have, such as the ability to link to product reviews on the product page, so this feature was planned from the start. Sorting was added in later as a convenience to the user. The first step was to create a viewmodel which held all the data I needed to send back to the controller to tell it how to sort and search. I created a viewmodel with all the review data plus five extra fields, for the search field, search string, search rating, sort by field, and sort order. The viewmodel data is sent either when the "submit" button is clicked to search, or when the user selects one of the sorting button options. The controller pulls a list of reviews from the database, checks the fields with if and switch statements, and sorts the displayed reviews accordingly. This list is then fed to the pagination function, and the correct list for the current page is returned to the view. If the user has put in a new search, the page is returned to page 1.

3. **Challenge:** Creating a distinctive UI

   **Solution:** The majority of pages feature card UI with the active parts of the page in white hovering over the light gray background. Previous to this point my UI had been based entirely around color, spacing, borders and sizing. While these are important design considerations my UI had always been visually flat. For this project I found that this left the overall effect lacking, and in an effort to make it look better I started making elements look different heights using box-shadows. This made an immediate positive difference and made the UI much more visually distinct.

## Code Samples

jQuery script for the star rating system

```
$(document).ready(function () {
    //ratings scripts
    var currentRating = $('.ratings').children('input').val();
    var v;
    $('.ratings img').on('mouseover', function () {
        var onStar = $(this).attr('value'); // The star with cursor over it
        StarUpdate(this, onStar); //shows rating hovered over
    }).on('mouseout', function () {
        StarUpdate(this, currentRating); //reverts to default rating or selected rating
    });

    $('.ratings img').on('click', function () {
        $(this).parent().children().animate({ backgroundColor: 'yellow' }, 0).animate({ backgroundColor: 'transparent' }, "fast"); //highlight on click
        currentRating = $(this).attr('value'); // store value of currently selected star
        $("#Rating").val(currentRating); //changes value of hidden field
    });
    

function StarUpdate(f, rating) {
    $(f).parent().children().each(function (e) {
        v = $(this).attr('value');
        if (v <= rating) { //filled or empty star check
            if (v % 1 != 0) { $(this).attr('src', '/Images/half star left.png') } //...and left or right
            else { $(this).attr('src', '/Images/half star right.png') }
        }
        else {
            if (v % 1 != 0) { $(this).attr('src', '/Images/half empty star left.png') }
            else { $(this).attr('src', '/Images/half empty star right.png') }
        }
    });
}
});
```

The switch statement determining which field to search

```
switch (searchField)
                {
                    case "Product":
                        reviews = reviews.Where(r => r.Product.Name.Contains(searchString)
                                       || r.Product.Name.Contains(searchString));
                        break;
                    case "Rating":
                        if (searchRating >= 1 && searchRating <= 4)
                        {
                            reviews = reviews.Where(r => r.Rating <= searchRating + 1 && r.Rating >= searchRating);
                        }
                        else { reviews = reviews.Where(r => r.Rating == searchRating); }
                        break;
                    case "Author":
                        reviews = reviews.Where(r => r.Author.UserName.Contains(searchString));
                        break;
                    default:
                        break;
                }
```

Function for determining whether the user is logged in as an Admin, used in the controller. The resulting bool is used to determine whether the user can access certain pages.

```
   private bool IsAdmin() {
            if (User.Identity.IsAuthenticated)
            {
                var id = User.Identity.GetUserId();
                var user = db.Users.First(x => x.Id == id);
                return user.AccountType == ApplicationUser.AdminAccountType;
            }
            return false;
        }
```