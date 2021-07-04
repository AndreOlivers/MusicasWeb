namespace Musicas.AcessoADados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ALB_ALBUNS",
                c => new
                    {
                        ALB_ID = c.Int(nullable: false, identity: true),
                        ALB_Nome = c.String(nullable: false, maxLength: 100),
                        ALB_ANO = c.Int(nullable: false),
                        ALB_OBSERVACOES = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.ALB_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ALB_ALBUNS");
        }
    }
}
