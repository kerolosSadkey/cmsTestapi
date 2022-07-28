
using SreamsCMSLF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace SreamsCMSLF.Data
{
    public class dataSeeder : DropCreateDatabaseIfModelChanges<CmsDbContext>
    {
        protected override void Seed(CmsDbContext context)
        {

            context.Organizations.AddRange(new List<Organization>() {
                new Organization()
                {

                    Id = 1,
                    Name = "Information Technology",
                    Description = "des1",
                    email = "qmail@gmail.com",
                    phone = "012563655555",
                    Address = "adress1",
                    landline = " landline",
                    fax = "fax1",

                    logo = "c/path"
                },
                new Organization()
                {

                    Id = 2,
                    Name = "Information system",
                    Description = "des1",
                    email = "qmail@gmail.com",
                    phone = "012563655555",
                    Address = "adress1",
                    landline = " landline",
                    fax = "fax1",
                    logo = "c/path",
                    PerantId=1

                },
                new Organization()
                {

                    Id = 3,
                    Name = "Cs",
                    Description = "des1",
                    email = "qmail@gmail.com",
                    phone = "012563655555",
                    Address = "adress1",
                    landline = " landline",
                    fax = "fax1",
                    logo = "c/path",
                    PerantId=2


                }
            });



            context.Privileges.AddRange(new List<Privilege>(){
               new Privilege()
               {
                   Id = 1,
                   Name = "Rights",
                   created_at = DateTime.Now,
                   Parent_id = 0
               },
          new Privilege()
          {
              Id = 2,
              Name = "View",
              created_at = DateTime.Now,
              Parent_id = 1
          }
          , new Privilege()
          {
              Id = 3,
              Name = "Add",
              created_at = DateTime.Now,
              Parent_id = 1
          }
          , new Privilege()
          {
              Id = 4,
              Name = "Modify",
              created_at = DateTime.Now,
              Parent_id = 1
          }

          , new Privilege()
          {
              Id = 5,
              Name = "Delete",
              created_at = DateTime.Now,
              Parent_id = 1
          }
          , new Privilege()
          {
              Id = 6,
              Name = "Manage Security",
              created_at = DateTime.Now,
              Parent_id = 1
          }
          , new Privilege()
          {
              Id = 7,
              Name = "Browse",
              created_at = DateTime.Now,
              Parent_id = 2
          }
          , new Privilege()
          {
              Id = 8,
              Name = "Read",
              created_at = DateTime.Now,
              Parent_id = 2
          }
          , new Privilege()
          {
              Id = 9,
              Name = "See Annotation",
              created_at = DateTime.Now,
              Parent_id = 2
          }
          , new Privilege()
          {
              Id = 10,
              Name = "Create Document",
              created_at = DateTime.Now,
              Parent_id = 3
          }
          , new Privilege()
          {
              Id = 11,
              Name = "Create Folder",
              created_at = DateTime.Now,
              Parent_id = 3
          }
          , new Privilege()
          {
              Id = 12,
              Name = "Append Data",
              created_at = DateTime.Now,
              Parent_id = 3
          }

          , new Privilege()
          {
              Id = 13,
              Name = "Modify Content",
              created_at = DateTime.Now,
              Parent_id = 4
          }
          , new Privilege()
          {
              Id = 14,
              Name = "Rename",
              created_at = DateTime.Now,
              Parent_id = 4
          }
          , new Privilege()
          {
              Id = 15,
              Name = "Annotate",
              created_at = DateTime.Now,
              Parent_id = 4
          }
          , new Privilege()
          {
              Id = 16,
              Name = "Write Metadata",
              created_at = DateTime.Now,
              Parent_id = 4
          }
          , new Privilege()
          {
              Id = 17,
              Name = "Delete Entry",
              created_at = DateTime.Now,
              Parent_id = 5
          }
          , new Privilege()
          {
              Id = 18,
              Name = "Delete Document Pages",
              created_at = DateTime.Now,
              Parent_id = 5
          }
            });


            context.Groups.AddRange(new List<Group>(){
               new Group()
            {
                Id = 1,
                Name = "Normal User",
                Created_at = DateTime.Now,
            }
           , new Group()
           {
               Id = 2,
               Name = "Advanced User",
               Created_at = DateTime.Now,
           }
           , new Group()
           {
               Id = 3,
               Name = "Administrator",
               Created_at = DateTime.Now,
           }
           });



            context.GroupPrivilges.AddRange(new List<GroupPrivilge>(){


              new GroupPrivilge()
            {
                Id = 1,
                group_id = 1,
                Privilege_id = 8,
            }
           ,new GroupPrivilge()
            {
                Id = 2,
                group_id = 1,
                Privilege_id = 9,
            }
           ,new GroupPrivilge()
            {
                Id = 3,
                group_id = 2,
                Privilege_id = 10,
            }
           ,new GroupPrivilge()
            {
                Id = 4,
                group_id = 2,
                Privilege_id = 11,
            }
           ,new GroupPrivilge()
            {
                Id = 5,
                group_id = 3,
                Privilege_id = 12,
            }
           ,new GroupPrivilge()
            {
                Id = 6,
                group_id = 3,
                Privilege_id = 14,
            }
        });


            context.Users.AddRange(new List<User>() {


                 new User()
            {
                Id = 1,
                First_name = "Isaac",
                Middle_name = "Nady",
                Last_name = "Bebawy",
                Address = "Shoubra Misr",
                Created_at = DateTime.Now,
                Email = "isaac.bebawy@streams.com.eg",
                Organization_id = 1,
                Group_id = 1,
                Is_laserfiche_user = false,
                Phone_number = "01280722444",
                Title = "Sr.Software Dev",
                User_name = "IsaacBe",
                Password = "Password"

            }
           ,new User()
            {
                Id = 2,
                First_name = "Mary",
                Middle_name = "Ayad",
                Last_name = "Ayad",
                Address = "Giza",
                Created_at = DateTime.Now,
                Email = "mary.ayad@streams.com.eg",
                Organization_id = 2,
                Group_id = 2,
                Is_laserfiche_user = false,
                Phone_number = "123",
                Title = "Software Dev",
                User_name = "mary",
                Password = "Password"

            }
           ,new User()
            {
                Id = 3,
                First_name = "Ahmed",
                Middle_name = "Sabry",
                Last_name = "Sabry",
                Address = "Giza",
                Created_at = DateTime.Now,
                Email = "Ahmed.sabry@streams.com.eg",
                Organization_id = 2,
                Group_id = 2,
                Is_laserfiche_user = false,
                Phone_number = "123",
                Title = "Software Dev",
                User_name = "ahmed",
                Password = "Password"

            }
        });


            base.Seed(context);
        }
        
    }
}