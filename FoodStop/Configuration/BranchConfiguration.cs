using FoodStop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStop.Configuration
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasData(
                new Branch {
                    Id=5,
                    Name="A2B Restraurant",
                    Location="covai",
                    PhoneNo = 1234567890
                },
                new Branch
                {
                    Id = 6,
                    Name = "Covai Koli Restraurant",
                    Location = "covai",
                    PhoneNo = 1234567890
                },
                new Branch
                {
                    Id = 7,
                    Name = "Gowtham Restraurant",
                    Location = "SAP",
                    PhoneNo = 1234567890
                }
            );
        }
    }
}
