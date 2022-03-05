using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dsi.StoreManagement.Migrations
{
    public partial class create_Store_DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dsi_Store_Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DisplayFr = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    DisplayAr = table.Column<string>(type: "text", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dsi_Store_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dsi_Store_Colors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DisplayFr = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    DisplayAr = table.Column<string>(type: "text", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dsi_Store_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dsi_Store_Documents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DisplayFr = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    DisplayAr = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DocumentReference = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    DocumentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DocumentType = table.Column<byte>(type: "smallint", nullable: false),
                    OperationType = table.Column<byte>(type: "smallint", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dsi_Store_Documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dsi_Store_Marques",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DisplayFr = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    DisplayAr = table.Column<string>(type: "text", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dsi_Store_Marques", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dsi_Store_Models",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DisplayFr = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    DisplayAr = table.Column<string>(type: "text", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dsi_Store_Models", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dsi_Store_Units",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DisplayFr = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    DisplayAr = table.Column<string>(type: "text", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dsi_Store_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dsi_Store_Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DisplayFr = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    DisplayAr = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<byte>(type: "smallint", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ProductConsummation = table.Column<byte>(type: "smallint", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    ModelId = table.Column<Guid>(type: "uuid", nullable: false),
                    MarqueId = table.Column<Guid>(type: "uuid", nullable: false),
                    UnitId = table.Column<Guid>(type: "uuid", nullable: false),
                    ColorId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dsi_Store_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dsi_Store_Products_Dsi_Store_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Dsi_Store_Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dsi_Store_Products_Dsi_Store_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Dsi_Store_Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dsi_Store_Products_Dsi_Store_Marques_MarqueId",
                        column: x => x.MarqueId,
                        principalTable: "Dsi_Store_Marques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dsi_Store_Products_Dsi_Store_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Dsi_Store_Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dsi_Store_Products_Dsi_Store_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Dsi_Store_Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dsi_Store_Operations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", maxLength: 128, nullable: false),
                    DocumentId = table.Column<Guid>(type: "uuid", maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uuid", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dsi_Store_Operations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dsi_Store_Operations_Dsi_Store_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Dsi_Store_Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dsi_Store_Operations_Dsi_Store_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Dsi_Store_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dsi_Store_Categories_DisplayFr",
                table: "Dsi_Store_Categories",
                column: "DisplayFr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dsi_Store_Colors_DisplayFr",
                table: "Dsi_Store_Colors",
                column: "DisplayFr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dsi_Store_Marques_DisplayFr",
                table: "Dsi_Store_Marques",
                column: "DisplayFr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dsi_Store_Models_DisplayFr",
                table: "Dsi_Store_Models",
                column: "DisplayFr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dsi_Store_Operations_DocumentId",
                table: "Dsi_Store_Operations",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Dsi_Store_Operations_ProductId",
                table: "Dsi_Store_Operations",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Dsi_Store_Products_CategoryId",
                table: "Dsi_Store_Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Dsi_Store_Products_ColorId",
                table: "Dsi_Store_Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Dsi_Store_Products_DisplayFr",
                table: "Dsi_Store_Products",
                column: "DisplayFr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dsi_Store_Products_MarqueId",
                table: "Dsi_Store_Products",
                column: "MarqueId");

            migrationBuilder.CreateIndex(
                name: "IX_Dsi_Store_Products_ModelId",
                table: "Dsi_Store_Products",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Dsi_Store_Products_UnitId",
                table: "Dsi_Store_Products",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Dsi_Store_Units_DisplayFr",
                table: "Dsi_Store_Units",
                column: "DisplayFr",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dsi_Store_Operations");

            migrationBuilder.DropTable(
                name: "Dsi_Store_Documents");

            migrationBuilder.DropTable(
                name: "Dsi_Store_Products");

            migrationBuilder.DropTable(
                name: "Dsi_Store_Categories");

            migrationBuilder.DropTable(
                name: "Dsi_Store_Colors");

            migrationBuilder.DropTable(
                name: "Dsi_Store_Marques");

            migrationBuilder.DropTable(
                name: "Dsi_Store_Models");

            migrationBuilder.DropTable(
                name: "Dsi_Store_Units");
        }
    }
}
