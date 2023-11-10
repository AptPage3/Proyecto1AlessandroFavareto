namespace Proyecto1AlessandroFavareto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colaboladors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellidos = c.String(),
                        fechaRegistro = c.DateTime(nullable: false),
                        estado = c.Boolean(nullable: false),
                        cantidadHerramientas = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Herramientas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        descripcion = c.String(),
                        fechaPrestamo = c.DateTime(nullable: false),
                        fechaDevolver = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Herramientas");
            DropTable("dbo.Colaboladors");
        }
    }
}
