namespace BeautyBooking.Services.Data.Tests.UseInMemoryDatabase
{
    using System;

    using BeautyBooking.Data;
    using BeautyBooking.Data.Common.Repositories;
    using BeautyBooking.Data.Repositories;
    using BeautyBooking.Services.Data.Appointments;
    using BeautyBooking.Services.Data.BlogPosts;
    using BeautyBooking.Services.Data.Categories;
    using BeautyBooking.Services.Data.Cities;
    using BeautyBooking.Services.Data.Salons;
    using BeautyBooking.Services.Data.SalonServicesServices;
    using BeautyBooking.Services.Data.Services;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public abstract class BaseServiceTests : IDisposable
    {
        protected BaseServiceTests()
        {
            var services = this.SetServices();

            this.ServiceProvider = services.BuildServiceProvider();
            this.DbContext = this.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        }

        protected IServiceProvider ServiceProvider { get; set; }

        protected ApplicationDbContext DbContext { get; set; }

        public void Dispose()
        {
            this.DbContext.Database.EnsureDeleted();
            this.SetServices();
        }

        private ServiceCollection SetServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(
                options => options.UseInMemoryDatabase(Guid.NewGuid().ToString()));

            // Data repositories
            services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

            // Application services
            services.AddTransient<IBlogPostsService, BlogPostsService>();
            services.AddTransient<ICategoriesService, CategoriesService>();
            services.AddTransient<IServicesService, ServicesService>();
            services.AddTransient<ICitiesService, CitiesService>();
            services.AddTransient<ISalonsService, SalonsService>();
            services.AddTransient<ISalonServicesService, SalonServicesService>();
            services.AddTransient<IAppointmentsService, AppointmentsService>();

            return services;
        }
    }
}
