using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InteriorDetail_Interior_InteriorID",
                table: "InteriorDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_InteriorDetail_Material_MaterialID",
                table: "InteriorDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_QuotationDetail_Interior_InteriorID",
                table: "QuotationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_QuotationDetail_Quotation_QuotationID",
                table: "QuotationDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuotationDetail",
                table: "QuotationDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InteriorDetail",
                table: "InteriorDetail");

            migrationBuilder.RenameTable(
                name: "QuotationDetail",
                newName: "QuotationDetails");

            migrationBuilder.RenameTable(
                name: "InteriorDetail",
                newName: "InteriorDetails");

            migrationBuilder.RenameIndex(
                name: "IX_QuotationDetail_QuotationID",
                table: "QuotationDetails",
                newName: "IX_QuotationDetails_QuotationID");

            migrationBuilder.RenameIndex(
                name: "IX_InteriorDetail_MaterialID",
                table: "InteriorDetails",
                newName: "IX_InteriorDetails_MaterialID");

            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "InteriorDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuotationDetails",
                table: "QuotationDetails",
                columns: new[] { "InteriorID", "QuotationID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_InteriorDetails",
                table: "InteriorDetails",
                columns: new[] { "InteriorID", "MaterialID" });

            migrationBuilder.AddForeignKey(
                name: "FK_InteriorDetails_Interior_InteriorID",
                table: "InteriorDetails",
                column: "InteriorID",
                principalTable: "Interior",
                principalColumn: "InteriorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InteriorDetails_Material_MaterialID",
                table: "InteriorDetails",
                column: "MaterialID",
                principalTable: "Material",
                principalColumn: "MaterialID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuotationDetails_Interior_InteriorID",
                table: "QuotationDetails",
                column: "InteriorID",
                principalTable: "Interior",
                principalColumn: "InteriorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuotationDetails_Quotation_QuotationID",
                table: "QuotationDetails",
                column: "QuotationID",
                principalTable: "Quotation",
                principalColumn: "QuotationID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InteriorDetails_Interior_InteriorID",
                table: "InteriorDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InteriorDetails_Material_MaterialID",
                table: "InteriorDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_QuotationDetails_Interior_InteriorID",
                table: "QuotationDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_QuotationDetails_Quotation_QuotationID",
                table: "QuotationDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuotationDetails",
                table: "QuotationDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InteriorDetails",
                table: "InteriorDetails");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "InteriorDetails");

            migrationBuilder.RenameTable(
                name: "QuotationDetails",
                newName: "QuotationDetail");

            migrationBuilder.RenameTable(
                name: "InteriorDetails",
                newName: "InteriorDetail");

            migrationBuilder.RenameIndex(
                name: "IX_QuotationDetails_QuotationID",
                table: "QuotationDetail",
                newName: "IX_QuotationDetail_QuotationID");

            migrationBuilder.RenameIndex(
                name: "IX_InteriorDetails_MaterialID",
                table: "InteriorDetail",
                newName: "IX_InteriorDetail_MaterialID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuotationDetail",
                table: "QuotationDetail",
                columns: new[] { "InteriorID", "QuotationID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_InteriorDetail",
                table: "InteriorDetail",
                columns: new[] { "InteriorID", "MaterialID" });

            migrationBuilder.AddForeignKey(
                name: "FK_InteriorDetail_Interior_InteriorID",
                table: "InteriorDetail",
                column: "InteriorID",
                principalTable: "Interior",
                principalColumn: "InteriorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InteriorDetail_Material_MaterialID",
                table: "InteriorDetail",
                column: "MaterialID",
                principalTable: "Material",
                principalColumn: "MaterialID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuotationDetail_Interior_InteriorID",
                table: "QuotationDetail",
                column: "InteriorID",
                principalTable: "Interior",
                principalColumn: "InteriorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_QuotationDetail_Quotation_QuotationID",
                table: "QuotationDetail",
                column: "QuotationID",
                principalTable: "Quotation",
                principalColumn: "QuotationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
