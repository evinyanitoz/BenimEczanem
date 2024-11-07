namespace BenimEczanem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.il",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ilce",
                c => new
                    {
                        ilceId = c.Int(nullable: false, identity: true),
                        ilId = c.Int(nullable: false),
                        İlceName = c.String(),
                    })
                .PrimaryKey(t => t.ilceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ilce");
            DropTable("dbo.il");
        }
    }
}
