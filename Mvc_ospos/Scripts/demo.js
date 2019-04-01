// Auto update layout
(function() {
  window.layoutHelpers.setAutoUpdate(true);
  // window.attachMaterialRippleOnLoad();
})();

// Collapse menu
(function() {
  if ($('#layout-sidenav').hasClass('sidenav-horizontal') || window.layoutHelpers.isSmallScreen()) {
    return;
  }

  try {
    window.layoutHelpers.setCollapsed(
      localStorage.getItem('layoutCollapsed') === 'true',
      false
    );
  } catch (e) {}
})();

$(function() {
  // Initialize sidenav
  $('#layout-sidenav').each(function() {
    new SideNav(this, {
      orientation: $(this).hasClass('sidenav-horizontal') ? 'horizontal' : 'vertical'
    });
  });

  // Initialize sidenav togglers
  $('body').on('click', '.layout-sidenav-toggle', function(e) {
    e.preventDefault();
    window.layoutHelpers.toggleCollapsed();
    if (!window.layoutHelpers.isSmallScreen()) {
      try { localStorage.setItem('layoutCollapsed', String(window.layoutHelpers.isCollapsed())); } catch (e) {}
    }
  });

  if ($('html').attr('dir') === 'rtl') {
    $('#layout-navbar .dropdown-menu').toggleClass('dropdown-menu-right');
  }
});

$(function() {
    // ***************************************************
    // Menu Customizer HTML
    $('body').append('' +
        '<div id="ui-builder" class="ui-builder">' +
            '<div class="style-toggler">' +
                '<a href="javascript:"></a>' +
            '</div>' +
            '<div class="ui-block">' +
                '<div class="style-head">' +
                    '<h5 class="m-0">Empire Admin Live UI Personalize</h5>' +
                '</div>' +
                '<div class="style-body">' +
                    '<div class="scroll-div mst-scroll">' +
                        '<label class="switcher switcher-dark mb-3 w-100 text-right">' +
                            '<input type="checkbox" class="switcher-input" id="nav-dark">' +
                            '<span class="switcher-indicator">' +
                                '<span class="switcher-yes">' +
                                    '<span class="ion ion-md-checkmark"></span>' +
                                '</span>' +
                                '<span class="switcher-no">' +
                                    '<span class="ion ion-md-close"></span>' +
                                '</span>' +
                            '</span>' +
                            '<span class="switcher-label"><b>Dark Sidebar background</b></span>' +
                        '</label><br>' +
                        '<label class="switcher switcher-dark mb-3 w-100 text-right">' +
                            '<input type="checkbox" class="switcher-input" id="brand-dark" checked>' +
                            '<span class="switcher-indicator">' +
                                '<span class="switcher-yes">' +
                                    '<span class="ion ion-md-checkmark"></span>' +
                                '</span>' +
                                '<span class="switcher-no">' +
                                    '<span class="ion ion-md-close"></span>' +
                                '</span>' +
                            '</span>' +
                            '<span class="switcher-label"><b>Dark Brand background</b></span>' +
                        '</label><br>' +
                        '<label class="switcher switcher-dark mb-4 w-100 text-right">' +
                            '<input type="checkbox" class="switcher-input" id="head-dark" checked>' +
                            '<span class="switcher-indicator">' +
                                '<span class="switcher-yes">' +
                                    '<span class="ion ion-md-checkmark"></span>' +
                                '</span>' +
                                '<span class="switcher-no">' +
                                    '<span class="ion ion-md-close"></span>' +
                                '</span>' +
                            '</span>' +
                            '<span class="switcher-label"><b>Dark Header background</b></span>' +
                        '</label><br>' +
                        '<h6 class="mb-2">header background</h6>' +
                        '<div class="layout header-color mb-4">' +
                            '<a href="#!" class=" active" data-val="bg-white"><span></span><span></span></a>' +
                            '<a href="#!" class="" data-val="bg-dark"><span></span><span></span></a>' +
                            '<a href="#!" class="bg-primary" data-val="bg-primary"><span></span><span></span></a>' +
                            '<a href="#!" class="" data-val="bg-danger"><span></span><span></span></a>' +
                            '<a href="#!" class="" data-val="bg-success"><span></span><span></span></a>' +
                            '<a href="#!" class="" data-val="bg-warning"><span></span><span></span></a>' +
                            '<a href="#!" class="" data-val="bg-info"><span></span><span></span></a>' +
                        '</div>' +
                        '<label class="switcher switcher-dark mb-4 w-100 text-right">' +
                            '<input type="checkbox" class="switcher-input" id="navbar-fixed" checked>' +
                            '<span class="switcher-indicator">' +
                                '<span class="switcher-yes">' +
                                    '<span class="ion ion-md-checkmark"></span>' +
                                '</span>' +
                                '<span class="switcher-no">' +
                                    '<span class="ion ion-md-close"></span>' +
                                '</span>' +
                            '</span>' +
                            '<span class="switcher-label"><b>Navbar Fixed</b></span>' +
                        '</label><br>' +
                        '<label class="switcher switcher-dark mb-0 w-100 text-right">' +
                            '<input type="checkbox" class="switcher-input" id="header-fixed" checked>' +
                            '<span class="switcher-indicator">' +
                                '<span class="switcher-yes">' +
                                    '<span class="ion ion-md-checkmark"></span>' +
                                '</span>' +
                                '<span class="switcher-no">' +
                                    '<span class="ion ion-md-close"></span>' +
                                '</span>' +
                            '</span>' +
                            '<span class="switcher-label"><b>Header Fixed</b></span>' +
                        '</label><br>' +
                    '</div>' +
                '</div>' +
            '</div>' +
        '</div>');

    // ***********************************************************
    // Menu Customizer Start pachhi archna ne keje mokeup ke envato elements pa ni koi file hoy te mane ape drive ma muki ne

    // open Menu Styler
    $('#ui-builder > .style-toggler').on('click', function() {
        $('#ui-builder').toggleClass('open');
    });

    // Navbar background
    $('#nav-dark').change(function() {
        if ($(this).is(":checked")) {
            $('#layout-sidenav').removeClass('bg-white');
            $('#layout-sidenav').addClass('bg-dark');
        } else {
            $('#layout-sidenav').addClass('bg-white');
            $('#layout-sidenav').removeClass('bg-dark');
        }
    });

    // brand background
    $('#brand-dark').change(function() {
        if ($(this).is(":checked")) {
            $('#layout-sidenav').removeClass('logo-white');
            $('#layout-sidenav').addClass('logo-dark');
        } else {
            $('#layout-sidenav').addClass('logo-white');
            $('#layout-sidenav').removeClass('logo-dark');
        }
    });

    // brand background
    $('#head-dark').change(function() {
        if ($(this).is(":checked")) {
            $('#layout-navbar').removeClass('bg-white');
            $('#layout-navbar').addClass('bg-dark');
        } else {
            $('#layout-navbar').addClass('bg-white');
            $('#layout-navbar').removeClass('bg-dark');
        }
    });

    // Menu fixed
    $('#navbar-fixed').change(function() {
        if ($(this).is(":checked")) {
            $('html').addClass('layout-fixed');
        } else {
            $('html').removeClass('layout-fixed');
        }
    });

    // Header fixed
    $('#header-fixed').change(function() {
        if ($(this).is(":checked")) {
            $('html').addClass('layout-navbar-fixed');
        } else {
            $('html').removeClass('layout-navbar-fixed');
        }
    });

    // Header Color
    $('.header-color > a').on('click', function() {
        var temp = $(this).attr('data-val');
        $('#layout-navbar').removeClassPrefix('bg-');
        $('#layout-navbar').addClass(temp);
    });

    $.fn.removeClassPrefix = function(prefix) {
        this.each(function(i, it) {
            var classes = it.className.split(" ").map(function(item) {
                return item.indexOf(prefix) === 0 ? "" : item;
            });
            it.className = classes.join(" ");
        });
        return this;
    };
    // Menu Customizer End
    // ***************************************************
});




