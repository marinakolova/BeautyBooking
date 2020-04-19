namespace BeautyBooking.Data.Configurations
{
    using BeautyBooking.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> appointment)
        {
            appointment
                .HasOne(a => a.User)
                .WithMany(u => u.Appointments)
                .HasForeignKey(a => a.UserId);

            appointment
                .HasOne(a => a.Salon)
                .WithMany(s => s.Appointments)
                .HasForeignKey(a => a.SalonId);

            appointment
                .HasOne(a => a.Service)
                .WithMany(s => s.Appointments)
                .HasForeignKey(a => a.ServiceId);

            appointment
                .HasOne(a => a.SalonService)
                .WithMany(ss => ss.Appointments)
                .HasForeignKey(a => new { a.SalonId, a.ServiceId });
        }
    }
}
