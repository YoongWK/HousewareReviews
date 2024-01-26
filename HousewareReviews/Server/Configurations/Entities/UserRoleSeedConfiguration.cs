using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace HousewareReviews.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                    UserId = "1ce40de7-b2a7-4cf4-a8f3-c811191a664d"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                    UserId = "9du2ii40-h7d9-8sj2-j98s-is0dh83jk48s"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                    UserId = "2oh7diw9-0or5-3jf9-8ss6-ks8ya5h297bd"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                    UserId = "5di8sy83-2i9r-f56h-s8d9-s09njsh7dd53"
                }
             );
        }
    }
}
