namespace project2BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.messages", "ContetSendDate");
            DropColumn("dbo.messages", "Content");
        }
        
        public override void Down()
        {
            AddColumn("dbo.messages", "Content", c => c.String());
            AddColumn("dbo.messages", "ContetSendDate", c => c.String());
        }
    }
}
