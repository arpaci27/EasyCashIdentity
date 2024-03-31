using EasyCashIdentity.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentity.DataAccessLayer.Concrete
{
	public class Context : IdentityDbContext<AppUser, AppRole, int>
	{
		public DbSet<CustomerAccount> CustomerAccounts { get; set; }
		public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=ARPACI;initial catalog=EasyCashLast; integrated Security=true");
		}
	}
}
