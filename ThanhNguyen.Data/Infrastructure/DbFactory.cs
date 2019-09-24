using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ThanhNguyen.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ThanhNguyenDbContext dbContext;

        public ThanhNguyenDbContext Init()
        {
            return dbContext ?? (dbContext = new ThanhNguyenDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
