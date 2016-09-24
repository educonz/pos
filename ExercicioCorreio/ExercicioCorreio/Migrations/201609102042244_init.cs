namespace ExercicioCorreio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CalcPrecoPrazoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CdEmpresa = c.String(),
                        DsSenha = c.String(),
                        CdServico = c.String(),
                        CepOrigem = c.String(),
                        CepDestino = c.String(),
                        VlPeso = c.String(),
                        CdFormato = c.Int(nullable: false),
                        VlComprimento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VlAltura = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VlLargura = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VlDiametro = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CdMaoPropria = c.String(),
                        VlValorDeclarado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CdAvisoRecebimento = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CalcPrecoPrazoes");
        }
    }
}
