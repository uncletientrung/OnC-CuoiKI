using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_2025HK1CLC_Winform
{
    internal class ConnectLinq : DbContext
    {
        public DbSet<OrderItem> OrderItems { get; set; } // tìm bảng dựa trên OrderItem nhưng mà nó tự nhét s
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(
                "server=localhost;database=2024-2025clc;user=root;password=;",
                ServerVersion.AutoDetect(
                    "server=localhost;database=2024-2025clc;user=root;password=;"
                )
            );
        }
    }
}
