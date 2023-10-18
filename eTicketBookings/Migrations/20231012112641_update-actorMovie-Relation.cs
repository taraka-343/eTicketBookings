using Microsoft.EntityFrameworkCore.Migrations;

namespace eTicketBookings.Migrations
{
    public partial class updateactorMovieRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actor_movie_actor_movieId",
                table: "actor_movie");

            migrationBuilder.DropForeignKey(
                name: "FK_actor_movie_movie_actorId",
                table: "actor_movie");

            migrationBuilder.AddForeignKey(
                name: "FK_actor_movie_actor_actorId",
                table: "actor_movie",
                column: "actorId",
                principalTable: "actor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_actor_movie_movie_movieId",
                table: "actor_movie",
                column: "movieId",
                principalTable: "movie",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actor_movie_actor_actorId",
                table: "actor_movie");

            migrationBuilder.DropForeignKey(
                name: "FK_actor_movie_movie_movieId",
                table: "actor_movie");

            migrationBuilder.AddForeignKey(
                name: "FK_actor_movie_actor_movieId",
                table: "actor_movie",
                column: "movieId",
                principalTable: "actor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_actor_movie_movie_actorId",
                table: "actor_movie",
                column: "actorId",
                principalTable: "movie",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
