namespace CajeroAutomatico.Persistance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Retiro", "idRetiro", "dbo.DispensadorEfectivo");
            DropForeignKey("dbo.Retiro", "idRetiro", "dbo.Pantalla");
            DropForeignKey("dbo.Retiro", "idRetiro", "dbo.Teclado");
            DropForeignKey("dbo.Retiro", "idRetiro", "dbo.BaseDatos");
            DropIndex("dbo.ATM", new[] { "idATM" });
            DropIndex("dbo.Retiro", new[] { "idRetiro" });
            DropIndex("dbo.DispensadorEfectivo", new[] { "idDispensadorefectivo" });
            DropIndex("dbo.Pantalla", new[] { "idPantalla" });
            DropIndex("dbo.Teclado", new[] { "idTeclado" });
            DropIndex("dbo.RanuraDeposito", new[] { "idRanuraDeposito" });
            DropColumn("dbo.ATM", "idBaseDatos");
            DropColumn("dbo.Retiro", "idATM");
            DropColumn("dbo.DispensadorEfectivo", "idATM");
            DropColumn("dbo.Pantalla", "idATM");
            DropColumn("dbo.Teclado", "idATM");
            DropColumn("dbo.RanuraDeposito", "idATM");
            RenameColumn(table: "dbo.ATM", name: "idATM", newName: "idBaseDatos");
            RenameColumn(table: "dbo.Retiro", name: "idRetiro", newName: "idATM");
            RenameColumn(table: "dbo.DispensadorEfectivo", name: "idDispensadorefectivo", newName: "idATM");
            RenameColumn(table: "dbo.Pantalla", name: "idPantalla", newName: "idATM");
            RenameColumn(table: "dbo.Teclado", name: "idTeclado", newName: "idATM");
            RenameColumn(table: "dbo.RanuraDeposito", name: "idRanuraDeposito", newName: "idATM");
            AddColumn("dbo.ATM", "Direccion", c => c.String());
            AddColumn("dbo.ATM", "CodigoATM", c => c.String());
            AddColumn("dbo.Retiro", "DNIPersona", c => c.String());
            AddColumn("dbo.Retiro", "NombrePersona", c => c.String());
            AddColumn("dbo.Retiro", "idCuenta", c => c.Int(nullable: false));
            AddColumn("dbo.Retiro", "BaseDatos_idBaseDatos", c => c.Int());
            AlterColumn("dbo.ATM", "idBaseDatos", c => c.Int(nullable: false));
            AlterColumn("dbo.Retiro", "idATM", c => c.Int(nullable: false));
            AlterColumn("dbo.DispensadorEfectivo", "idATM", c => c.Int(nullable: false));
            AlterColumn("dbo.DispensadorEfectivo", "contador", c => c.Double(nullable: false));
            AlterColumn("dbo.Pantalla", "idATM", c => c.Int(nullable: false));
            AlterColumn("dbo.Teclado", "idATM", c => c.Int(nullable: false));
            AlterColumn("dbo.RanuraDeposito", "idATM", c => c.Int(nullable: false));
            CreateIndex("dbo.ATM", "idBaseDatos");
            CreateIndex("dbo.Retiro", "idATM");
            CreateIndex("dbo.Retiro", "idCuenta");
            CreateIndex("dbo.Retiro", "BaseDatos_idBaseDatos");
            CreateIndex("dbo.DispensadorEfectivo", "idATM");
            CreateIndex("dbo.Pantalla", "idATM");
            CreateIndex("dbo.RanuraDeposito", "idATM");
            CreateIndex("dbo.Teclado", "idATM");
            AddForeignKey("dbo.Retiro", "idCuenta", "dbo.Cuenta", "idCuenta", cascadeDelete: true);
            AddForeignKey("dbo.Retiro", "BaseDatos_idBaseDatos", "dbo.BaseDatos", "idBaseDatos");
            DropColumn("dbo.ATM", "idRanuraDeposito");
            DropColumn("dbo.ATM", "idTeclado");
            DropColumn("dbo.ATM", "idDispensadorEfectivo");
            DropColumn("dbo.ATM", "idPantalla");
            DropColumn("dbo.ATM", "idRetiro");
            DropColumn("dbo.BaseDatos", "idATM");
            DropColumn("dbo.BaseDatos", "idRetiro");
            DropColumn("dbo.Retiro", "idTeclado");
            DropColumn("dbo.Retiro", "idPantalla");
            DropColumn("dbo.Retiro", "idDispensadorEfectivo");
            DropColumn("dbo.Retiro", "idBaseDatos");
            DropColumn("dbo.DispensadorEfectivo", "idRetiro");
            DropColumn("dbo.Pantalla", "idRetiro");
            DropColumn("dbo.Teclado", "idRetiro");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teclado", "idRetiro", c => c.Int(nullable: false));
            AddColumn("dbo.Pantalla", "idRetiro", c => c.Int(nullable: false));
            AddColumn("dbo.DispensadorEfectivo", "idRetiro", c => c.Int(nullable: false));
            AddColumn("dbo.Retiro", "idBaseDatos", c => c.Int(nullable: false));
            AddColumn("dbo.Retiro", "idDispensadorEfectivo", c => c.Int(nullable: false));
            AddColumn("dbo.Retiro", "idPantalla", c => c.Int(nullable: false));
            AddColumn("dbo.Retiro", "idTeclado", c => c.Int(nullable: false));
            AddColumn("dbo.BaseDatos", "idRetiro", c => c.Int(nullable: false));
            AddColumn("dbo.BaseDatos", "idATM", c => c.Int(nullable: false));
            AddColumn("dbo.ATM", "idRetiro", c => c.Int(nullable: false));
            AddColumn("dbo.ATM", "idPantalla", c => c.Int(nullable: false));
            AddColumn("dbo.ATM", "idDispensadorEfectivo", c => c.Int(nullable: false));
            AddColumn("dbo.ATM", "idTeclado", c => c.Int(nullable: false));
            AddColumn("dbo.ATM", "idRanuraDeposito", c => c.Int(nullable: false));
            DropForeignKey("dbo.Retiro", "BaseDatos_idBaseDatos", "dbo.BaseDatos");
            DropForeignKey("dbo.Retiro", "idCuenta", "dbo.Cuenta");
            DropIndex("dbo.Teclado", new[] { "idATM" });
            DropIndex("dbo.RanuraDeposito", new[] { "idATM" });
            DropIndex("dbo.Pantalla", new[] { "idATM" });
            DropIndex("dbo.DispensadorEfectivo", new[] { "idATM" });
            DropIndex("dbo.Retiro", new[] { "BaseDatos_idBaseDatos" });
            DropIndex("dbo.Retiro", new[] { "idCuenta" });
            DropIndex("dbo.Retiro", new[] { "idATM" });
            DropIndex("dbo.ATM", new[] { "idBaseDatos" });
            AlterColumn("dbo.RanuraDeposito", "idATM", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Teclado", "idATM", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Pantalla", "idATM", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.DispensadorEfectivo", "contador", c => c.Int(nullable: false));
            AlterColumn("dbo.DispensadorEfectivo", "idATM", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Retiro", "idATM", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.ATM", "idBaseDatos", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Retiro", "BaseDatos_idBaseDatos");
            DropColumn("dbo.Retiro", "idCuenta");
            DropColumn("dbo.Retiro", "NombrePersona");
            DropColumn("dbo.Retiro", "DNIPersona");
            DropColumn("dbo.ATM", "CodigoATM");
            DropColumn("dbo.ATM", "Direccion");
            RenameColumn(table: "dbo.RanuraDeposito", name: "idATM", newName: "idRanuraDeposito");
            RenameColumn(table: "dbo.Teclado", name: "idATM", newName: "idTeclado");
            RenameColumn(table: "dbo.Pantalla", name: "idATM", newName: "idPantalla");
            RenameColumn(table: "dbo.DispensadorEfectivo", name: "idATM", newName: "idDispensadorefectivo");
            RenameColumn(table: "dbo.Retiro", name: "idATM", newName: "idRetiro");
            RenameColumn(table: "dbo.ATM", name: "idBaseDatos", newName: "idATM");
            AddColumn("dbo.RanuraDeposito", "idATM", c => c.Int(nullable: false));
            AddColumn("dbo.Teclado", "idATM", c => c.Int(nullable: false));
            AddColumn("dbo.Pantalla", "idATM", c => c.Int(nullable: false));
            AddColumn("dbo.DispensadorEfectivo", "idATM", c => c.Int(nullable: false));
            AddColumn("dbo.Retiro", "idATM", c => c.Int(nullable: false));
            AddColumn("dbo.ATM", "idBaseDatos", c => c.Int(nullable: false));
            CreateIndex("dbo.RanuraDeposito", "idRanuraDeposito");
            CreateIndex("dbo.Teclado", "idTeclado");
            CreateIndex("dbo.Pantalla", "idPantalla");
            CreateIndex("dbo.DispensadorEfectivo", "idDispensadorefectivo");
            CreateIndex("dbo.Retiro", "idRetiro");
            CreateIndex("dbo.ATM", "idATM");
            AddForeignKey("dbo.Retiro", "idRetiro", "dbo.BaseDatos", "idBaseDatos");
            AddForeignKey("dbo.Retiro", "idRetiro", "dbo.Teclado", "idTeclado");
            AddForeignKey("dbo.Retiro", "idRetiro", "dbo.Pantalla", "idPantalla");
            AddForeignKey("dbo.Retiro", "idRetiro", "dbo.DispensadorEfectivo", "idDispensadorefectivo");
        }
    }
}
