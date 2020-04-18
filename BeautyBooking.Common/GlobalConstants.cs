namespace BeautyBooking.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "BeautyBooking";

        public const string AdministratorRoleName = "Administrator";

        public const string SalonOwnerRoleName = "Owner";

        public static class AccountsSeeding
        {
            public const string Password = "123456";

            public const string AdminEmail = "admin@admin.com";

            public const string OwnerEmail = "owner@owner.com";

            public const string UserEmail = "user@user.com";
        }

        public static class Images
        {
            public const string Index = "https://res.cloudinary.com/beauty-booking/image/upload/v1586874219/index_iyfzwc.jpg";

            public const string CoverBackground = "https://res.cloudinary.com/beauty-booking/image/upload/v1586874218/cover-bg_nnwh6d.jpg";

            public const string Footer = "https://res.cloudinary.com/beauty-booking/image/upload/v1586874219/footer_rvuuls.jpg";

            // Categories
            public const string Hair = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/hair_wufoua.jpg";

            public const string HairRemoval = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/waxing_svksmn.jpg";

            public const string Massage = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/massage_ocfk8z.jpg";

            public const string Nails = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/nails_dyy9ik.jpg";

            public const string Face = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/face_hmgpb4.jpg";

            public const string Body = "https://res.cloudinary.com/beauty-booking/image/upload/v1587149548/Categories/body_dfc8jw.png";
        }

        public static class SeededDataCounts
        {
            public const int Categories = 6;

            public const int BlogPosts = 4;

            public const int Services = 116;
        }
    }
}
