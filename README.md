# BeautyBooking

A beauty bookings web application for hair, nails, spa etc. appointments.  :calendar: :nail_care:

:dart:  My project for the ASP.NET Core course at SoftUni. (April 2020) 

## :information_source: How It Works

- Guest visitors: 
  - browse categories of beauty services;
  - view salons with their services;
  - read blog posts.
- Logged Users:
  - book appointments using interactive datepicker; 
  - can cancel appointments; 
  - can rate salons for which they had confirmed past appointments.  
- Salon Manager (user role):
  - confirms/declines users' appointments for particular salon; 
  - controls what services are available for booking in the salon.
- Admin:
  - creates/deletes blog posts, categories, salons and services; 
  - can review the appointments history.

## :hammer_and_pick: Built With

- ASP.NET Core 3.1
- Entity Framework (EF) Core 3.1
- Microsoft SQL Server Express
- ASP.NET Identity System
- MVC Areas with Multiple Layouts
- Razor Pages, Sections, Partial Views
- View Components
- Repository Pattern
- Auto Мapping
- Dependency Injection
- Status Code Pages Middleware
- Exception Handling Middleware
- Sorting, Filtering, and Paging with EF Core
- Data Validation, both Client-side and Server-side
- Data Validation in the Models and Input View Models
- Custom Validation Attributes
- Responsive Design
- CloudinaryDotNet
- Bootstrap
- jQuery

## :gear: Application Configurations

### 1. The Connection string 
is in `appsettings.json`. If you don't use SQLEXPRESS, you should replace `Server=.\\SQLEXPRESS;` with `Server=.;`

### 2. Database Migrations 
would be applied when you run the application, since the `ASPNETCORE-ENVIRONMENT` is set to `Development`. If you change it, you should apply the migrations yourself.

### 3. Seeding sample data
would happen once you run the application, including Test Accounts:
  - User: user@user.com / password: 123456
  - Salon Manager: manager@manager.com / password: 123456
  - Admin: admin@admin.com / password: 123456
 
### 4. Cloudinary Setup - optionally
#### Running without it:
You won't get an error for missing Cloudinary Credentials - it is handled by using predefined (already uploaded) image, when Cloudinary configuration is missing. So when you are creating content in admin panel, it will be added but not with the image you have chosen.
#### If you want to actually upload images, you should:
1. Add Cloudinary Credentials in `appsettings.json` in the format:
```json
  "Cloudinary": {
    "CloudName": "",
    "ApiKey": "",
    "ApiSecret": "",
    "EnvironmentVariable": ""
  }
```
2. Update the Cloudinary Setup part of `Startup.cs`'s `ConfigureServices` method as follows:
```csharp
            // Cloudinary Setup
            Cloudinary cloudinary = new Cloudinary(new Account(
                this.configuration["Cloudinary:CloudName"],
                this.configuration["Cloudinary:ApiKey"],
                this.configuration["Cloudinary:ApiSecret"]));
            services.AddSingleton(cloudinary);
```

## :framed_picture: Screenshot - Home Page

![BeautyBooking-HomePage](https://res.cloudinary.com/beauty-booking/image/upload/v1588865868/SCREENSHOTS/1-home_orn9ng.png)

## :framed_picture: Screenshot - Make An Appointment Page

![BeautyBooking-MakeAnAppointment](https://res.cloudinary.com/beauty-booking/image/upload/v1588865868/SCREENSHOTS/4-make-an-appointment_zclidt.png)

## License

This project is licensed under the [MIT License](LICENSE).

## Acknowledgments

#### Using [ASP.NET-MVC-Template](https://github.com/NikolayIT/ASP.NET-MVC-Template) developed by:
- [Nikolay Kostov](https://github.com/NikolayIT)
- [Vladislav Karamfilov](https://github.com/vladislav-karamfilov)
- [Stoyan Shopov](https://github.com/StoyanShopov)
