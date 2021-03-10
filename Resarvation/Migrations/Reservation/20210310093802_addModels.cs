using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Resarvation.Migrations.Reservation
{
    public partial class addModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "__efmigrationshistory",
            //    columns: table => new
            //    {
            //        MigrationId = table.Column<string>(type: "varchar(95)", nullable: false, collation: "latin1_swedish_ci")
            //            .Annotation("MySql:CharSet", "latin1"),
            //        ProductVersion = table.Column<string>(type: "varchar(32)", nullable: false, collation: "latin1_swedish_ci")
            //            .Annotation("MySql:CharSet", "latin1")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => x.MigrationId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnetroles",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Name = table.Column<string>(type: "varchar(256)", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        NormalizedName = table.Column<string>(type: "varchar(256)", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnetroles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnetusers",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        UserName = table.Column<string>(type: "varchar(256)", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        NormalizedUserName = table.Column<string>(type: "varchar(256)", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Email = table.Column<string>(type: "varchar(256)", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        NormalizedEmail = table.Column<string>(type: "varchar(256)", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        PasswordHash = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        SecurityStamp = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        PhoneNumber = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        LockoutEnd = table.Column<DateTime>(type: "datetime(6)", maxLength: 6, nullable: true),
            //        LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        AccessFailedCount = table.Column<int>(type: "int(11)", nullable: false),
            //        Discriminator = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
            //        Class = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
            //        ResCount = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnetusers", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Cause = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AccessNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeReservations", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "aspnetroleclaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(11)", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        RoleId = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ClaimType = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ClaimValue = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnetroleclaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "aspnetroles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnetuserclaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int(11)", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        UserId = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ClaimType = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ClaimValue = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_aspnetuserclaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserClaims_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "aspnetusers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnetuserlogins",
            //    columns: table => new
            //    {
            //        LoginProvider = table.Column<string>(type: "varchar(128)", nullable: false, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ProviderKey = table.Column<string>(type: "varchar(128)", nullable: false, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        UserId = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => new { x.LoginProvider, x.ProviderKey })
            //            .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserLogins_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "aspnetusers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnetuserroles",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        RoleId = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => new { x.UserId, x.RoleId })
            //            .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "aspnetroles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "aspnetusers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "aspnetusertokens",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        LoginProvider = table.Column<string>(type: "varchar(128)", nullable: false, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Name = table.Column<string>(type: "varchar(128)", nullable: false, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Value = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb4_general_ci")
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => new { x.UserId, x.LoginProvider, x.Name })
            //            .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserTokens_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "aspnetusers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetRoleClaims_RoleId",
            //    table: "aspnetroleclaims",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "RoleNameIndex",
            //    table: "aspnetroles",
            //    column: "NormalizedName",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserClaims_UserId",
            //    table: "aspnetuserclaims",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserLogins_UserId",
            //    table: "aspnetuserlogins",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserRoles_RoleId",
            //    table: "aspnetuserroles",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "EmailIndex",
            //    table: "aspnetusers",
            //    column: "NormalizedEmail");

            //migrationBuilder.CreateIndex(
            //    name: "UserNameIndex",
            //    table: "aspnetusers",
            //    column: "NormalizedUserName",
            //    unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "__efmigrationshistory");

            //migrationBuilder.DropTable(
            //    name: "aspnetroleclaims");

            //migrationBuilder.DropTable(
            //    name: "aspnetuserclaims");

            //migrationBuilder.DropTable(
            //    name: "aspnetuserlogins");

            //migrationBuilder.DropTable(
            //    name: "aspnetuserroles");

            //migrationBuilder.DropTable(
            //    name: "aspnetusertokens");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "TypeReservations");

            //migrationBuilder.DropTable(
            //    name: "aspnetroles");

            //migrationBuilder.DropTable(
            //    name: "aspnetusers");
        }
    }
}
