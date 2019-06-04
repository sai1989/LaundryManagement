namespace LaundryManagementUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initdata : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tranasactions", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Tranasactions", "ServicePlanId", "dbo.ServicePlans");
            DropForeignKey("dbo.Tranasactions", "StudentInfoId", "dbo.StudentInfoes");
            DropIndex("dbo.Tranasactions", new[] { "StudentInfoId" });
            DropIndex("dbo.Tranasactions", new[] { "ServicePlanId" });
            DropIndex("dbo.Tranasactions", new[] { "EmployeeId" });
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        StudentInfoId = c.Int(nullable: false),
                        ServicePlanId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.ServicePlans", t => t.ServicePlanId, cascadeDelete: true)
                .ForeignKey("dbo.StudentInfoes", t => t.StudentInfoId, cascadeDelete: true)
                .Index(t => t.StudentInfoId)
                .Index(t => t.ServicePlanId)
                .Index(t => t.EmployeeId);
            
            DropTable("dbo.Tranasactions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Tranasactions",
                c => new
                    {
                        TranasactionId = c.Int(nullable: false, identity: true),
                        StudentInfoId = c.Int(nullable: false),
                        ServicePlanId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TranasactionId);
            
            DropForeignKey("dbo.Transactions", "StudentInfoId", "dbo.StudentInfoes");
            DropForeignKey("dbo.Transactions", "ServicePlanId", "dbo.ServicePlans");
            DropForeignKey("dbo.Transactions", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Transactions", new[] { "EmployeeId" });
            DropIndex("dbo.Transactions", new[] { "ServicePlanId" });
            DropIndex("dbo.Transactions", new[] { "StudentInfoId" });
            DropTable("dbo.Transactions");
            CreateIndex("dbo.Tranasactions", "EmployeeId");
            CreateIndex("dbo.Tranasactions", "ServicePlanId");
            CreateIndex("dbo.Tranasactions", "StudentInfoId");
            AddForeignKey("dbo.Tranasactions", "StudentInfoId", "dbo.StudentInfoes", "StudentInfoId", cascadeDelete: true);
            AddForeignKey("dbo.Tranasactions", "ServicePlanId", "dbo.ServicePlans", "ServicePlanId", cascadeDelete: true);
            AddForeignKey("dbo.Tranasactions", "EmployeeId", "dbo.Employees", "EmployeeId", cascadeDelete: true);
        }
    }
}
