using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AukilaniHire.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Member_MemberID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Room_RoomID",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "RoomID",
                table: "Room",
                newName: "RoomId");

            migrationBuilder.RenameColumn(
                name: "MemberID",
                table: "Member",
                newName: "MemberId");

            migrationBuilder.RenameColumn(
                name: "RoomID",
                table: "Booking",
                newName: "RoomId");

            migrationBuilder.RenameColumn(
                name: "MemberID",
                table: "Booking",
                newName: "MemberId");

            migrationBuilder.RenameColumn(
                name: "BookingID",
                table: "Booking",
                newName: "BookingId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_RoomID",
                table: "Booking",
                newName: "IX_Booking_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_MemberID",
                table: "Booking",
                newName: "IX_Booking_MemberId");

            migrationBuilder.AddColumn<TimeOnly>(
                name: "BeginTime",
                table: "Booking",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "EndTime",
                table: "Booking",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Member_MemberId",
                table: "Booking",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "MemberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Room_RoomId",
                table: "Booking",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Member_MemberId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Room_RoomId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "BeginTime",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Room",
                newName: "RoomID");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "Member",
                newName: "MemberID");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Booking",
                newName: "RoomID");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "Booking",
                newName: "MemberID");

            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "Booking",
                newName: "BookingID");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_RoomId",
                table: "Booking",
                newName: "IX_Booking_RoomID");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_MemberId",
                table: "Booking",
                newName: "IX_Booking_MemberID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Member_MemberID",
                table: "Booking",
                column: "MemberID",
                principalTable: "Member",
                principalColumn: "MemberID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Room_RoomID",
                table: "Booking",
                column: "RoomID",
                principalTable: "Room",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
