/* JS Document */

/******************************

[Table of Contents]

1. Vars and Inits
2. Set Header
3. Init Menu
4. InitDeptSlider
5. Init Accordions
6. Init Milestones
7. Init Tabs
8. Init Google Map
9. Init Loaders


******************************/

$(document).ready(function () {
	"use strict";

	/* 

	1. Vars and Inits

	*/

	var header = $('.header');
	var menu = $('.menu');
	var menuActive = false;
	var ctrl = new ScrollMagic.Controller();
	var map;

	setHeader();

	$(window).on('resize', function () {
		setHeader();

		setTimeout(function () {
			$(window).trigger('resize.px.parallax');
		}, 375);
	});

	$(document).on('scroll', function () {
		setHeader();
	});

	initMenu();
	initDeptSlider();
	initAccordions();
	initMilestones();
	initTabs();
	initGoogleMap();
	initLoaders();

	/* 

	2. Set Header

	*/

	function setHeader() {
		if ($(window).scrollTop() > 91) {
			header.addClass('scrolled');
		}
		else {
			header.removeClass('scrolled');
		}
	}

	/* 

	3. Init Menu

	*/

	function initMenu() {
		if ($('.hamburger').length && $('.menu').length) {
			var hamb = $('.hamburger');
			var close = $('.menu_close_container');

			hamb.on('click', function () {
				if (!menuActive) {
					openMenu();
				}
				else {
					closeMenu();
				}
			});

			close.on('click', function () {
				if (!menuActive) {
					openMenu();
				}
				else {
					closeMenu();
				}
			});


		}
	}

	function openMenu() {
		menu.addClass('active');
		menuActive = true;
	}

	function closeMenu() {
		menu.removeClass('active');
		menuActive = false;
	}

	/* 

	4. Init Dept Slider

	*/

	function initDeptSlider() {
		if ($('.dept_slider').length) {
			var deptSlider = $('.dept_slider');
			deptSlider.owlCarousel(
				{
					items: 4,
					autoplay: true,
					loop: true,
					nav: false,
					dots: false,
					margin: 30,
					smartSpeed: 1200,
					responsive:
					{
						0: { items: 1 },
						768: { items: 2 },
						992: { items: 3 },
						1200: { items: 4 }
					}
				});

			if ($('.dept_slider_nav').length) {
				var next = $('.dept_slider_nav');
				next.on('click', function () {
					deptSlider.trigger('next.owl.carousel');
				});
			}
		}
	}

	/* 

	5. Init Accordions

	*/

	function initAccordions() {
		if ($('.accordion').length) {
			var accs = $('.accordion');

			accs.each(function () {
				var acc = $(this);

				if (acc.hasClass('active')) {
					var panel = $(acc.next());
					var panelH = panel.prop('scrollHeight') + "px";

					if (panel.css('max-height') == "0px") {
						panel.css('max-height', panel.prop('scrollHeight') + "px");
					}
					else {
						panel.css('max-height', "0px");
					}
				}

				acc.on('click', function () {
					if (acc.hasClass('active')) {
						acc.removeClass('active');
						var panel = $(acc.next());
						var panelH = panel.prop('scrollHeight') + "px";

						if (panel.css('max-height') == "0px") {
							panel.css('max-height', panel.prop('scrollHeight') + "px");
						}
						else {
							panel.css('max-height', "0px");
						}
					}
					else {
						acc.addClass('active');
						var panel = $(acc.next());
						var panelH = panel.prop('scrollHeight') + "px";

						if (panel.css('max-height') == "0px") {
							panel.css('max-height', panel.prop('scrollHeight') + "px");
						}
						else {
							panel.css('max-height', "0px");
						}
					}
				});
			});
		}
	}

	/* 

	6. Initialize Milestones

	*/

	function initMilestones() {
		if ($('.milestone_counter').length) {
			var milestoneItems = $('.milestone_counter');

			milestoneItems.each(function (i) {
				var ele = $(this);
				var endValue = ele.data('end-value');
				var eleValue = ele.text();

	    		/* Use data-sign-before and data-sign-after to add signs
	    		infront or behind the counter number */
				var signBefore = "";
				var signAfter = "";

				if (ele.attr('data-sign-before')) {
					signBefore = ele.attr('data-sign-before');
				}

				if (ele.attr('data-sign-after')) {
					signAfter = ele.attr('data-sign-after');
				}

				var milestoneScene = new ScrollMagic.Scene({
					triggerElement: this,
					triggerHook: 'onEnter',
					reverse: false
				})
					.on('start', function () {
						var counter = { value: eleValue };
						var counterTween = TweenMax.to(counter, 4,
							{
								value: endValue,
								roundProps: "value",
								ease: Circ.easeOut,
								onUpdate: function () {
									document.getElementsByClassName('milestone_counter')[i].innerHTML = signBefore + counter.value + signAfter;
								}
							});
					})
					.addTo(ctrl);
			});
		}
	}

	/* 

	7. Init Tabs

	*/

	function initTabs() {
		if ($('.tab').length) {
			$('.tab').on('click', function () {
				$('.tab').removeClass('active');
				$(this).addClass('active');
				var clickedIndex = $('.tab').index(this);

				var panels = $('.tab_panel');
				panels.removeClass('active');
				$(panels[clickedIndex]).addClass('active');

				setTimeout(function () {
					$(window).trigger('resize.px.parallax');
				}, 375);
			});
		}
	}

	/* 

	8. Init Google Map

	*/

	function initGoogleMap() {
		var myLatlng = new google.maps.LatLng(34.063685, -118.272936);
		var mapOptions =
		{
			center: myLatlng,
			zoom: 14,
			mapTypeId: google.maps.MapTypeId.ROADMAP,
			draggable: true,
			scrollwheel: false,
			zoomControl: true,
			zoomControlOptions:
			{
				position: google.maps.ControlPosition.RIGHT_CENTER
			},
			mapTypeControl: false,
			scaleControl: false,
			streetViewControl: false,
			rotateControl: false,
			fullscreenControl: true,
			styles:
				[
					{
						"featureType": "road.highway",
						"elementType": "geometry.fill",
						"stylers": [
							{
								"color": "#ffeba1"
							}
						]
					}
				]
		}

		// Initialize a map with options
		map = new google.maps.Map(document.getElementById('map'), mapOptions);

		// Re-center map after window resize
		google.maps.event.addDomListener(window, 'resize', function () {
			setTimeout(function () {
				google.maps.event.trigger(map, "resize");
				map.setCenter(myLatlng);
			}, 1400);
		});
	}

	/* 

	9. Init Loaders

	*/

	function initLoaders() {
		if ($('.loader').length) {
			var loaders = $('.loader');

			loaders.each(function () {
				var loader = this;
				var endValue = $(loader).data('perc');

				var loaderScene = new ScrollMagic.Scene({
					triggerElement: this,
					triggerHook: 'onEnter',
					reverse: false
				})
					.on('start', function () {
						var bar = new ProgressBar.Circle(loader,
							{
								color: '#BA55D3',
								// This has to be the same size as the maximum width to
								// prevent clipping
								strokeWidth: 3,
								trailWidth: 0,
								trailColor: 'transparent',
								easing: 'easeInOut',
								duration: 1400,
								text:
								{
									autoStyleContainer: false
								},
								from: { color: '#BA55D3', width: 3 },
								to: { color: '#BA55D3', width: 3 },
								// Set default step function for all animate calls
								step: function (state, circle) {
									circle.path.setAttribute('stroke', state.color);
									circle.path.setAttribute('stroke-width', state.width);

									var value = Math.round(circle.value() * 100);
									if (value === 0) {
										circle.setText('0%');
									}
									else {
										circle.setText(value + "%");
									}
								}
							});
						bar.text.style.fontFamily = '"Montserrat", sans-serif';
						bar.text.style.fontSize = '16px';
						bar.text.style.fontWeight = '500';
						bar.text.style.color = "#838383";


						bar.animate(endValue);  // Number from 0.0 to 1.0
					})
					.addTo(ctrl);
			});
		}
	}

});