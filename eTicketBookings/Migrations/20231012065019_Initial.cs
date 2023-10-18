using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eTicketBookings.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cinema",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cinema", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "producer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "movie",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<double>(type: "float", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    movieCategory = table.Column<int>(type: "int", nullable: false),
                    cinemaId = table.Column<int>(type: "int", nullable: false),
                    producerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movie", x => x.id);
                    table.ForeignKey(
                        name: "FK_movie_cinema_cinemaId",
                        column: x => x.cinemaId,
                        principalTable: "cinema",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movie_producer_producerId",
                        column: x => x.producerId,
                        principalTable: "producer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "actor_movie",
                columns: table => new
                {
                    movieId = table.Column<int>(type: "int", nullable: false),
                    actorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actor_movie", x => new { x.actorId, x.movieId });
                    table.ForeignKey(
                        name: "FK_actor_movie_actor_movieId",
                        column: x => x.movieId,
                        principalTable: "actor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_actor_movie_movie_actorId",
                        column: x => x.actorId,
                        principalTable: "movie",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_actor_movie_movieId",
                table: "actor_movie",
                column: "movieId");

            migrationBuilder.CreateIndex(
                name: "IX_movie_cinemaId",
                table: "movie",
                column: "cinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_movie_producerId",
                table: "movie",
                column: "producerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "actor_movie");

            migrationBuilder.DropTable(
                name: "actor");

            migrationBuilder.DropTable(
                name: "movie");

            migrationBuilder.DropTable(
                name: "cinema");

            migrationBuilder.DropTable(
                name: "producer");
        }
    }
}
