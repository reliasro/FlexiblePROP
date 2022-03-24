//#if !SQLiteVersion  // This seems to work for both SQLite and SQL Server. No GUID need for ConcurrencyToken
#region snippet
using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContosoUniversity.Data
{
    public static class FlexibleDBInitializer
    {
        public static void Initialize(FlexiblePROPContext context)
        {
            // Look for any customers.
            if (context.Clientes.Any())
            {
                return;   // DB has been seeded
            }

           context.SaveChanges();
        }
    }
}
#endregion
//#endif