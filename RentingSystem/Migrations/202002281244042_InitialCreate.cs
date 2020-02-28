namespace RentingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Rating = c.String(maxLength: 5),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Registractions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        EmailAddress = c.String(nullable: false),
                        City = c.String(nullable: false),
                        Occupation = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        NextofKinLastName = c.String(nullable: false),
                        NextofKinPhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RentingDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RenterFirstName = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        MovieTitle = c.String(nullable: false),
                        NumberofMovies = c.String(),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Duration = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RegistractionMovies",
                c => new
                    {
                        Registraction_Id = c.Int(nullable: false),
                        Movie_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Registraction_Id, t.Movie_ID })
                .ForeignKey("dbo.Registractions", t => t.Registraction_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_ID, cascadeDelete: true)
                .Index(t => t.Registraction_Id)
                .Index(t => t.Movie_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegistractionMovies", "Movie_ID", "dbo.Movies");
            DropForeignKey("dbo.RegistractionMovies", "Registraction_Id", "dbo.Registractions");
            DropIndex("dbo.RegistractionMovies", new[] { "Movie_ID" });
            DropIndex("dbo.RegistractionMovies", new[] { "Registraction_Id" });
            DropTable("dbo.RegistractionMovies");
            DropTable("dbo.RentingDetails");
            DropTable("dbo.Registractions");
            DropTable("dbo.Movies");
        }
    }
}
