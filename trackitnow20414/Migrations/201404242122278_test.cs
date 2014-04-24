namespace trackitnow20414.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoordenadasModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Latitud = c.String(),
                        Longitud = c.String(),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CoordenadasModels");
        }
    }
}
