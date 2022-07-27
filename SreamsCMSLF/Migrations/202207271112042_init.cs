namespace SreamsCMSLF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Confidentialities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DocumentAttachments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        File_name = c.String(),
                        File_type = c.String(),
                        File_size = c.Decimal(nullable: false, precision: 18, scale: 2),
                        document_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Documents", t => t.document_id, cascadeDelete: false)
                .Index(t => t.document_id);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        laserfiche_id = c.Int(nullable: false),
                        laserfiche_path = c.String(),
                        subject = c.String(),
                        Document_date = c.DateTime(nullable: false),
                        Entry_name = c.String(),
                        Email = c.String(),
                        Due_date = c.DateTime(nullable: false),
                        Assignee_to = c.Int(nullable: false),
                        Assignee_to_group = c.Int(nullable: false),
                        Comment = c.String(),
                        priority_id = c.Int(nullable: false),
                        assignee_group_id = c.Int(nullable: false),
                        document_status_id = c.Int(nullable: false),
                        user_added_id = c.Int(nullable: false),
                        confidentiality_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Confidentialities", t => t.confidentiality_id, cascadeDelete: false)
                .ForeignKey("dbo.DocumentStatus", t => t.document_status_id, cascadeDelete: false)
                .ForeignKey("dbo.Groups", t => t.assignee_group_id, cascadeDelete: false)
                .ForeignKey("dbo.Priorities", t => t.priority_id, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.user_added_id, cascadeDelete: false)
                .Index(t => t.priority_id)
                .Index(t => t.assignee_group_id)
                .Index(t => t.document_status_id)
                .Index(t => t.user_added_id)
                .Index(t => t.confidentiality_id);
            
            CreateTable(
                "dbo.DocumentStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status_name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Created_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GroupPrivilges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Privilege_id = c.Int(nullable: false),
                        group_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.group_id, cascadeDelete: false)
                .ForeignKey("dbo.Privileges", t => t.Privilege_id, cascadeDelete: false)
                .Index(t => t.Privilege_id)
                .Index(t => t.group_id);
            
            CreateTable(
                "dbo.Privileges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Parent_id = c.Int(nullable: false),
                        created_at = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        First_name = c.String(),
                        Middle_name = c.String(),
                        Last_name = c.String(),
                        Phone_number = c.String(),
                        Address = c.String(),
                        Date_birth = c.DateTime(nullable: false),
                        Created_at = c.DateTime(nullable: false),
                        Title = c.String(),
                        User_name = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Is_laserfiche_user = c.Boolean(nullable: false),
                        Group_id = c.Int(nullable: false),
                        Organization_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_id, cascadeDelete: false)
                .ForeignKey("dbo.Organizations", t => t.Organization_id, cascadeDelete: false)
                .Index(t => t.Group_id)
                .Index(t => t.Organization_id);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        email = c.String(),
                        Description = c.String(),
                        Address = c.String(nullable: false),
                        phone = c.String(nullable: false),
                        fax = c.String(),
                        landline = c.String(),
                        logo = c.String(),
                        PerantId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.PerantId)
                .Index(t => t.PerantId);
            
            CreateTable(
                "dbo.UserLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login_date = c.DateTime(nullable: false),
                        Logout_date = c.DateTime(nullable: false),
                        Ip_address = c.String(),
                        user_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: false)
                .Index(t => t.user_id);
            
            CreateTable(
                "dbo.Priorities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PriorityName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DocumentTrakings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Change_by = c.Int(nullable: false),
                        Change_date = c.DateTime(nullable: false),
                        Change = c.String(),
                        Comment = c.String(),
                        document_id = c.Int(nullable: false),
                        confidentiality_id = c.Int(nullable: false),
                        Priorities_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Confidentialities", t => t.confidentiality_id, cascadeDelete: false)
                .ForeignKey("dbo.Documents", t => t.document_id, cascadeDelete: false)
                .ForeignKey("dbo.Priorities", t => t.Priorities_Id)
                .Index(t => t.document_id)
                .Index(t => t.confidentiality_id)
                .Index(t => t.Priorities_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DocumentAttachments", "document_id", "dbo.Documents");
            DropForeignKey("dbo.Documents", "user_added_id", "dbo.Users");
            DropForeignKey("dbo.Documents", "priority_id", "dbo.Priorities");
            DropForeignKey("dbo.DocumentTrakings", "Priorities_Id", "dbo.Priorities");
            DropForeignKey("dbo.DocumentTrakings", "document_id", "dbo.Documents");
            DropForeignKey("dbo.DocumentTrakings", "confidentiality_id", "dbo.Confidentialities");
            DropForeignKey("dbo.Documents", "assignee_group_id", "dbo.Groups");
            DropForeignKey("dbo.UserLogs", "user_id", "dbo.Users");
            DropForeignKey("dbo.Users", "Organization_id", "dbo.Organizations");
            DropForeignKey("dbo.Organizations", "PerantId", "dbo.Organizations");
            DropForeignKey("dbo.Users", "Group_id", "dbo.Groups");
            DropForeignKey("dbo.GroupPrivilges", "Privilege_id", "dbo.Privileges");
            DropForeignKey("dbo.GroupPrivilges", "group_id", "dbo.Groups");
            DropForeignKey("dbo.Documents", "document_status_id", "dbo.DocumentStatus");
            DropForeignKey("dbo.Documents", "confidentiality_id", "dbo.Confidentialities");
            DropIndex("dbo.DocumentTrakings", new[] { "Priorities_Id" });
            DropIndex("dbo.DocumentTrakings", new[] { "confidentiality_id" });
            DropIndex("dbo.DocumentTrakings", new[] { "document_id" });
            DropIndex("dbo.UserLogs", new[] { "user_id" });
            DropIndex("dbo.Organizations", new[] { "PerantId" });
            DropIndex("dbo.Users", new[] { "Organization_id" });
            DropIndex("dbo.Users", new[] { "Group_id" });
            DropIndex("dbo.GroupPrivilges", new[] { "group_id" });
            DropIndex("dbo.GroupPrivilges", new[] { "Privilege_id" });
            DropIndex("dbo.Documents", new[] { "confidentiality_id" });
            DropIndex("dbo.Documents", new[] { "user_added_id" });
            DropIndex("dbo.Documents", new[] { "document_status_id" });
            DropIndex("dbo.Documents", new[] { "assignee_group_id" });
            DropIndex("dbo.Documents", new[] { "priority_id" });
            DropIndex("dbo.DocumentAttachments", new[] { "document_id" });
            DropTable("dbo.DocumentTrakings");
            DropTable("dbo.Priorities");
            DropTable("dbo.UserLogs");
            DropTable("dbo.Organizations");
            DropTable("dbo.Users");
            DropTable("dbo.Privileges");
            DropTable("dbo.GroupPrivilges");
            DropTable("dbo.Groups");
            DropTable("dbo.DocumentStatus");
            DropTable("dbo.Documents");
            DropTable("dbo.DocumentAttachments");
            DropTable("dbo.Confidentialities");
        }
    }
}
