namespace BeautyBooking.Web.ViewModels.Administration.Users
{
    using System;
    using System.Collections.Generic;

    using BeautyBooking.Data.Models;
    using BeautyBooking.Services.Mapping;
    using Microsoft.AspNetCore.Identity;

    public class UserViewModel : IMapFrom<ApplicationUser>
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public DateTime CreatedOn { get; set; }

        public int AppointmentsCount { get; set; }
    }
}
