namespace BeautyBooking.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Data.Models;

    public class ServicesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Services.Any())
            {
                return;
            }

            var services = new Service[]
                {
                    // 1. Hairdressers and hair salons
                    new Service
                    {
                        Name = "Ladies' Haircuts",
                        Description = "Never underestimate the power of a great haircut. Whether you're after a bob, layers or a buzzcut, using a combination of scissors, razorblades and even clippers, your hairdresser will help you to find your perfect look.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Blow Dry",
                        Description = "Universally known as every girl's best friend, a salon blowdry uses a hairdryer to apply hot air to damp hair, leaving it soft, silky and frizz-free. Great for every hair type, a bouncy blowdry can transform your look in under 20 minutes, allowing you to achieve a texture that's near impossible with air or natural drying alone.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Ladies' Hair Colouring",
                        Description = "Hair colouring can be as subtle or as out there as you want it to be. Best done in salon with a skilled colourist, blondes can go blonder, brunettes can be boosted, greys can be covered, or enhanced with a spot of granny hair. Not to mention every crazy colour from pink to blue to green can be achieved in the right hands.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Balayage",
                        Description = "Low maintenance and easy to grow out, Balayage and Ombre will allow you to boost your hair colour with less commitment than traditional highlights. Balayage gives a carefree, sun-kissed effect to all hair colours and ombre an edgier, urban, grown out effect.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Hair Extensions",
                        Description = "If you dream of bouncy, bountiful hair but struggle to grow it past your shoulders, or need a bit of voluminous va-va-voom, put down the supplements. Why wait months for results when you could have them in an instant with extensions?",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Children's Haircuts",
                        Description = "Your baby’s first haircut can be a nervous time for parent and child alike, but with the right preparation, you can turn a snippy situation into a beautiful moment for you both. While you might be emotional letting go of those luscious locks, your child will be more scared by lots of new sounds, sights and sensations. Don’t let this put you off taking them for that first trim, all it takes is a bit of prep...",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Men's Haircut",
                        Description = "Fades, fuseys, buzzcuts, crew cuts, brush ups... these days men’s haircuts are as varied as women’s! Whichever hairstyle you go for though, the end result should always be the same when stepping out of the hair salon: a clean and tidy haircut. So fresh!",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Men's Hair Colouring",
                        Description = "Sure, the silver-fox look is sexy on many celebrities – but in reality, the outlook can be much greyer. Whether you’re in need of years taking off or you’re simply after a fresh colour fix, there’s plenty of places out there that deliver hair to dye for.",
                        CategoryId = 1,
                    },

                    // 2. Hair removal salons
                    new Service
                    {
                        Name = "Ladies' Waxing",
                        Description = "Whether you're after a leg wax, underarms or a hollywood, waxing is the best, relatively painless semi-permanent hair removal method leaving you hair free for up to 4 weeks! So put down the razor, say goodbye to stubble and ingrown hair and embrace the smooth feeling of freshly waxed skin!",
                        CategoryId = 2,
                    },
                    new Service
                    {
                        Name = "Hollywood Waxing",
                        Description = "There are several different styles of waxes you can choose from when it comes to your bikini line, but a Hollywood wax is up there with the most popular. Designed to remove every last hair from the front and back of your bikini zone, the Hollywood wax promises a smooth and tidy finish that lasts up to a month.",
                        CategoryId = 2,
                    },
                    new Service
                    {
                        Name = "Brazilian Waxing",
                        Description = "When you want to go further than a classic bikini wax but don’t fancy anything quite as extreme as a Hollywood wax - go for a Brazilian. Think of it as a sound middle ground between all off, and all on.",
                        CategoryId = 2,
                    },
                    new Service
                    {
                        Name = "Facial Threading",
                        Description = "If you are after perfectly shaped eyebrows or a peach fuzz-free face but are not ready for dermaplaning just yet- threading is the answer: it gives your face a smooth finish for up to six weeks. Did we mention how precise and fast the treatment is? You’ll be in and out of the chair within fifteen minutes. Painless (mostly)!",
                        CategoryId = 2,
                    },
                    new Service
                    {
                        Name = "Men's Waxing",
                        Description = "Male waxing is no longer reserved for athletes nor is it a taboo, as apparently 1 in 3 men have integrated manscaping into their beauty routine. Sugaring, hot wax or wax strips are all waxing techniques that will leave you stubble free for up to four weeks. Smooth!",
                        CategoryId = 2,
                    },
                    new Service
                    {
                        Name = "Ladies' Leg Waxing",
                        Description = "If you're tired of having to shave your legs regularly and are struggling to stay on top of stubble, leg waxing is a great hair removal alternative for silky smooth legs. Using a method that removes the hair directly from the root, this tried and tested practice is a great way to keep hairy legs at bay, for women who aren't ready to try more dramatic measures.",
                        CategoryId = 2,
                    },
                    new Service
                    {
                        Name = "Bikini Waxing",
                        Description = "All hail the bikini wax! Whether you prefer a popular Brazilian or a full-blown Hollywood, bikini waxes have been boosting women’s confidence for decades. There a few better treatments that not only leave you feeling great, but lessen hair growth over time too! Perhaps you’re a bikini wax virgin, or maybe you’re looking for a new salon to visit on a regular basis. Either way, it’s all here and more on BeautyBooking.",
                        CategoryId = 2,
                    },
                    new Service
                    {
                        Name = "Laser Hair Removal",
                        Description = "Sick of shaving and tired of tweezing? Book yourself a series of laser hair removal sessions on BeautyBooking and you’ll never have to spend extra time fighting the fuzz again. Not only is laser hair removal surprisingly affordable, but the results can last for many years with little to no effort. Just imagine the cost-per-wear on that!",
                        CategoryId = 2,
                    },
                    new Service
                    {
                        Name = "Intense Pulsed Light Therapy (IPL)",
                        Description = "IPL (which stands for intense pulsed light) is an unrivalled way to wave goodbye to your fuzz forever. In fact, with IPL you can remove both small and large areas of hair in just a few sessions. Stop wasting time shaving and waxing! Book an IPL treatment and prepare to be amazed by the results.",
                        CategoryId = 2,
                    },

                    // 3. Massage Salons and Therapists
                    new Service
                    {
                        Name = "Deep Tissue Massage",
                        Description = "If you're suffering from tensions and aches that cannot be solved by a classic Swedish massage then a deep tissue massage might be the answer you're looking for! During a deep tissue massage, the pressure is stronger and concentrated on the problematic area which might lead to a little bit of discomfort. It is worth it though as it helps alleviate the pain in the long term!",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Swedish Massage",
                        Description = "Swedish massage is the most popular massage there is. It's a classic that will give you all the relaxation you need! 5 types of strokes make up the massage, the pressure can be as light or as firm as you like and it is perfect for unknotting your whole body and make you feel as light as a feather!",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Therapeutic Massage",
                        Description = "If you're stressed or have chronic pain and tension, a therapeutic massage may help to alleviate the pain; be it a back or abdominal massage, it will improve your physical condition and help you relax.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Aromatherapy Massage",
                        Description = "Feeling burnt out? If you’ve been running on empty, an aromatherapy massage could be just what you need to recharge your batteries. Essential oils can do everything from energise to de-stress or re-invigorate as well as fight common aches and pains, leaving you relaxed, limber and totally chilled out.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Couples Massage",
                        Description = "What could be dreamier than enjoying the ultimate relaxation with that someone special? Enter the couples massage!",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Hot Stone Massage",
                        Description = "If you’re looking for a stress-busting treatment designed to relax and unwind, there’s nothing better than a hot stone massage. Popular for its ability to soothe both mind and body, the hot stone massage uses a combination of gentle oils and natural stones in a bid to ease muscle tension, improve circulation and promote wellbeing. Bliss has never sounded so good...",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Face Massage",
                        Description = "Give yourself a natural and healthy glow with this underated beauty secret. Facial massage is a special kind of therapy that uses gentle upward and downward strokes to stimulate blood flow and collagen production under the skin. If you want to shine during winter and beyond, or you fancy a quick pamper session before a big night out, a simple facial massage has you covered.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Hand Massage",
                        Description = "A hand massage is an easy and quick way to relax and de-stress. Often given at the end of a manicure, or as a 10-minute session on its own, it's an ideal way to sit back and relax if you don’t have the time for a full body massage.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Shiatsu Massage",
                        Description = "If your job’s got you tearing your hair out or the kids are driving you up the wall, a shiatsu massage could be just what you need. Using intense finger pressure to relax and re-balance your energy, this type of Japanese acupressure proves it’s all in the digits.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Back, Neck & Shoulders Massage",
                        Description = "A stiff neck and poor circulation can only mean one thing: too many hours sat behind your desk. That’s why we recommend you move from one chair to another. Sound mad? Chair massage is specially designed to soothe the back, neck and head in less than 25 minutes, making it one of the quickest and most cost-effective treatments out there. Now we call that the perfect lunchtime treat...",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Foot Massage",
                        Description = "Feet, glorious feet! From power walking to work (too much time in bed? Me?) to wearing sky-high stilettos for a night of dancing and drinks, we owe our feet a lot. So why not treat your feet to a revitalising foot massage?",
                        CategoryId = 3,
                    },

                    // 4. Nail salons and nail bars
                    new Service
                    {
                        Name = "Pedicure",
                        Description = "Perfect for removing hard dead skin cells from your feet, a spoiling pedicure is perfect for keeping your toenails in clean working order. Expect to leave with smooth skin, healthy, shaped toenails and a pop of your favourite nail polish as the finishing touch.",
                        CategoryId = 4,
                    },
                    new Service
                    {
                        Name = "Manicure",
                        Description = "Whether you like your nails short and sweet, square, almond or oval, there’s a reason why manicures are up there as one of the most popular beauty treatments for women today. From french to gels, acrylic to paraffin, a professional mani will buff your hands and nails to perfection, and with hundreds of colours to choose from, will put the perfect finishing touch on any outfit.",
                        CategoryId = 4,
                    },
                    new Service
                    {
                        Name = "Gel Nails Manicure",
                        Description = "Manicures are a difficult art to master. No matter how great they look when finished, they seem to always chip within days, if not in a matter of hours. Enter the Gel nail manicure - a groundbreaking technique that uses gel polishes that get 'cured' under UV lights. The result? Shiny, strong nails for weeks and no drying time!",
                        CategoryId = 4,
                    },
                    new Service
                    {
                        Name = "Acrylic, Hard Gel & Nail Extensions",
                        Description = "Nail extensions and overlays are a good way to add strength and length to your natural nails. If you have a tendency to bite your nails this can also be a solution; let’s be honest, acrylic doesn’t taste very nice!",
                        CategoryId = 4,
                    },
                    new Service
                    {
                        Name = "Gel Nails Pedicure",
                        Description = "Do you want to have perfect feet for up to two weeks? Enter the gel nails pedicure: it’s like your usual pedicure but with clever gel polish instead of normal nail polish. The result? Shiny, chip-free toes for a very long time. Dreamy!",
                        CategoryId = 4,
                    },
                    new Service
                    {
                        Name = "Nail or Gel Polish Removal",
                        Description = "Manicures are great! What better way to have fabulous-looking nails for over two weeks? They make you feel more polished, elevate every look and are perfect for special occasions. But they grow out, and when they do, they can be a little unsightly. Thankfully, help is at hand. Head to your local salon or nail bar for professional nail or gel polish removal that’ll keep your nails healthy and strong.",
                        CategoryId = 4,
                    },

                    // 5. Face treatments
                    new Service
                    {
                        Name = "Classic Facials",
                        Description = "Your skin is being attacked by the sun and pollution everyday and your face is the most exposed; facials can help you restore elasticity, combat acne and impurities, rejuvenate your skin or even combat rosacea… the range is so broad that we could go on! The best way to know what you need is to book yourself in and the beautician will guide you through what’s suited for you. Simple!",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Eyelash Extensions",
                        Description = "Always applied by a trained therapist, eyelash extensions are individually applied fibres that are attached to your natural lashes to give temporarily enhanced length and volume. From temporary cluster to Russian Volume, each promise to give you thicker and fuller lashes that last from a few days to well over a month depending on which option you go for!",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Eyebrow Threading",
                        Description = "The perfect technique to transform any shape of brows into full, expertly groomed arches, eyebrow threading is a precision hair removal technique that involves the use of a twisted length of cotton to trap and uproot even the finest hair around your brow area.",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Acne Treatments",
                        Description = "Out, darn spot! Acne can be one of the toughest beauty bothers to treat. Depending on the type and severity of your acne, there are a range of solutions to tackle it once and for all.",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Men's Facials",
                        Description = "Men’s facials, what’s all that about? Unlike ones designed for our female counterparts, male facials are developed to combat those skincare problems we all commonly face: ingrown hairs, flakey skin, infamous razor burn and the rest. There’s dozens of different treatments, but most male facials combine massage techniques with a deep cleanse to create definition while keeping skin fresh and toned. Sign us up!",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Facials - Teen",
                        Description = "We all remember the trials and tribulations of being a teenager. Throw in a side of bad skin, and the memories are ten times more painful. Luckily, help is on hand for any cases of ‘teen face’ with targeted facials that use specially selected products for young, hormone-affected skin.",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Microdermabrasion",
                        Description = "Vacuum your way to a crystal clear complexion with microdermabrasion. One of the fastest ways to get a clearer complexion and gorgeous glow, this resurfacing treatment sands away fine lines, wrinkles, discolouration and scarring to let your younger, newer skin shine through.",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Permanent & Semi-Permanent Makeup",
                        Description = "If you want a flawless finish without the fuss, you might want to consider semi-permanent makeup. Perfect for those who want to shave time off their beauty routine, or suffer with allergies to conventional makeup, this cosmetic treatment works by inserting micropigments into the skin. The most common services requested include microblading, lip contour, permanent eyeliner, beauty spots and freckles. Hassle-free, smudge-proof and totally glam, what’s not to love?",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Makeup",
                        Description = "Sure, you’ve perfected the art of a classic eyeliner flick, but what about those occasions that call for something extra special? Ideal for us ladies who’d like to up our make up game (who wouldn’t?), professionally applied make up is a great way to boost your confidence - enhancing your natural features to create a more polished you. Because panda eyes and dodgy fake lashes are so last season…",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Non-Surgical Face Lifts",
                        Description = "Nervous about going under the knife? Non-surgical face lifts are the perfect alternative. Safer, quicker and cheaper than surgery, the non-invasive nature of treatments like fillers, botox and chemical peels will all result in a glowing and youthful appearance – no nips and tucks necessary.",
                        CategoryId = 5,
                    },

                    // 6. Body treatments
                    new Service
                    {
                        Name = "Spray Tanning and Sunless Tanning",
                        Description = "Perfect if you’re prepping for an event and haven’t dared to get your legs out for a while, a spray tan is designed to temporarily deepen your skin tone, evenly covering your body in a tanning mist that quickly absorbs into your skin leaving you with a healthy bronzed glow from head to toe.",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Body Exfoliation Treatments",
                        Description = "Whether you’re off on a holiday or just want the luxury of extra-smooth skin, booking in for a full body exfoliation is the perfect pampering treatment to combat dry, dull skin and leave you with a serious glow.",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Cellulite Treatments",
                        Description = "Cellulite is a real pain in the buttocks. You can spend hours sweating away in the gym but those stubborn bumps just won’t budge. Don’t worry, you’re not alone; nine in ten women suffer from cellulite in some form. Luckily, there are plenty of options to help roll, wrap and zap those unruly blemishes away.",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Infrared Therapy",
                        Description = "Heat can help cleanse your skin and boost your immune system. But with ever-changing weather, it can be hard to feel the heat on a regular basis (sadly!). Luckily, infrared therapy is here to help. Using a natural form of light which we feel as heat, infrared therapy can help heal your aches and pains, as well as enhancing your blood flow which, in turn, causes your skin to have a healthy glow.",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Steam and Sauna Therapy",
                        Description = "From skin detoxification to pain relief and better blood circulation, the alternative therapy of steam rooms and saunas can do wonders for wellbeing, and are a great way to naturally promote healing and relaxation for both the mind, body and soul.",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Weight Loss Treatments",
                        Description = "Back in the olden days, the only way to lose a few pounds was to cut back on your eating and exercise more. Well thankfully for us all, those clever scientists have been busy coming up with faster and more convenient ways of helping us towards that beach body. There are now dozens of weight loss treatments out there, all different yet all promising the same thing: shedding the pounds with minimal effort. So whether you’re looking to get wrapped up like a mummy, plugged into a Power Plate, or sweat it out the old fashioned way, there really is something for everyone.",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Cryotherapy",
                        Description = "Needing to chill out? You've come to the right place. This is Cryotherapy, where you're invited to freeze your way to a more fabulous you.",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Electrotherapy",
                        Description = "Boosting your body confidence just got a whole lot easier. With electrotherapy, you can lose weight, tone your body and get rid of cellulite, fast. This innovative treatment targets those pesky problem areas that once seemed impossible to shift. Forget exhausting workouts and depressing diets, electrotherapy is an easy, effective and totally safe way to shake it off.",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Hydrotherapy",
                        Description = "Whether it’s temperature-controlled baths or healing pool-based exercise routines, hydrotherapy can be a great way to melt away aches and pains caused by a host of different health issues. From arthritis to strained muscles, using a range of healing methods, water can be a great alternative treatment to getting you back to feeling yourself again.",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "No Needle Mesotherapy",
                        Description = "If you’ve been dancing in the mirror and spotted some unwanted cellulite, don’t panic. Mesotherapy has been banishing cellulite for decades. It couldn’t be simpler: all you have to do is choose the type of mesotherapy treatment you’d like (with or without needles), head to your chosen clinic and leave the rest to the experts!",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Ultrasound Therapy",
                        Description = "If you thought ultrasound was just for snapshots of your insides and grainy photos of babies-to-be, think again! Ultrasound therapy is, in fact, an innovative treatment that uses an ingenious ultrasound machine to lessen scars, stretch marks and cellulite, rejuvenate complexions, improve skin elasticity and even reduce pain and stiffness. Phew! Try it for yourself with BeautyBooking.",
                        CategoryId = 6,
                    },
                };

            // Need them in particular order
            foreach (var service in services)
            {
                await dbContext.AddAsync(service);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
