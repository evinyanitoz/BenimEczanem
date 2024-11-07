namespace BenimEczanem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.il", "SehirAdi", c => c.String());
            DropColumn("dbo.il", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.il", "Name", c => c.String());
            DropColumn("dbo.il", "SehirAdi");
        }
    }
}
