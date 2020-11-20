using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EverbridgeWCF {
    public class DoorContext : DbContext {
        // Your context has been configured to use a 'DoorContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EverbridgeWCF.DoorContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DoorContext' 
        // connection string in the application configuration file.
        public DoorContext()
            : base("name=DoorContext") {
            
        }
      
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Door> doors { get; set; }
    }

    public class DoorDBInitializer : IDatabaseInitializer<DoorContext> {
        public void InitializeDatabase(DoorContext context) {

            if (context.Database.Exists()) {
                //if (!context.Database.CompatibleWithModel(true)) {
                    context.Database.Delete();
                //}
            }
            context.Database.Create();

            context.doors.AddRange(new List<Door>() {
                new Door(1, "first door",  isOpen:true, isLocked:false),
                new Door(2, "second door",  isOpen:true, isLocked:false),
                new Door(3, "third door", isOpen:true, isLocked:false),
                new Door(4, "fourth door",  isOpen:true, isLocked:false)
            });
            context.SaveChanges();
        }

    }

}