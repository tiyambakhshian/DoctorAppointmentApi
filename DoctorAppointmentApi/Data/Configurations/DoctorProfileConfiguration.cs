using DoctorAppointmentApi.Controllers.Data.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class DoctorProfileConfiguration : IEntityTypeConfiguration<DoctorProfile>
{
    public void Configure(EntityTypeBuilder<DoctorProfile> builder)
    {
        builder.HasKey(dp => dp.Id);

        builder.HasMany(dp => dp.WorkingHours)
            .WithOne(wh => wh.DoctorProfile)
            .HasForeignKey(wh => wh.DoctorProfileId);
    }
}
