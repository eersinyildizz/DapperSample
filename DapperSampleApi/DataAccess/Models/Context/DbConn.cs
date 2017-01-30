namespace DapperSampleApi.Models.Context
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DbConn : DbContext
    {
        // Your context has been configured to use a 'DbConn' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DapperSampleApi.Models.Context.DbConn' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DbConn' 
        // connection string in the application configuration file.
        public DbConn()
            : base("name=DbConn")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Student> Sudents{ get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}