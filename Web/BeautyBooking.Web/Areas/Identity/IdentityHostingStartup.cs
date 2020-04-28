using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(BeautyBooking.Web.Areas.Identity.IdentityHostingStartup))]
namespace BeautyBooking.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}
