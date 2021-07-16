namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppliedChange : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Category_Id" });
            DropColumn("dbo.Courses", "CategoryID");
            RenameColumn(table: "dbo.Courses", name: "Category_Id", newName: "CategoryId");
            AlterColumn("dbo.Courses", "CategoryId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Courses", "CategoryId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Courses", "CategoryId");
            AddForeignKey("dbo.Courses", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "CategoryId" });
            AlterColumn("dbo.Courses", "CategoryId", c => c.Byte());
            AlterColumn("dbo.Courses", "CategoryId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Courses", name: "CategoryId", newName: "Category_Id");
            AddColumn("dbo.Courses", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "Category_Id");
            AddForeignKey("dbo.Courses", "Category_Id", "dbo.Categories", "Id");
        }
    }
}
