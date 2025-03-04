import * as lib from 'https://assets.website-files.com/6067559c86540cc17e19c4d5/js/tricks-menu-slider.00af47acc.js';

/* For Splide Slider_section */
    var elms = document.getElementsByClassName( 'splide' );
    for ( var i = 0, len = elms.length; i < len; i++ ) {
        var splide=  new lib.Splide( elms[ i ], {
        perPage: 3,
        perMove: 1,
        type   : 'loop',
        focus  : 'center',
        breakpoints: {
            767: {
            perPage: 1,
            }
        }
        } );
        splide.on('moved', function (newIndex) {
                    var activeSlide = splide.Components.Elements.slides[newIndex];
                    var newContent = activeSlide.dataset.info;
                    document.getElementById("Product-Name").textContent = newContent;
                });
        splide.mount();
        var initialSlide = splide.Components.Elements.slides[splide.index];
        document.getElementById("Product-Name").textContent = initialSlide.dataset.info;
    }
    $('.Div_Controlrs .Controlrs_Container a.next_Arrow').click(function() {
        $(this).closest('.section').find('.splide__arrow.splide__arrow--next').click();
    });
    $('.Div_Controlrs .Controlrs_Container a.prev_Arrow').click(function() {
        $(this).closest('.section').find('.splide__arrow.splide__arrow--prev').click();
    });
    
    
    

