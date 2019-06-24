namespace CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SkillTableAddColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Skills", "AnimationCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Skills", "AnimationCount");
        }
    }
}
