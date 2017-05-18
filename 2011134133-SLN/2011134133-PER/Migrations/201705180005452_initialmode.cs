namespace _2011134133_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialmode : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Retiroes", "atm_atmId", "dbo.ATMs");
            DropForeignKey("dbo.DispensadorEfectivoes", "atm_atmId", "dbo.ATMs");
            DropForeignKey("dbo.Pantallas", "atm_atmId", "dbo.ATMs");
            DropForeignKey("dbo.Tecladoes", "atm_atmId", "dbo.ATMs");
            DropForeignKey("dbo.RanuraDepositoes", "atm_atmId", "dbo.ATMs");
            DropIndex("dbo.ATMs", new[] { "Retiro_retiroId" });
            DropIndex("dbo.ATMs", new[] { "DispensadorEfectivo_dispensadorEfectivoId" });
            DropIndex("dbo.ATMs", new[] { "Pantalla_pantallaId" });
            DropIndex("dbo.ATMs", new[] { "Teclado_tecladoId" });
            DropIndex("dbo.ATMs", new[] { "RanuraDeposito_ranuraDepositoId" });
            DropIndex("dbo.Retiroes", new[] { "atm_atmId" });
            DropIndex("dbo.DispensadorEfectivoes", new[] { "atm_atmId" });
            DropIndex("dbo.Pantallas", new[] { "atm_atmId" });
            DropIndex("dbo.Tecladoes", new[] { "atm_atmId" });
            DropIndex("dbo.RanuraDepositoes", new[] { "atm_atmId" });
            AddColumn("dbo.ATMs", "ranuraDepositoId", c => c.String());
            AddColumn("dbo.ATMs", "tecladoId", c => c.String());
            AddColumn("dbo.ATMs", "dispensadorEfectivoId", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ATMs", "pantallaId", c => c.String());
            AddColumn("dbo.ATMs", "retiroId", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            CreateIndex("dbo.ATMs", "retiro_retiroId");
            CreateIndex("dbo.ATMs", "dispensadorEfectivo_dispensadorEfectivoId");
            CreateIndex("dbo.ATMs", "pantalla_pantallaId");
            CreateIndex("dbo.ATMs", "teclado_tecladoId");
            CreateIndex("dbo.ATMs", "ranuraDeposito_ranuraDepositoId");
            DropColumn("dbo.Retiroes", "AtmiD");
            DropColumn("dbo.Retiroes", "atm_atmId");
            DropColumn("dbo.DispensadorEfectivoes", "atmId");
            DropColumn("dbo.DispensadorEfectivoes", "atm_atmId");
            DropColumn("dbo.Pantallas", "atmId");
            DropColumn("dbo.Pantallas", "atm_atmId");
            DropColumn("dbo.Tecladoes", "atmId");
            DropColumn("dbo.Tecladoes", "atm_atmId");
            DropColumn("dbo.RanuraDepositoes", "atmId");
            DropColumn("dbo.RanuraDepositoes", "atm_atmId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RanuraDepositoes", "atm_atmId", c => c.Int());
            AddColumn("dbo.RanuraDepositoes", "atmId", c => c.Int(nullable: false));
            AddColumn("dbo.Tecladoes", "atm_atmId", c => c.Int());
            AddColumn("dbo.Tecladoes", "atmId", c => c.Int(nullable: false));
            AddColumn("dbo.Pantallas", "atm_atmId", c => c.Int());
            AddColumn("dbo.Pantallas", "atmId", c => c.Int(nullable: false));
            AddColumn("dbo.DispensadorEfectivoes", "atm_atmId", c => c.Int());
            AddColumn("dbo.DispensadorEfectivoes", "atmId", c => c.Int(nullable: false));
            AddColumn("dbo.Retiroes", "atm_atmId", c => c.Int());
            AddColumn("dbo.Retiroes", "AtmiD", c => c.Int(nullable: false));
            DropIndex("dbo.ATMs", new[] { "ranuraDeposito_ranuraDepositoId" });
            DropIndex("dbo.ATMs", new[] { "teclado_tecladoId" });
            DropIndex("dbo.ATMs", new[] { "pantalla_pantallaId" });
            DropIndex("dbo.ATMs", new[] { "dispensadorEfectivo_dispensadorEfectivoId" });
            DropIndex("dbo.ATMs", new[] { "retiro_retiroId" });
            DropColumn("dbo.ATMs", "retiroId");
            DropColumn("dbo.ATMs", "pantallaId");
            DropColumn("dbo.ATMs", "dispensadorEfectivoId");
            DropColumn("dbo.ATMs", "tecladoId");
            DropColumn("dbo.ATMs", "ranuraDepositoId");
            CreateIndex("dbo.RanuraDepositoes", "atm_atmId");
            CreateIndex("dbo.Tecladoes", "atm_atmId");
            CreateIndex("dbo.Pantallas", "atm_atmId");
            CreateIndex("dbo.DispensadorEfectivoes", "atm_atmId");
            CreateIndex("dbo.Retiroes", "atm_atmId");
            CreateIndex("dbo.ATMs", "RanuraDeposito_ranuraDepositoId");
            CreateIndex("dbo.ATMs", "Teclado_tecladoId");
            CreateIndex("dbo.ATMs", "Pantalla_pantallaId");
            CreateIndex("dbo.ATMs", "DispensadorEfectivo_dispensadorEfectivoId");
            CreateIndex("dbo.ATMs", "Retiro_retiroId");
            AddForeignKey("dbo.RanuraDepositoes", "atm_atmId", "dbo.ATMs", "atmId");
            AddForeignKey("dbo.Tecladoes", "atm_atmId", "dbo.ATMs", "atmId");
            AddForeignKey("dbo.Pantallas", "atm_atmId", "dbo.ATMs", "atmId");
            AddForeignKey("dbo.DispensadorEfectivoes", "atm_atmId", "dbo.ATMs", "atmId");
            AddForeignKey("dbo.Retiroes", "atm_atmId", "dbo.ATMs", "atmId");
        }
    }
}
