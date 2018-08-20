using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Cryptography.X509Certificates;
using MVCBLOG.ENTITY.Model_Entity;

namespace MVCBLOG.DAL.Context
{
    public class BcMvcBlogDbContext : DbContext
    {

        #region DBSet
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<File> Image { get; set; }

        #endregion

        #region Ctor
        public BcMvcBlogDbContext()
            : base("name=BcMvcBlogDbConnectionString")
        {

        }
        #endregion

        #region Initialize

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        private class VeritabaniOlusturucu : CreateDatabaseIfNotExists<BcMvcBlogDbContext>
        {
            //Database oluşmadan önceki çalışan kısımdır.
            public override void InitializeDatabase(BcMvcBlogDbContext context)
            {
                base.InitializeDatabase(context);
            }
            //Database oluştuktan sonraki kısımdır.
        }


        #endregion

    }
}