//  scss files
// .form-material {
//     position: relative;
//
//     .material-label {
//         position: absolute;
//         top: 13px;
//         left: 10px;
//         font-size: 0.8125rem;
//         margin-bottom: 0;
//         padding: 0 10px;
//         transition: all 0.15s ease-in-out;
//         i{
//             margin-right: 10px;
//         }
//     }
//
//     .form-control {
//         background: transparent;
//         border: 1px solid #ced4da;
//         position: relative;
//         z-index: 5;
//         &:focus,
//         &:hover,
//         &:active{
//             box-shadow: none;
//             outline: none;
//         }
//
//         &.fill {
//             border-color: $primary-color;
//             box-shadow: 0 0 0 1px $primary-color;
//             ~ .material-label {
//                 top: -10px;
//                 left: 11px;
//                 color: $primary-color;
//                 font-size: 14px;
//                 background: #fff;
//                 z-index: 6;
//             }
//         }
//     }
//
//     .custom-select:focus,
//     .form-control:focus {
//         background: transparent;
//     }
// }


// <script>
//     $('.form-material .form-control').each(function() {
//         if ($(this).val().length > 0) {
//             $(this).addClass("fill");
//         } else {
//             $(this).removeClass("fill");
//         }
//     });
//     $(".form-material .form-control").on("blur", function() {
//         $(this).val().length > 0 ? $(this).addClass("fill") : $(this).removeClass("fill")
//     });
//     $(".form-material .form-control").on("focus", function() {
//         $(this).addClass("fill")
//     });
// </script>



// <div class="col-sm-12">
//     <div class="card">
//         <div class="card-header">
//             <h5>new Componant</h5>
//         </div>
//         <div class="card-body">
//             <form>
//                 <div class="form-group form-material">
//                     <input type="email" class="form-control">
//                     <label class="material-label">Form control</label>
//                     <div class="clearfix"></div>
//                 </div>
//                 <div class="form-group form-material">
//                     <input type="email" class="form-control">
//                     <label class="material-label">@ Form control addons</label>
//                     <div class="clearfix"></div>
//                 </div>
//                 <div class="form-group form-material">
//                     <textarea name="textarea" class="form-control"></textarea>
//                     <label class="material-label">Textarea</label>
//                     <div class="clearfix"></div>
//                 </div>
//                 <div class="form-group">
//                     <input type="email" name="footer-email" class="form-control">
//                     <span class="form-bar"></span>
//                     <label class="float-label">Email (exa@gmail.com)</label>
//                 </div>
//             </form>
//         </div>
//     </div>
// </div>
