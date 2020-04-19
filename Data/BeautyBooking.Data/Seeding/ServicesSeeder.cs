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
                        Name = "Ladies' Brazilian Blow Dry",
                        Description = "The Brazilian blow dry is the answer you need to fight back frizzy hair caused by the British weather! If you are looking for a semi permanent way to smooth and nourish your hair, this straightening keratin hair treatment is for you- also no more lengthy blow dry sessions needed for up to 4 months, who’s in?",
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
                        Name = "Afro Hairdressing",
                        Description = "Whether you want to embrace your natural curls or update your look with a new style, we’ve got you covered. Thanks to our choice of specialist salons, here’s how to get your next best black hair look, from au naturale afro hairdressing to box braids and beyond…",
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
                        Name = "Japanese Straightening",
                        Description = "Curly hair can look and feel beautiful - when it chooses to be, that is. Other times it can be an unruly nightmare, refusing to be tamed and breaking more hair brushes than we care to remember. Japanese Straightening is a mane-busting procedure that can turn curly (or, you know, tumbleweed) texture into sleek locks by treating the follicles with a chemical solution that break the very bonds that give it its shape. Tempted? Come on, let’s straighten things out...",
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
                        Name = "Beard Trimming & Shaving",
                        Description = "Listen up lads - great beards don’t happen by chance, they happen by appointment. Just like the hair on your head, they can’t be left to their own devices. Experience the transformative power of a trim and you’ll understand just how great your beard can look…",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Hair Loss Treatments",
                        Description = "There was a time when if you were balding the only options open to you were wigs, toupees or an evil smelling brew from the local witchdoctor. These days, modern medicine is bristling with options for replenishing your thinning crop, ranging from pills and creams to injections. Good hair days start again here…",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Ladies' Hair Conditioning and Scalp Treatments",
                        Description = "Looking to up your mane game? Hair conditioning treatments are designed to put some life back into your locks, leaving you looking wonderful and feeling nice and relaxed. Say goodbye to damage caused by pollution, heated styling products and too much time spent in the sun, and hello to super smooth and shiny hair.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Permanent Waves",
                        Description = "Permanent waves can create beautiful curly-haired styles without the daily hassle of curling irons or the sleepless nights in rollers. Using a chemical solution to break down the bonds in the hair that give it its shape, relaxed locks are then wrapped around rods and rinsed with a neutralising solution that reforms the bonds and leaves hair looking naturally curly and feeling wonderful.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Braids",
                        Description = "No longer just a schoolgirl staple, braids have made a comeback as the coolest hairdo to hero. Whether you have the event of the season coming up or just want to up the ante on your everyday style, it’s time to twist and shout about your new plaits.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Hair Up",
                        Description = "Sometimes, only an updo will cut it. Forget any notions of patent queen curls or stiff bridesmaid ‘dos - the modern ‘hair up’ is elegant, chic, and oh-so-cool.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Men's Hair Colouring",
                        Description = "Sure, the silver-fox look is sexy on many celebrities – but in reality, the outlook can be much greyer. Whether you’re in need of years taking off or you’re simply after a fresh colour fix, there’s plenty of places out there that deliver hair to dye for.",
                        CategoryId = 1,
                    },
                    new Service
                    {
                        Name = "Wedding Hair",
                        Description = "Here comes the bride… and she’s worth it. Whether you’re after an elegant updo, perfect waves or the best blow dry of your life for your special day, it’s time to find your crowning glory. Luckily, we know all the best places...",
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
                        Name = "Ladies' Sugaring",
                        Description = "A fast and effective way to get rid of overgrown hair, sugaring is a great alternative hair removal technique for the whole body, and is especially effective for those hard-to-reach or more susceptible areas where hair is fine and skin is sensitive.",
                        CategoryId = 2,
                    },
                    new Service
                    {
                        Name = "Electrolysis",
                        Description = "Back in the 90s, it was all about the epilator. Today, hair removal has gone high-tech. Enter electrolysis, your new favourite form of hair removal. It first appeared on the beauty scene all the way back in 1875, but it’s now more effective and easier than ever. Experience the hair-free perks of electrolysis with BeautyBooking...",
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
                        Name = "Thai Massage",
                        Description = "Contrary to the Swedish massage, a Thai massage compresses and stretches your body rather than using strokes. During your massage you will remain fully clothed and the massage therapist will apply pressure on various points, loosening your muscles and alleviating joints pain. It isn't called 'lazy yoga' for nothing!",
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
                        Name = "Sports Massage",
                        Description = "When it comes to stretching, even the most diligent of gym bunnies are bound to run into the odd muscle pain from time to time. Whether you favour high intensity exercise or the lighter exertion of yoga, all that working up a sweat can get your limbs and ligaments seriously knotted up. The solution? Enter the sports massage.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Turkish Bath",
                        Description = "A Turkish bath session takes place in traditional baths, and is a ritualistic experience that involves an intense massage, followed by a sudsy scrub down and full body exfoliation. A perfect way to refresh and rejuvenate, Turkish baths are said to promote good health through massage and heat therapy.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Acupressure",
                        Description = "If you’re in need of a little relief but don't fancy being used as a human pin-cushion, acupressure is the answer. Working along the same lines as acupuncture only without the scary needles, it’s sure to relieve any stress as well as giving your chi (energy) a much-needed kick up the backside.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Bamboo Massage",
                        Description = "Feeling bamboozled by so many massage options? Maybe it’s time to try a bamboo massage. Known for its healing properties, this rather unusual holistic therapy works to calm and energise you from head to toe. Like the techniques found in a Hot Stone massage, warm bamboo is used to roll and knead the tissue to help alleviate muscle tension and general aches and pains. Talk about no cane, no gain!",
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
                        Name = "Four / Six Hands Massage",
                        Description = "Get double the benefits in half the time with a four or six hands massage. Starring two or three therapists working together in synchronised massage strokes, this is the perfect solution if you’re time-poor but in desperate need of a rub-down. Prepare to think twice…",
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
                        Name = "Lomi Lomi Massage",
                        Description = "Fresh from the tropical shores of Hawaii, Lomi Lomi is a healing process that’s been handed down through generations of Hawaiian families. Similar to a deep tissue massage, therapists of this treatment combine full-body strokes and traditional prayer methods to restore internal balance and harmony. If you’re in need of some serious chill time, Lomi Lomi will give you a friendly nudge in the right direction.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Reflexology",
                        Description = "Pressure… we all feel it, whether it’s from work, our personal lives or otherwise. But allow us to introduce you to a good type of pressure... reflexology. If you haven’t discovered the benefits of reflexology, you’re missing out. It’s a treatment that suits everyone, no matter what your age or health concerns.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Ayurvedic Massage",
                        Description = "Need a massage that’s more than skin-deep? Ayurveda is an ancient form of healing that can soothe, revive and rejuvenate. Treat yourself to an ayurvedic massage and feel the immediate benefits.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Chakra Massage",
                        Description = "Ever wondered why you’ve suddenly come down with a cold, or you’re feeling rundown and moody for no apparent reason? It could be down to an energy imbalance. Enter the chakra massage. Designed to awaken the body’s energy systems, this therapeutic massage restores your body to its natural equilibrium so you can take on whatever the world throws at you.",
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
                        Name = "Indian Head Massage",
                        Description = "Tackle your troubles head on with the magic of Indian tradition. Healing and stimulating in equal measure, an Indian head massage will help ward off migraines and insomnia while offering a one-way ticket to luscious locks.",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Lymphatic Drainage",
                        Description = "A lymphatic drainage massage can be a great way of achieving naturally beautiful skin. “How?” we hear you ask. Science, basically. Our lymphatic system is a vital part of our immune system, made up of all sorts of vessels, including a somewhat miracle fluid called a lymph. Travelling under our skin, this underrated - and quite simply, genius - fluid removes all sorts of bad stuff (think toxins, bacteria and excess water) from our body. A lymphatic drainage massage can help get this lymph flowing, unclogging pores and minimising puffy looking skin along the way. Sounds like a pretty good deal, right?",
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
                        Name = "Chinese Massage",
                        Description = "Tui Na, also known as Chinese massage, is an ancient practice that aims to release the flow of energy around the body. Lots of skilfull techniques are used to bounce you back to good health, including kneading, rolling and deep pressure that’s applied to precise points on your body. Perfect for a midweek treat, it will help relieve stress and soothe injured muscles, leading to a greater sense of well-being. How’s that for a cheeky massage?",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Foot Massage",
                        Description = "Feet, glorious feet! From power walking to work (too much time in bed? Me?) to wearing sky-high stilettos for a night of dancing and drinks, we owe our feet a lot. So why not treat your feet to a revitalising foot massage?",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Herbal Compress Massage",
                        Description = "Treat your senses to the luxury they deserve with this ultimate flower power treatment. Herbal Compress Massage has been practiced for hundreds of years and involves the use of herb infused muslin compresses to stimulate and detoxify the body. If you’re feeling stressed, why not harness the gifts Mother Nature gave us?",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Lava Shells Massage",
                        Description = "Offering all the benefits of a hot stone massage with a tropical kick, a lava shell massage uses naturally self-heating Tiger Clam shells from the sun-kissed shores of the South Pacific to soothe all sorts of aches and pains. It’s time to try the shore way to relax…",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Pregnancy Massage",
                        Description = "Being pregnant is an incredible time… you’re in bloom, your skin is glowing and you can’t wait to meet your little one. But like anyone who has carried a child will tell you, there are a few pesky aches and pains, too. It's not all chic maternity wear and the handy excuse of 'eating for two'. (As much as we wish it was!)",
                        CategoryId = 3,
                    },
                    new Service
                    {
                        Name = "Trigger point therapy",
                        Description = "Whether you’re suffering a chronic sports injury, relentless headaches or are simply fed up with aching muscles, call on trigger point therapy to help track down your problem at its source to release any pent-up pain that’s been hampering your health.",
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
                        Name = "Callus Peel",
                        Description = "If you’ve found yourself avoiding mules and slingback shoes because of the hard skin on the back of your feet, help is at hand. A callus peel is a simple and pain-free way of getting rid of dry skin often found on your feet. Now there’s an excuse to go sandal shopping...",
                        CategoryId = 4,
                    },
                    new Service
                    {
                        Name = "Paraffin Wax Treatments",
                        Description = "Wax, let us count the ways we love thee. As well as being excellent for hair removal and chapped lips, wax is the best way get skin as soft as baby. If you haven’t yet tried a paraffin wax treatment, allow us to enlighten you. This delightful treatment is designed to moisturise and soften your skin while providing therapeutic heat for sore and aching joints. Whether you suffer from arthritis or simply want to revitalise your dry skin, it’s time to wax up...",
                        CategoryId = 4,
                    },
                    new Service
                    {
                        Name = "Nail Art",
                        Description = "Oh nail art, let us count the ways we love thee. If there’s a better (or easier!) way to enliven your everyday look, we’re yet to find it. Whether you want a vibrant print in summer, or sophisticated monochrome come winter, we have got you covered.",
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
                        Name = "Eyebrow & Eyelash Tinting",
                        Description = "Eyebrow and eyelash tinting is the perfect way to look made up with minimum effort. Your eyebrows and eyelashes will look defined without a slick of makeup. If you're after a more dramatic look you can choose a contrasting shade or you can always top up your look with mascara. The eyes have it...",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Eyebrow Waxing",
                        Description = "Eyebrow waxing is a quick, gentle and long lasting way to define the shape of your brows. Most beauty salons offer eyebrow waxing on pre-booked appointments or by brow bars on a ‘walk-in’ basis so having on point eyebrows has never been easier!",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Definition Brows",
                        Description = "There’s no brow too big or too small for Definition Brows, a combination cosmetic treatment that skilfully blends brow shaping with makeup application for seriously sleek brows.",
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
                        Name = "Facials - CACI",
                        Description = "Admired for face-lifting feats, a CACI (Computer Aided Cosmetology Instrument) facial is your answer to cosmetic-surgery results – without the surgery. Using the power of electric waveforms, this is a surefire way to tighten and tone the muscles while smoothing away fine lines and wrinkles.",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Facials - Rejuvenation Acupuncture",
                        Description = "Don’t let bags and sags get the better of you. If your features are starting to fall, facial rejuvenation acupuncture will pinpoint the culprits and pull them back into check. Based on the traditional Chinese therapy, this non-surgical treatment will firm up skin and fill out wrinkles without a scalpel in sight. Even just a short spell of pricks can have you looking years younger in seconds.",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Lash Lift",
                        Description = "Lift, volume and length – the holy trinity of show-stopping eyes. One 45-minute treatment promises to deliver all three, without the need for extensions or falsies. Intrigued? We don’t blame you! If you’ve always desired Bambi-like lengths, but the maintenance isn’t your thing and you’re fed up with grappling with an eyelash curler every morning, it’s time to look into Lash Lifts.",
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
                        Name = "Oxygen Facials",
                        Description = "Perfect if you want glowing skin in time for party season, the oxygen facial has a huge following and is the beauty treatment celebs live by. Using a fancy piece of machinery, a stream of oxygen and high-tech products including hyaluronic acid (quite literally the holy grail of skincare ingredients) is pushed into the skin. The results are instant and will leave you noticeably plumper skin. Sweet!",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Eyelash Perming",
                        Description = "If you dream of beautifully curled lashes all long and doll-like, then this beauty secret is about to get you (very) excited. It might seem a little mad, but rather than leaving you looking like a bad ‘80s throwback, eyelash perming promises weeks of curly lashes without the help of gloopy mascara or fiddly fake lashes.",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Facials - Foto RF Skin Rejuvenation",
                        Description = "Dreaming of a clearer complexion? Foto Facial RF is a high-tech skin enhancement from Syneron Medical that combines gentle pulses of light with radiofrequency (RF) energies to improve all sorts of skincare issues. It’s a non-surgical treatment (hello, no downtime!) that penetrates the skin without overheating the surrounding tissues.",
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
                        Name = "LED Light Therapy",
                        Description = "Your skin deserves to be in the spotlight, so why not bask in the therapeutic glow of LED Light Therapy? All sorts of skin woes can be minimised with this state-of-the-art treatment, whether that be troublesome acne, saggy wrinkles or old battle scars. It’s completely non-invasive and a totally painless procedure that can help leave skin soft and smooth. Now that’s what we call a lightbulb moment.",
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
                        Name = "Face Peel",
                        Description = "If you’re serious about banishing scars, wrinkles and blemishes, a chemical peel is at the ‘extreme-but-effective’ end of the treatment scale. Here, the skin blisters and peels off to reveal shiny, brand-spanking-new skin. More is more, after all!",
                        CategoryId = 5,
                    },
                    new Service
                    {
                        Name = "Facials - Micro Needling",
                        Description = "Ever wish you could roll back time? You’re in luck thanks to micro-needling, the new A-list adored treatment which pierces your skin for a fresher and younger appearance. Take our word, it’s nowhere near as painful as it sounds and the benefits are plentiful! Prepare to wave goodbye to wrinkles and scarring!",
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
                        Name = "Colonic Hydrotherapy",
                        Description = "Combined with a healthy lifestyle, colonic hydrotherapy helps your body eliminate toxins. Sure, the colonic irrigation subject is still a bit taboo but once you’ve got over the apprehension you’ll soon realise that it is totally worth it: you will leave feeling light as a feather and your skin will be glowing!",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Body Wraps",
                        Description = "Detoxifying and skin-smoothing, a body wrap is a treatment that cocoons your whole body in a mixture of herbs, essential oils and nutrient-rich mud. Expect to be swaddled from the neck to feet in warm cloths, foil or a linen blanket.",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Cryolipolysis",
                        Description = "If you have stubborn fat you can’t seem to shift but don’t want to go down the surgery route, cryolipolysis might be just what you’re looking for. A non-invasive alternative to liposuction, cryolipolysis is a treatment that involves the localised application of a low temperature device to kill off stubborn fat cells.",
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
                        Name = "Acupuncture",
                        Description = "Acupuncture is a form of Chinese medicine that involves using tiny needles to stimulate the sensory nerves under the skin (not nearly as scary as it sounds, promise!) to relieve pain. Perfect if you fancy some TLC and you aren’t afraid to try something a bit different, acupuncture is a real all-rounder, used to treat anything from aching muscles to everyday stress. Umm, where do we sign up?",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "CACI Body Treatments",
                        Description = "Want to tone up without the hassle? CACI body treatment is designed to firm up sagging skin using microcurrent technology. Perfect if you want to tackle cellulite, fluid retention and all-round fatty bits, CACI works by stimulating the muscles under the skin, offering the same fat-busting results as a full body workout. No pain, no gain? As if...",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Cupping",
                        Description = "It might have hit the mainstream at the 2016 Olympics (thanks, Michael Phelps) but cupping’s been a firm favourite treatment to ease muscle tension and help invigorate across the globe for donkey’s year. Sure, the post-treatment marks are a little weird, but the de-stressing benefits are well worth it…",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Floatation",
                        Description = "Feel like a quiet moment to yourself is few and far between? Floatation therapy is perhaps the dreamiest way to reconnect with mind, body and soul. Developed in the 1950s, this rather unique (yet totally satisfying) treatment lets you float on warm, salt-infused water in a seriously chilled out and deeply relaxing environment.",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Hyperhidrosis Treatment",
                        Description = "We all know what it’s like to find ourselves dripping on a hot day or after a tough workout – but for some, perspiration is a permanent problem. If you find that excessive sweating, or hyperhidrosis, makes you embarrassed to go to work or socialise with friends, don’t worry – help is at hand.",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Photorejuvenation Treatments",
                        Description = "Let’s face it, stress, sun and a lack of sleep all takes its toll on our skin over time. Luckily, we have just the treatment to combat your skin concerns: photorejuvenation. This powerful use of lasers can treat and improve numerous skin conditions: wrinkles, acne scarring, sun damage... you name it, there’s a photorejuvenation treatment for it. Why not give it a try?",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Sclerotherapy",
                        Description = "Do you freeze up at the thought of swimwear thanks to varicose and spider veins? It may be time to size up sclerotherapy, which vanishes away these veins by using a small injection filled with a special salt solution. The result? A flawless appearance you’ve been dreaming of.",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Universal Contour Wrap",
                        Description = "Developed by Dr. Richard Strem after extensive research, a Universal Contour Wrap uses bandages soaked in a mineral-rich clay solution. The goal? To lose weight, of course! Cleverly, the bandages compress your skin which, in turn, will cause your soft body tissues to compact, leaving you lighter and tighter. Mummy mia...",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Back Facials",
                        Description = "Back facials can be super effective in cleansing those pesky problem areas, helping to reduce the appearance of back acne, clogged pores and dehydrated skin. Similar to a regular facial, techniques include cleansing, steam, exfoliation, extractions, mask and massage, all of which can clear impurities and aid the renewal of healthy collagen. Isn’t it time you gave your back the attention it deserves?",
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
                        Name = "Ear Piercing",
                        Description = "Ear piercings are the perfect way to switch up your look and reawaken your rebellious streak without committing to ink. Before you (or your gutsy mate) step up to the needle, though, it’s good to find out what to expect.",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Henna Designs and Tattoos",
                        Description = "People get skin art for different reasons. A form of self-expression? Check. A window into their personality? Check. They look effortlessly cool? Check. Check. Check. Whether you’re getting tatted up for the first time or are an experienced henna junkie, this simple guide to temporary henna designs will make you a serious pro.",
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
                        Name = "Radio Frequency Body Treatment",
                        Description = "Radio killed the cellulite, fast. Multi-polar Radio Frequency Technology (or Multi-polar RF to save your breath) is a non-surgical skin rejuvenation treatment that blasts away stretch marks, cellulite and other deeply rooted skin issues without the need for anaesthetic. How? Read on…",
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
                        Name = "Body Hair Bleaching",
                        Description = "We all know the drill: hair removal is genius, but the painful process and ugly aftermath is far from ideal. If you’re fed up with shaving rashes or ingrown hairs, body bleaching may be your best bet. By lightening the hair, any unwanted fuzz can be hidden with next-to-no discomfort. Sold? We thought as much...",
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
                        Name = "Rasul and Mud Treatments",
                        Description = "Ok, so the idea of mud may not instantly scream relaxation, but hear us out. Rasul and mineral-rich mud treatments can improve your circulation, soothe aching muscles and leave you with incredibly soft and conditioned skin. It’s also a fun way to unwind either alone or with a friend. Just imagine the selfies...",
                        CategoryId = 6,
                    },
                    new Service
                    {
                        Name = "Ultrasound Therapy",
                        Description = "If you thought ultrasound was just for snapshots of your insides and grainy photos of babies-to-be, think again! Ultrasound therapy is, in fact, an innovative treatment that uses an ingenious ultrasound machine to lessen scars, stretch marks and cellulite, rejuvenate complexions, improve skin elasticity and even reduce pain and stiffness. Phew! Try it for yourself with BeautyBooking.",
                        CategoryId = 6,
                    },
                };

            await dbContext.AddRangeAsync(services);
        }
    }
}
