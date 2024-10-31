namespace project2BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        reservationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        surname = c.String(),
                        email = c.String(),
                        phone = c.String(),
                        peoplecount = c.Int(nullable: false),
                        reservationdate = c.DateTime(nullable: false),
                        time = c.String(),
                        message = c.String(),
                        reservationstatuse = c.String(),
                    })
                .PrimaryKey(t => t.reservationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reservations");
        }
    }
}
