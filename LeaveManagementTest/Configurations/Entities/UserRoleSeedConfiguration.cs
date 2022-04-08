using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagementTest.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "717b4b26-c103-4deb-ae66-3e80f1c21f49",
                    UserId = "717b4a26-c003-4deb-ae56-3e8021c21d49"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "71714b26-b103-4deb-ae56-3e80f1c11f49",
                    UserId = "715b4a26-c002-1deb-ae46-2e8021c21d49"
                }
            );
        }
    }
}