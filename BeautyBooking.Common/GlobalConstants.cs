namespace BeautyBooking.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "BeautyBooking";

        public const string AdministratorRoleName = "Administrator";

        public const string SalonManagerRoleName = "Manager";

        public const string CloudName = "beauty-booking";

        public static class AccountsSeeding
        {
            public const string Password = "123456";

            public const string AdminEmail = "admin@admin.com";

            public const string SalonManagerEmail = "manager@manager.com";

            public const string UserEmail = "user@user.com";
        }

        public static class DataValidations
        {
            public const int TitleMaxLength = 60;

            public const int TitleMinLength = 5;

            public const int ContentMaxLength = 3500;

            public const int ContentMinLength = 700;

            public const int NameMaxLength = 40;

            public const int NameMinLength = 2;

            public const int DescriptionMaxLength = 700;

            public const int DescriptionMinLength = 50;

            public const int AddressMaxLength = 100;

            public const int AddressMinLength = 5;
        }

        public static class ErrorMessages
        {
            public const string Title = "Title must be between 5 and 60 characters.";

            public const string Content = "Content must be between 700 and 3500 characters.";

            public const string Author = "Author name must be between 2 and 40 characters.";

            public const string Name = "Name must be between 2 and 40 characters.";

            public const string Description = "Description must be between 50 and 700 characters.";

            public const string Address = "Address must be between 5 and 100 characters.";

            public const string Image = "Please select a JPG, JPEG or PNG image smaller than 1MB.";

            public const string DateTime = "Please select a valid DATE and TIME from the datepicker calendar on the left.";

            public const string Rating = "Please choose a valid number of stars from 1 to 5.";
        }

        public static class DateTimeFormats
        {
            public const string DateFormat = "dd-MM-yyyy";

            public const string TimeFormat = "h:mmtt";

            public const string DateTimeFormat = "dd-MM-yyyy h:mmtt";
        }

        public static class Images
        {
            public const string Index = "https://res.cloudinary.com/beauty-booking/image/upload/v1586874219/index_iyfzwc.jpg";

            public const string CoverBackground = "https://res.cloudinary.com/beauty-booking/image/upload/v1586874218/cover-bg_nnwh6d.jpg";

            public const string Footer = "https://res.cloudinary.com/beauty-booking/image/upload/v1586874219/footer_rvuuls.jpg";

            public const string Error404 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587754604/404_mcjscs.jpg";

            public const string CloudinaryMissing = "https://res.cloudinary.com/beauty-booking/image/upload/v1587708556/cloudinary_veibtu.png";

            // BlogPosts
            public const string SummerHealthyHair = "https://res.cloudinary.com/beauty-booking/image/upload/v1587152733/Blog/Summer_Essentials_for_Healthy_Hair_lztxwm.jpg";

            public const string MakeUp = "https://res.cloudinary.com/beauty-booking/image/upload/v1587152732/Blog/How_Often_Should_I_Change_My_Make-Up_n4a2mt.jpg";

            public const string SummerBeautyTips = "https://res.cloudinary.com/beauty-booking/image/upload/v1587152732/Blog/Summer_Beauty_Tips_ebdgqa.jpg";

            public const string StressedSkin = "https://res.cloudinary.com/beauty-booking/image/upload/v1587152732/Blog/Saving_Stressed_Skin_xdcjam.jpg";

            // Categories
            public const string Hair = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/hair_wufoua.jpg";

            public const string HairRemoval = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/waxing_svksmn.jpg";

            public const string Massage = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/massage_ocfk8z.jpg";

            public const string Nails = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/nails_dyy9ik.jpg";

            public const string Face = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/face_hmgpb4.jpg";

            public const string Body = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/body_dfc8jw.png";

            // Salons
            public const string Hair1 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/hair-1_jrtnzq.jpg";

            public const string Hair2 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/hair-2_x39q2k.jpg";

            public const string Hair3 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/hair-3_tmtty0.jpg";

            public const string HairRemoval1 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/wax-1_tj3yxa.jpg";

            public const string HairRemoval2 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/wax-2_yhaawx.jpg";

            public const string HairRemoval3 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257303/Salons/wax-3_eldlfp.jpg";

            public const string Massage1 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/massage-1_v7pkjb.jpg";

            public const string Massage2 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/massage-2_kycian.jpg";

            public const string Massage3 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/massage-3_uxwss5.jpg";

            public const string Nails1 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/nails-1_twjz2q.jpg";

            public const string Nails2 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/nails-2_chlj7f.jpg";

            public const string Nails3 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257302/Salons/nails-3_ysgryj.jpg";

            public const string Face1 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257301/Salons/face-1_lduuj9.jpg";

            public const string Face2 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257301/Salons/face-2_lblaut.jpg";

            public const string Face3 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257301/Salons/face-3_tckbu3.jpg";

            public const string Body1 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257301/Salons/body-1_prilhb.jpg";

            public const string Body2 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257301/Salons/body-2_pivi9c.jpg";

            public const string Body3 = "https://res.cloudinary.com/beauty-booking/image/upload/v1587257301/Salons/body-3_x95ezf.jpg";
        }

        public static class SeededDataCounts
        {
            public const int BlogPosts = 4;

            public const int Categories = 6;

            public const int Services = 55;

            public const int Cities = 2;

            public const int Salons = 18;

            public const int Appointments = 54;
        }
    }
}
