using System.Data.Entity;

namespace BellordPlants.Cloud.MVC.Models
{
    public class BellordPlantsContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        //System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<BellordPlants.Cloud.MVC.Models.BellordPlantsContext>());

        public BellordPlantsContext() : base("name=BellordPlantsContext")
        {
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
      

    }
}
