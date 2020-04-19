namespace BeautyBooking.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BeautyBooking.Common;
    using BeautyBooking.Data.Models;

    public class BlogPostsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.BlogPosts.Any())
            {
                return;
            }

            var blogPosts = new BlogPost[]
                {
                    new BlogPost // Id = 1
                    {
                        Title = "Saving Stressed Skin",
                        Content = @"We hear it all the time, stress is the leading factor of disease within the body…and the skin is no different. As our largest organ, it’s paramount we learn how to keep damage in check during anxiety-ridden times, especially if your face is the place that’s showing signs of stress.

Wrinkles

Noticing more fine lines and laxity in your skin? Stress may be impacting you on a hormonal level. Cortisol, the hormone released in response to stress, is the natural enemy of collagen, breaking down the connective tissue that keeps your complexion taut and firm. But beyond damaging collagen, anxiety can also cause us to hold certain facial expressions, such as furrowing the brow which can eventually cause permanent wrinkling on the forehead and around the eyes.

The Solution: Become mindful of when you are holding facial expressions in moments of stress. Breathe in deeply, and as you exhale, visualize your face being relaxed and smooth. Meditation is also helpful, even if you have just a few moments. Download a meditation app onto your mobile device so you have no excuse to take a quick beauty bliss moment. Lack of hydration is typically a wrinkle culprit, so make sure you consume at least 8 glasses of pure water each day to prevent dry skin and to eliminate toxins. For a quick hydration fix, use a serum that contains hyaluronic acid, an ingredient that naturally occurs in your body and holds 1,000 times its weight in water. It even pulls moisture from the air into the skin, instantly hydrating and leaving you with a gorgeous glow.

Under-Eye Bags

Tomorrow’s to-do list can weigh on your mind, keeping you from getting enough beauty sleep. This can cause fluid to pool below your lower eyelid resulting in a puffy mess in the morning. Stomach sleepers, bad news: You can expect the puffiness of your under-eye bags to be even worse due to gravity.

The Solution: Get at least eight hours of sleep. Since the light from your smartphone’s screen simulates sunlight, shut off any electronic devices an hour before you go to sleep. Use your downtime to enjoy a cup of caffeine-free chamomile tea to help calm and relax you before bed. If you still wake up with puffy eyes in the morning, hold the back of a cold spoon (pop it in the fridge) up to your under-eye area and massage it from the inner to the outer corner of your eye to jumpstart the fluid’s drainage. Then, apply concealer in an inverted triangle under your eye. The brightness will start slightly below your nostrils and build toward your eye, concealing the puffiness.

In today’s world, stress seems inevitable, yet, there are simple solutions that can make all the difference in showing a face that appears to have just returned from a relaxing vacation.",
                        Author = "Elizabeth Scarcella",
                        ImageUrl = GlobalConstants.Images.StressedSkin,
                    },
                    new BlogPost // Id = 2
                    {
                        Title = "Summer Beauty Tips",
                        Content = @"Use non-comedogenic products. Non-comedogenic beauty products are designed not to clog pores which can lead to irritation and blemishes. This is important to remember for sunscreens, but may impact you more if you moisturize often and are prone to acne – especially in the summer. Hot and humid weather leads to sweat which takes a longer time to evaporate off your skin. Combining that with oily products isn’t exactly a party for your pores. Go the oil-free or non-comedogenic route to ward off pimples.

Stay moisturized with good clean/organic products. A faithful moisturizing routine can do so many beneficial things for your complexion. Your skin is a barrier that protects you from environmental factors like pollution, bacteria and moisture loss, and keeping it moisturized helps keep that barrier working properly. Dry skin is unhappy, damage-prone skin, so apply a light moisturizer to protect it from summertime drying agents like sunburn, salt and chlorine.

Exfoliate at the right times – and don’t overdo it! Not only will it help you maintain a fresh fake tan (when your dead skin cells flake off, the old tan will come off with it), but gentle facial exfoliation will help keep your skin free of clogged pores and create a better canvas for makeup application. However, keep in mind that exfoliation reveals new, sensitive skin that can be more prone to burning in the sun. Reserve your exfoliating habits for the evening (and not right before a special occasion), or for days when you aren’t heading straight from the shower to the pool.

Aloe can be your new best friend during the summer. It is a known anti-inflammatory that also provides moisturizing relief. Applying products containing aloe vera after sun exposure will calm and soothe your skin, leaving you far less likely to experience that awful scaly dryness that comes with summer. It’s also said to contain antioxidants that can help repair damaged skin and prevent free radicals from doing their undesirable work. Keep an aloe plant in your backyard or even your kitchen and use when needed!

Invest in moisturizers that work on wet skin when best absorbed. Don’t skip the after-bathing rehydration! Many brands now make body washes that provide hydration via their oil ingredients with many that you apply even before you towel off.

Buy quality sunscreens. Look beyond the SPF and buy quality sunscreens with safe ingredients. Reapply every hour or so, and if you take a dip in the water, reapply when you get out. Water attracts the sun (like snow), creating a glare that can cause sunburns.",
                        Author = "Michele McDonough",
                        ImageUrl = GlobalConstants.Images.SummerBeautyTips,
                    },
                    new BlogPost // Id = 3
                    {
                        Title = "How Often Should I Change My Make-Up?",
                        Content = @"To maintain that healthy facial glow, here are some helpful facts about the shelf life for your cosmetic products.

Mascara should be replaced every three months, as its liquid consistency and exposure to air every time it is opened make it more vulnerable to bacteria. Its proximity to your eye area can lead to possible infections. If you end up with conjunctivitis, commonly called “pink eye” or any other eye infections, it’s best to throw your mascara away immediately! Also, be cautious when sharing your mascara with others; it is not recommended.

Liquid eyeliners present the same concerns as mascaras, so they should be replaced every six months. Pencil eyeliners, however, can last up two years. Sharpen your pencil with each use to keep it fresh and easy to use/apply. Regularly cleaning your sharpener with a discarded toothbrush is a good idea, as well.

Most foundations should last up to one year; however, you should throw away liquid foundations if you notice any change in smell, texture or color. If you’re prone to acne, consider replacing your foundation every six months and be sure to wash hands, sponges and brushes much more often.

Because of the liquid consistency of lip-gloss, it will need to be replaced more often than an actual lipstick; every 12 months is recommended. The longevity of concealers depends upon consistency. Liquid concealer should be tossed after one year; however, powder concealer can last up to two years. Non-liquid lipsticks can last up to two years, as well.

If you notice a change in color in your nail polish or even a bad smell, it’s time to throw your polish away. Typically, it should last you up to two years. Some brands have expiration dates on the back of the bottle. When making a purchase, check for expiration dates before your purchase to make sure it’s not old inventory! If your products do not have expiration dates, use a sharpie to note date of purchase as a freshness guide.

Powder, blush, bronzer or eyeshadow can last for two years, with proper care. And don’t forget to clean your brushes often!

Heat destroys the shelf life of your favorite products, so a trick of the trade for desert dwellers is to find a handy little make-up tote and refrigerate your make-up. The bonus of refrigeration is the refreshing coolness during application!",
                        Author = "Michele McDonough",
                        ImageUrl = GlobalConstants.Images.MakeUp,
                    },
                    new BlogPost // Id = 4
                    {
                        Title = "Summer Essentials for Healthy Hair",
                        Content = @"Sun, hot dry air, chlorine and salty water…we sure do torture our hair throughout the summer months. It’s no wonder we complain about split ends, oily scalps and dull, lifeless locks. However, with the help of a few essentials, you have a good shot at keeping your hair healthy all summer long.

Trim Your Tresses. Summer seems like the most hassle-free time to grow your hair as you find yourself in messy buns and braids as opposed to a coifed up-do or a sleek blow-out. Yet, it is essential to cut the split ends before they become worse. Desert heat dries everything out – including the shaft of our hair. As hair grows, it continues to split up the shaft causing more damage and the inevitable need to lop off even more than you initially wanted. Book yourself an appointment now, and dust your ends.

Cover Your Coconut. Your hair is like any other part of your body…it needs protection from damaging UV rays. Also, it is a misconception that our hair will protect our scalp from sun damage. To protect your scalp and keep your hair shielded from becoming burnt (yep, that’s actually a real thing), use coconut oil. Coconut oil is not only an antioxidant keeping the harmful rays at bay; it also has natural SPF as well. You can lather the oil onto damp hair as a deep conditioner, repairing your hair and protecting your dome, all while lounging in the pool. After all, why not multi-task? Get your pool time in and let the sun’s heat work its magic.

Just Say No to Daily Shampooing.  Unless you are washing the coconut out, washing your hair daily is really not recommended. Although seemingly counterintuitive, frequent washing actually increases oil production leading to an even greasier scalp and dry brittle hair – not a good look at all.

Instead go for a dry shampoo which helps to reduce scalp oil without drying out your luscious locks. For the adventurous souls, try this DIY treatment to control oil secretion:

Mix 2-3 tbsp of coconut water with the juice of a lemon. Apply the mixture to your scalp and massage it for 5 minutes before rinsing it with cold water. For best results, do this as a weekly treatment.

Water Thyself.  Like all living things, we need water to exist. It cannot be overstated how imperative it is to drink copious amounts of water, especially during triple-digit mercury readings. The proper amount of water each person needs is different; however, newer research indicates that eight 8-ounce glasses a day are really not enough for proper hydration. A good rule of thumb is to drink enough water to produce nearly colorless urine. Feel good as you get your sip on, knowing water is our #1 defense against lifeless locks.

Regardless of how you tame your mane, the most important factor in achieving healthy summer hair is spending your days thinking happy thoughts, creating a sense of calm and peace within, and inspiring others to do the same.

Cheers to happy, healthy hair!",
                        Author = "Elizabeth Scarcella",
                        ImageUrl = GlobalConstants.Images.SummerHealthyHair,
                    },
                };

            // Need them in particular order
            foreach (var blogPost in blogPosts)
            {
                await dbContext.AddAsync(blogPost);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
