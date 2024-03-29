﻿namespace DateAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_Message_edit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "isDraft", c => c.Boolean(nullable: false));
            AddColumn("dbo.Messages", "IsRead", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "IsRead");
            DropColumn("dbo.Messages", "isDraft");
        }
    }
}
