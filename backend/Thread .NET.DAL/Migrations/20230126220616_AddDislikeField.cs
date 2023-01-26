using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Thread_.NET.DAL.Migrations
{
    public partial class AddDislikeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.AddColumn<bool>(
                name: "IsDislike",
                table: "PostReactions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDislike",
                table: "CommentReactions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsDislike", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 17, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(6859), true, true, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(6904), 16 },
                    { 2, 15, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(6955), false, false, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(6958), 2 },
                    { 3, 8, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(6976), false, true, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(6979), 13 },
                    { 4, 5, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(6995), false, false, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(6998), 21 },
                    { 5, 19, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7019), true, false, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7022), 20 },
                    { 6, 7, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7037), true, true, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7039), 5 },
                    { 7, 8, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7052), false, false, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7055), 10 },
                    { 8, 10, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7073), false, false, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7076), 15 },
                    { 9, 2, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7089), false, false, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7091), 5 },
                    { 10, 16, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7104), false, true, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7106), 5 },
                    { 11, 14, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7121), false, false, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7123), 15 },
                    { 12, 12, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7137), true, false, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7140), 9 },
                    { 13, 12, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7153), true, true, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7156), 12 },
                    { 14, 6, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7169), false, false, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7171), 18 },
                    { 15, 16, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7185), false, false, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7187), 17 },
                    { 16, 16, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7200), false, true, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7202), 11 },
                    { 17, 7, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7216), false, true, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7218), 3 },
                    { 18, 10, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7230), false, false, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7232), 9 },
                    { 19, 6, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7244), true, true, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7246), 17 },
                    { 20, 10, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7258), false, true, new DateTime(2023, 1, 27, 0, 6, 15, 852, DateTimeKind.Local).AddTicks(7261), 14 }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 11, "Quidem placeat voluptas eum tenetur inventore.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4427), 12, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Quo suscipit necessitatibus perspiciatis natus iure sed ex quaerat.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4577), 4, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Ut suscipit neque rerum voluptatem.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4618), 13, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Officia est et assumenda sunt excepturi.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4657), 18, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Magnam recusandae laborum cum.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4692), 13, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Nulla explicabo aperiam asperiores corrupti quis fugiat ut vel eum.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4742), 7, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Est nam quo.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4777), 8, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Voluptatibus omnis id et sequi.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4808), 14, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Nesciunt et eligendi fugiat molestias asperiores quod nihil sed.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4855), 15, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4857) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 5, "Non dolorum vero voluptas sit.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4894), new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 13, "Tempora enim distinctio qui illum et aut accusantium et.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4944), 16, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Atque consequuntur fuga sit atque laborum temporibus nisi.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4986), 17, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Sapiente optio temporibus.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5014), 5, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Itaque reprehenderit aut et.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5046), 4, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 15, "Quibusdam nisi voluptates et in aliquid delectus.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5083), 2, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Dolor molestiae et cum.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5113), 18, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 9, "Quis consequuntur incidunt veritatis expedita assumenda eveniet autem culpa.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5156), 2, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Quis quidem est et magnam exercitationem voluptas enim.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5194), 6, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Cum aperiam corrupti debitis sequi quia veniam.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5232), 10, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Nulla ullam qui doloribus accusamus rem.", new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5267), 7, new DateTime(2023, 1, 27, 0, 6, 15, 849, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9699), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/807.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9806), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/25.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9820), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/677.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9832), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/927.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9843), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/448.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9854), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1043.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9864), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/52.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9875), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/884.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9885), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/956.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9894), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/355.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9903), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/307.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9905) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9913), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/156.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9923), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/763.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 797, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 798, DateTimeKind.Local).AddTicks(15), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/383.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 798, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 798, DateTimeKind.Local).AddTicks(26), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/243.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 798, DateTimeKind.Local).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 798, DateTimeKind.Local).AddTicks(36), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/847.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 798, DateTimeKind.Local).AddTicks(38) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 798, DateTimeKind.Local).AddTicks(46), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/611.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 798, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 798, DateTimeKind.Local).AddTicks(56), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1198.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 798, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 798, DateTimeKind.Local).AddTicks(66), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/713.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 798, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 798, DateTimeKind.Local).AddTicks(76), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/929.jpg", new DateTime(2023, 1, 27, 0, 6, 15, 798, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4657), "https://picsum.photos/640/480/?image=822", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4772), "https://picsum.photos/640/480/?image=850", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4787), "https://picsum.photos/640/480/?image=219", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4800), "https://picsum.photos/640/480/?image=334", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4812), "https://picsum.photos/640/480/?image=211", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4824), "https://picsum.photos/640/480/?image=708", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4835), "https://picsum.photos/640/480/?image=213", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4847), "https://picsum.photos/640/480/?image=40", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4858), "https://picsum.photos/640/480/?image=181", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4869), "https://picsum.photos/640/480/?image=261", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4880), "https://picsum.photos/640/480/?image=886", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4891), "https://picsum.photos/640/480/?image=652", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4902), "https://picsum.photos/640/480/?image=707", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4913), "https://picsum.photos/640/480/?image=944", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4930), "https://picsum.photos/640/480/?image=510", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4941), "https://picsum.photos/640/480/?image=280", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4953), "https://picsum.photos/640/480/?image=740", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4964), "https://picsum.photos/640/480/?image=78", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4975), "https://picsum.photos/640/480/?image=842", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4986), "https://picsum.photos/640/480/?image=430", new DateTime(2023, 1, 27, 0, 6, 15, 800, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsDislike", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9585), true, true, 19, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9654), 5 },
                    { 2, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9745), true, true, 4, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9751), 16 },
                    { 3, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9779), true, false, 10, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9783), 6 },
                    { 4, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9808), false, true, 4, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9812), 18 }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsDislike", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 5, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9836), true, false, 14, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9850), 7 },
                    { 6, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9877), false, false, 8, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9881), 19 },
                    { 7, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9901), true, true, 9, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9904), 9 },
                    { 8, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9918), false, true, 18, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9921), 13 },
                    { 9, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9933), true, false, 11, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9936), 5 },
                    { 10, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9950), true, false, 17, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9953), 4 },
                    { 11, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9965), false, true, 10, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9967), 13 },
                    { 12, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9979), true, false, 14, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9981), 16 },
                    { 13, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9994), false, false, 3, new DateTime(2023, 1, 27, 0, 6, 15, 850, DateTimeKind.Local).AddTicks(9997), 10 },
                    { 14, new DateTime(2023, 1, 27, 0, 6, 15, 851, DateTimeKind.Local).AddTicks(10), true, true, 16, new DateTime(2023, 1, 27, 0, 6, 15, 851, DateTimeKind.Local).AddTicks(12), 12 },
                    { 15, new DateTime(2023, 1, 27, 0, 6, 15, 851, DateTimeKind.Local).AddTicks(25), false, false, 5, new DateTime(2023, 1, 27, 0, 6, 15, 851, DateTimeKind.Local).AddTicks(27), 17 },
                    { 16, new DateTime(2023, 1, 27, 0, 6, 15, 851, DateTimeKind.Local).AddTicks(39), false, false, 8, new DateTime(2023, 1, 27, 0, 6, 15, 851, DateTimeKind.Local).AddTicks(42), 8 },
                    { 17, new DateTime(2023, 1, 27, 0, 6, 15, 851, DateTimeKind.Local).AddTicks(54), false, false, 2, new DateTime(2023, 1, 27, 0, 6, 15, 851, DateTimeKind.Local).AddTicks(57), 2 },
                    { 18, new DateTime(2023, 1, 27, 0, 6, 15, 851, DateTimeKind.Local).AddTicks(68), true, false, 18, new DateTime(2023, 1, 27, 0, 6, 15, 851, DateTimeKind.Local).AddTicks(71), 9 },
                    { 19, new DateTime(2023, 1, 27, 0, 6, 15, 851, DateTimeKind.Local).AddTicks(82), true, false, 9, new DateTime(2023, 1, 27, 0, 6, 15, 851, DateTimeKind.Local).AddTicks(84), 16 },
                    { 20, new DateTime(2023, 1, 27, 0, 6, 15, 851, DateTimeKind.Local).AddTicks(96), false, false, 9, new DateTime(2023, 1, 27, 0, 6, 15, 851, DateTimeKind.Local).AddTicks(99), 10 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 15, "Reprehenderit officia aliquid ex culpa laborum.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(6563), 37, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, "Ex qui illo.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(6761), 38, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "Et ratione dignissimos sint sit quas in quis.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(6866), 28, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "Et delectus nihil temporibus magnam adipisci id aut adipisci. Possimus officiis et at. Eos harum reprehenderit asperiores sed explicabo expedita. Ut sint tempore similique. Similique quasi quia natus et blanditiis. Occaecati expedita quod mollitia assumenda modi dicta veritatis reiciendis corporis.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7278), 39, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 4, "Quisquam mollitia sint et temporibus qui consequatur.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7348), 38, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "nostrum", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7376), 30, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Est inventore facilis sed placeat qui quibusdam. Nostrum et in ratione. Fugit enim non asperiores similique perferendis mollitia quis qui nobis.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7510), 22, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "facere", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7552), 26, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 13, "Odio rem soluta.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7610), 23, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 5, "Rerum dolores veritatis fuga excepturi voluptatem quisquam. Rerum odit enim. Est rem consequatur ut quis modi omnis veritatis numquam libero. Dolor voluptas enim et.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7799), 21, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "Reprehenderit nostrum fuga hic eos aspernatur.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7871), 39, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "est", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7918), 27, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 10, "Dicta et veritatis deleniti cupiditate.\nDoloribus velit alias mollitia sed voluptatibus.\nQui esse dicta sequi earum facere.\nQuisquam architecto enim magni tempore aliquid.\nAlias illum qui autem.\nVoluptatem similique velit et quos voluptatem amet dolore libero.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8067), 29, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "Porro officiis aut quia est ex incidunt aut. Odit dolores officiis id sed consequuntur ut veritatis sint accusantium. Animi soluta commodi earum exercitationem asperiores dolorem reiciendis. Ea maxime et qui quibusdam non harum quibusdam.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8244), 26, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "Officia ut odio voluptate ea porro veniam sed tenetur.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8405), 33, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "Atque possimus voluptatem porro.\nMaxime reiciendis quia ex vero laboriosam aliquam perspiciatis.\nRepellendus dolor cupiditate consequatur accusamus molestiae sed magnam repellat.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8492), 26, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "Qui illum enim autem doloremque quod est error cum sequi.\nEt voluptas occaecati.\nVoluptatem deleniti consequatur est sed iusto quam et.\nLaborum voluptatum consequuntur recusandae odio et.\nArchitecto voluptatem fugit et dolorem.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8688), 36, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8691) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "Quas et ipsa omnis cum aut vel.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8738), 21, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8761), 29, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 14, "Dolor nihil maxime necessitatibus veniam aliquam dolor. Veritatis fugiat et sed qui et. Praesentium dolores modi dolorem. Omnis ab nulla nobis. Molestiae eius quasi molestiae consequuntur provident ut neque provident molestias.", new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8878), 35, new DateTime(2023, 1, 27, 0, 6, 15, 847, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2023, 1, 27, 0, 6, 15, 805, DateTimeKind.Local).AddTicks(936), "Shanna72@yahoo.com", "aOxwsXYVi4g2H7+ATjIcJKASROLNzOkE8NCaTyFyWLQ=", "zoyRnFFrpDe96A1NPKEe8QfqiPsEi316ApYOm09gHYs=", new DateTime(2023, 1, 27, 0, 6, 15, 805, DateTimeKind.Local).AddTicks(1025), "Irma68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2023, 1, 27, 0, 6, 15, 806, DateTimeKind.Local).AddTicks(9195), "Gregory_Hagenes0@hotmail.com", "A0mmzRPYRb/XES4am874yy6YBbMAL1ytQWL3FfgjB5Q=", "gBJPUMUIFmY5RuEHUgoa1wBlUNeWMbjeUZXLH4KAaGI=", new DateTime(2023, 1, 27, 0, 6, 15, 806, DateTimeKind.Local).AddTicks(9222), "Rhiannon_Reinger" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2023, 1, 27, 0, 6, 15, 808, DateTimeKind.Local).AddTicks(7273), "Madaline.Wilderman14@gmail.com", "tjmNliALf4rG03JNv9i/SdZAX1PVmrC9ZskNIpXOJXo=", "ZAQgCm9TYFXiiExDdBOoeo05mG84Nf+PTtZDwEi3MZg=", new DateTime(2023, 1, 27, 0, 6, 15, 808, DateTimeKind.Local).AddTicks(7301), "Sigurd.Weimann" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2023, 1, 27, 0, 6, 15, 810, DateTimeKind.Local).AddTicks(6067), "Skye61@yahoo.com", "CH3IkzaSTaqIyCDq78rjGHikv9yKESw1T6sGpQ23tew=", "cv30VVgoRzpvIr9Z+UuxuUrvWMfl2PZJpSaXz3pijQ4=", new DateTime(2023, 1, 27, 0, 6, 15, 810, DateTimeKind.Local).AddTicks(6113), "Lenny_Jast7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 12, new DateTime(2023, 1, 27, 0, 6, 15, 812, DateTimeKind.Local).AddTicks(4460), "Tillman50@yahoo.com", "QRBknj/omzwz6P7uDqODzfcT72G42m8/2vveOh3WOOs=", "jLEr+uWFyMqJt5s7xKsso52uVktZNXF+jD4pIlcSftU=", new DateTime(2023, 1, 27, 0, 6, 15, 812, DateTimeKind.Local).AddTicks(4487), "Alexie94" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2023, 1, 27, 0, 6, 15, 814, DateTimeKind.Local).AddTicks(6061), "Gertrude_Murray@yahoo.com", "nJbp4YIJJT+LNfQw5mFWr7I66ftZUvNva7U20OAT4jc=", "lR+MWmUVqj6nY2tZ2Hcvd/mE6MytuuYgabacsDowxfo=", new DateTime(2023, 1, 27, 0, 6, 15, 814, DateTimeKind.Local).AddTicks(6150), "Uriah_Casper90" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2023, 1, 27, 0, 6, 15, 817, DateTimeKind.Local).AddTicks(1244), "Tyler.Considine93@hotmail.com", "hV6OYjDcrFNSXJ5G8xwzvS8g1KrMl0+8ss+6yrgAoGQ=", "CMH/ybZgfPWtTmZGfsa3zKt2c89AfwHOCIxpfWdvXxU=", new DateTime(2023, 1, 27, 0, 6, 15, 817, DateTimeKind.Local).AddTicks(1289), "Alessia.Herzog71" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2023, 1, 27, 0, 6, 15, 819, DateTimeKind.Local).AddTicks(2429), "Tyrel_Dietrich79@hotmail.com", "zG9TQDnOF5NgL7aSzQmwZkmVx3nHpz6AcT5+YX8X2Yo=", "Fhv7sT45RIx9IGY4WL6HDprqAiZXP3IbD3yqkT8npGA=", new DateTime(2023, 1, 27, 0, 6, 15, 819, DateTimeKind.Local).AddTicks(2477), "Kurtis.Kreiger79" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 821, DateTimeKind.Local).AddTicks(2680), "Clay.Kertzmann67@yahoo.com", "QF7+yx+8SFQH1+n2K2cP+dvcAcOEMJrrdIVkQaG9tnQ=", "rmWBibo66mP4Mw0/gVYMLUcyE+Lov8IkR7hLX2Ln0Ww=", new DateTime(2023, 1, 27, 0, 6, 15, 821, DateTimeKind.Local).AddTicks(2729), "Mac73" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2023, 1, 27, 0, 6, 15, 823, DateTimeKind.Local).AddTicks(825), "Neha0@yahoo.com", "Dv4FwzyVSRhlhMbqq1BfAgOJRZQ7hUyAD5YNyRE8FGo=", "+br7QZJ0bJahgI62tS6ZXISVYwojKmG+c2hxdwfo4CU=", new DateTime(2023, 1, 27, 0, 6, 15, 823, DateTimeKind.Local).AddTicks(840), "Rosie_Watsica" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 11, new DateTime(2023, 1, 27, 0, 6, 15, 824, DateTimeKind.Local).AddTicks(8954), "Jaiden.Runolfsson@hotmail.com", "jhTp7MR72pGQWVfYGV9vRTgP/Ay0oHZRxHiXbjYeb5Q=", "MZTfVECaj0Ht+ww7cjCxD5Sw42Hs0xb1TTqbXesRrlI=", new DateTime(2023, 1, 27, 0, 6, 15, 824, DateTimeKind.Local).AddTicks(8984), "Jody0" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2023, 1, 27, 0, 6, 15, 826, DateTimeKind.Local).AddTicks(7184), "Laura_Fritsch23@hotmail.com", "3pVXdknswho7XvuPoJSegomz8tDRp0s/U3/ZNt5C6Ck=", "TMtDIYjo6JxFkNLc3AZaXJyMoEMTCYAOeVQyNy0HLnI=", new DateTime(2023, 1, 27, 0, 6, 15, 826, DateTimeKind.Local).AddTicks(7208), "Athena_Lesch69" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2023, 1, 27, 0, 6, 15, 828, DateTimeKind.Local).AddTicks(5579), "Martin.Grant89@gmail.com", "z1RB60x3oPfDA4ER2uhk7wjUPAQO5IsGSkCHBCzal1o=", "NgvCp5tvwAY8NJsW9aur/uiX9+rSzl2HAGxmbyz5Hwc=", new DateTime(2023, 1, 27, 0, 6, 15, 828, DateTimeKind.Local).AddTicks(5618), "Alphonso.Padberg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 17, new DateTime(2023, 1, 27, 0, 6, 15, 830, DateTimeKind.Local).AddTicks(6614), "Maurice55@hotmail.com", "WKRl7+KnmOOKy7t98wlMUu+Q8joilQD+AiveD4+nJhs=", "13Z32L1Ru+FXkdQBV7jGlXwKdLgMdplmKtbZtSOcUmQ=", new DateTime(2023, 1, 27, 0, 6, 15, 830, DateTimeKind.Local).AddTicks(6656), "Bettye.Breitenberg" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2023, 1, 27, 0, 6, 15, 832, DateTimeKind.Local).AddTicks(4999), "Jayce71@hotmail.com", "fYcJFQDFDd89pMs6wzCLY51RUtb0aW50Y6O3IJo4FaY=", "PIguAX6ay7zmovIvYcpxkwGnedU18voTU4bDxxTDPxQ=", new DateTime(2023, 1, 27, 0, 6, 15, 832, DateTimeKind.Local).AddTicks(5032), "Estella.Nader" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2023, 1, 27, 0, 6, 15, 834, DateTimeKind.Local).AddTicks(3274), "Lilla.Weimann@gmail.com", "Q/jDFbA8l1mGF9nhfjFXmyMmlaZ+6BZQLG7++fZSSU8=", "xlryRpRyVPoFUaLzJO1alIYPO0GMZ9RNJWAu4BhsaE0=", new DateTime(2023, 1, 27, 0, 6, 15, 834, DateTimeKind.Local).AddTicks(3296), "Uriah55" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 7, new DateTime(2023, 1, 27, 0, 6, 15, 836, DateTimeKind.Local).AddTicks(3965), "Loy.Vandervort@yahoo.com", "fPWitOd6EOrWTpOLEdRNblX15nzCxqLYrFMRi1Xp7tU=", "N+8ej/k8qAodwSxUyTbnpFOFVorBz0cOhV5LvqW31ro=", new DateTime(2023, 1, 27, 0, 6, 15, 836, DateTimeKind.Local).AddTicks(4018), "Antonietta72" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2023, 1, 27, 0, 6, 15, 839, DateTimeKind.Local).AddTicks(178), "Germaine.Turner@hotmail.com", "3SfnytDE2zxkcDuvaJE799ly45RNv/6ItQbXxTVkVqI=", "YEPyXf7c/QLPk+O4CvYCGPBGORNtv0a1zGDud5H3YnA=", new DateTime(2023, 1, 27, 0, 6, 15, 839, DateTimeKind.Local).AddTicks(214), "Bria_Hauck" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2023, 1, 27, 0, 6, 15, 840, DateTimeKind.Local).AddTicks(9158), "Barton_Hand18@gmail.com", "KCA0i2RIxzGQRX+hTwTnFWXbS0nc0vdzLOfNaaD5xNM=", "kCct1t4BE3+jKo2lQEKN6OE+9B+y9jZ2Pvae8rs2DL4=", new DateTime(2023, 1, 27, 0, 6, 15, 840, DateTimeKind.Local).AddTicks(9197), "Casimer18" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2023, 1, 27, 0, 6, 15, 842, DateTimeKind.Local).AddTicks(8028), "Kris_Wunsch@hotmail.com", "BB0++6ti0CMLsmAYgqGBzS60eBSsXm0RrW15c+OjLEo=", "sKe79CZ9eUt3gJ/67yGciSp2ONmAoF6580hCs+F0Zq4=", new DateTime(2023, 1, 27, 0, 6, 15, 842, DateTimeKind.Local).AddTicks(8073), "Rafaela_Champlin56" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 6, 15, 845, DateTimeKind.Local).AddTicks(2394), "4X6JK6XeTbmnVFfgeKrVPMKGkb3Ql8rufeWOi6C6VfI=", "2lZWMqSZS6KILPqQpX9g6xWTfVPXDB2JG1f3cLHuyNU=", new DateTime(2023, 1, 27, 0, 6, 15, 845, DateTimeKind.Local).AddTicks(2394) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CommentReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PostReactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "IsDislike",
                table: "PostReactions");

            migrationBuilder.DropColumn(
                name: "IsDislike",
                table: "CommentReactions");

            migrationBuilder.InsertData(
                table: "CommentReactions",
                columns: new[] { "Id", "CommentId", "CreatedAt", "IsLike", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(3131), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4182), 8 },
                    { 2, 11, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4838), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4856), 1 },
                    { 3, 6, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4924), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4934), 6 },
                    { 4, 13, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4985), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(4996), 12 },
                    { 5, 19, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5131), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5139), 21 },
                    { 6, 4, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5176), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5182), 7 },
                    { 7, 6, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5209), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5215), 17 },
                    { 8, 14, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5242), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5247), 13 },
                    { 9, 13, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5274), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5280), 20 },
                    { 10, 16, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5307), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5313), 1 },
                    { 11, 12, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5340), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5345), 13 },
                    { 12, 2, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5372), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5378), 1 },
                    { 13, 18, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5405), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5411), 3 },
                    { 14, 6, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5438), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5443), 10 },
                    { 15, 13, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5470), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5476), 14 },
                    { 16, 3, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5502), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5508), 21 },
                    { 17, 20, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5536), false, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5541), 16 },
                    { 18, 15, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5568), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5573), 3 },
                    { 19, 16, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5599), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5605), 21 },
                    { 20, 2, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5630), true, new DateTime(2021, 5, 20, 11, 13, 15, 61, DateTimeKind.Local).AddTicks(5635), 17 }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 17, "Quo sunt necessitatibus impedit nobis repellendus voluptatem.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(5039), 6, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Mollitia et exercitationem aliquam animi iusto est cupiditate.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(6984), 13, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 16, "Porro nobis error.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7091), 14, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "A aliquid quia distinctio enim dolorem.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7193), 3, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 3, "Sit ut harum minus atque quidem molestias sint consectetur.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7306), 5, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Sapiente inventore nostrum.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7383), 5, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { "Blanditiis sed ea quia.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7628), 20, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 2, "Et dignissimos ut eaque voluptas labore.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7731), 3, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Aliquam aut saepe ipsum consequuntur totam quia ipsum autem.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7842), 10, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "UpdatedAt" },
                values: new object[] { 15, "Asperiores nostrum doloremque animi et.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7989), new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 14, "Esse vero officia.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8068), 7, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 21, "Adipisci ut voluptatum eos accusamus dolor.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8164), 4, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 12, "Sit dolorem aperiam alias maiores voluptates ut hic enim.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8356), 3, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Voluptatem itaque iusto.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8438), 11, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 18, "Consequuntur ea qui cupiditate quaerat.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8528), 15, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 7, "Libero eligendi excepturi est veniam.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8622), 17, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 4, "Pariatur et aperiam eligendi et explicabo.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8713), 19, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 1, "Aut sed nisi ipsa animi.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8855), 13, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 20, "Repudiandae pariatur eum voluptate expedita.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8949), 4, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PostId", "UpdatedAt" },
                values: new object[] { 6, "Quo et ut odio ut.", new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(9135), 17, new DateTime(2021, 5, 20, 11, 13, 15, 45, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(1845), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1081.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8310), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/462.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8352), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1199.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8377), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/36.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8401), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/488.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8497), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/210.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8526), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1032.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8551), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/4.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8574), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1002.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8598), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/298.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8603) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8621), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/60.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8644), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/996.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8669), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1043.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8693), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/813.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8716), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/965.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8740), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1187.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8763), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/443.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8787), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/857.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8810), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/885.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8833), "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/898.jpg", new DateTime(2021, 5, 20, 11, 13, 14, 770, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(2515), "https://picsum.photos/640/480/?image=34", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(3959), "https://picsum.photos/640/480/?image=210", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4108), "https://picsum.photos/640/480/?image=938", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4141), "https://picsum.photos/640/480/?image=582", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4167), "https://picsum.photos/640/480/?image=200", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4192), "https://picsum.photos/640/480/?image=556", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4217), "https://picsum.photos/640/480/?image=895", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4243), "https://picsum.photos/640/480/?image=501", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4268), "https://picsum.photos/640/480/?image=779", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4292), "https://picsum.photos/640/480/?image=971", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4316), "https://picsum.photos/640/480/?image=677", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4340), "https://picsum.photos/640/480/?image=987", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4365), "https://picsum.photos/640/480/?image=842", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4390), "https://picsum.photos/640/480/?image=127", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4415), "https://picsum.photos/640/480/?image=312", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4480), "https://picsum.photos/640/480/?image=122", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4509), "https://picsum.photos/640/480/?image=416", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4534), "https://picsum.photos/640/480/?image=127", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4558), "https://picsum.photos/640/480/?image=49", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "URL", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4582), "https://picsum.photos/640/480/?image=579", new DateTime(2021, 5, 20, 11, 13, 14, 776, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(7499), true, 2, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(8513), 14 },
                    { 2, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9192), true, 17, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9203), 5 },
                    { 3, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9248), true, 4, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9254), 1 },
                    { 4, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9281), true, 4, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9287), 6 }
                });

            migrationBuilder.InsertData(
                table: "PostReactions",
                columns: new[] { "Id", "CreatedAt", "IsLike", "PostId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 5, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9315), false, 5, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9321), 8 },
                    { 6, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9350), true, 19, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9355), 14 },
                    { 7, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9383), true, 10, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9389), 8 },
                    { 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9417), false, 4, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9423), 2 },
                    { 9, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9452), false, 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9457), 18 },
                    { 10, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9487), true, 13, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9492), 18 },
                    { 11, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9520), true, 17, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9525), 16 },
                    { 12, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9551), true, 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9556), 2 },
                    { 13, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9582), false, 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9588), 1 },
                    { 14, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9616), true, 17, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9621), 10 },
                    { 15, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9649), false, 9, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9654), 20 },
                    { 16, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9681), false, 19, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9686), 12 },
                    { 17, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9713), true, 18, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9718), 4 },
                    { 18, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9744), false, 18, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9750), 2 },
                    { 19, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9779), true, 12, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9784), 7 },
                    { 20, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9811), false, 8, new DateTime(2021, 5, 20, 11, 13, 15, 54, DateTimeKind.Local).AddTicks(9817), 11 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 8, "Ipsa laborum accusantium saepe. Sed numquam sit inventore beatae cumque voluptas et dignissimos voluptates. Earum expedita numquam harum quo voluptatem velit.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(1719), 40, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "mollitia", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(4623), 30, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "voluptatum", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(4872), 31, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "Ut eaque aut sunt occaecati autem. Rerum qui neque in in. Quia ullam fugiat optio unde ex dolor velit quasi unde. Id id ea reiciendis id sit blanditiis assumenda quisquam. Doloribus et est quia fugit ipsa.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(5624), 38, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Adipisci provident cumque repellendus facilis qui quia quos. Ipsa rem corrupti ut corrupti repellendus et qui eaque sapiente. Et soluta dolores magni qui sit in iusto.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(5977), 27, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 3, "Inventore voluptate quia distinctio consectetur. Commodi dolores minima omnis velit occaecati esse esse quidem voluptas. Quos occaecati at deleniti dicta sint aperiam. Reprehenderit laudantium et rerum dolor ab amet.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6354), 25, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 17, "beatae", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6426), 32, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 12, "vitae", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6487), 32, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 21, "Dicta est reiciendis voluptas earum odit cumque in suscipit in.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(7857), 38, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 6, "Et dolores sed. Aspernatur est modi nemo. Labore natus placeat quo quis.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8160), 29, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Hic a velit optio corporis dolor voluptatum. At illum labore quia sit voluptate soluta ea. Voluptatum voluptatem aliquam dolor eos corporis soluta. Eum ex et aut eveniet qui ut. Veniam modi magni iure.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8574), 36, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 19, "Quasi quis quos illo aperiam autem nisi.", new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8727), 24, new DateTime(2021, 5, 20, 11, 13, 15, 36, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Atque et dicta et minus ipsum et. Laborum ut tenetur tempore ut aut. Sit unde perferendis temporibus distinctio at quidem aut quos vel. Quos consequatur aut impedit tempora ab ea vel. At dolores deleniti expedita et saepe ipsa consequatur provident. Illum repellendus veritatis rem neque est.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(1049), 38, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 7, "quod", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(1193), 37, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "Soluta repudiandae velit.\nIpsam ut enim necessitatibus eius ab quae quasi ex neque.\nConsequatur et in architecto repellat voluptas molestiae provident pariatur.\nEx doloribus et.\nEt non ut quidem iste hic reiciendis et.\nNumquam excepturi quas.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(2954), 38, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 20, "Sed sint eveniet.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3100), 28, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 18, "maxime", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3161), 31, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 2, "Vel error aut sapiente.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3249), 39, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 11, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3302), 31, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "Body", "CreatedAt", "PreviewId", "UpdatedAt" },
                values: new object[] { 16, "Numquam temporibus dolor non commodi error quos earum officia.", new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3511), 23, new DateTime(2021, 5, 20, 11, 13, 15, 37, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 3, new DateTime(2021, 5, 20, 11, 13, 14, 826, DateTimeKind.Local).AddTicks(488), "Murray_Schuster79@gmail.com", "acAJ53wZsq31VAb6cMXgUfIax6/m7Y0/RHnoJEnMYEg=", "Rcm3LnHPlpiN5J9LLJYTd0PcilyDDnVc6Nswoyo47j0=", new DateTime(2021, 5, 20, 11, 13, 14, 826, DateTimeKind.Local).AddTicks(1583), "Titus_Kuvalis" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 13, new DateTime(2021, 5, 20, 11, 13, 14, 837, DateTimeKind.Local).AddTicks(138), "Dave79@yahoo.com", "d32nF9qsABrvxMVc32IrJVyR99sYzoFWb8KMrKJtcBo=", "tKnkVn1ZFt/SZzKzklyEc3+JSjAszT7v5RMwkfSSA6I=", new DateTime(2021, 5, 20, 11, 13, 14, 837, DateTimeKind.Local).AddTicks(212), "Al_Raynor" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2021, 5, 20, 11, 13, 14, 846, DateTimeKind.Local).AddTicks(7785), "Kendrick_Emmerich13@gmail.com", "hwaghCHm2/1iUok1aCOO6BLTATiQihj5O2AH/ftjbRE=", "+uJsbanlGIkilFjT1yEIO2jLY+GJdMK/HVrxnuwP6i8=", new DateTime(2021, 5, 20, 11, 13, 14, 846, DateTimeKind.Local).AddTicks(7817), "Lenore16" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 20, new DateTime(2021, 5, 20, 11, 13, 14, 856, DateTimeKind.Local).AddTicks(5118), "Lelia_Wintheiser@gmail.com", "NT0Ru66Nr2SQMOYwTg7h8HFDkbhZSGnjrOhfKMCK/VY=", "bRn9pW/8YH842PoDeaPqCJs4ZzFupb6KLJ5cFgWvvXI=", new DateTime(2021, 5, 20, 11, 13, 14, 856, DateTimeKind.Local).AddTicks(5182), "Lionel74" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 2, new DateTime(2021, 5, 20, 11, 13, 14, 866, DateTimeKind.Local).AddTicks(1579), "Shanna.Wolf62@yahoo.com", "xB+JebeSFso9LfB1R0QWq2UD0oOg7UGYMRPoyZ6i77Y=", "mXrPmUfK+EPvjzmLLdmoZE3H6a37OmSXuCK1tH6cFso=", new DateTime(2021, 5, 20, 11, 13, 14, 866, DateTimeKind.Local).AddTicks(1657), "Natasha_Watsica1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2021, 5, 20, 11, 13, 14, 875, DateTimeKind.Local).AddTicks(6521), "Emil_Moen50@gmail.com", "Wgxx1H7JzjFDpm110weZvqoahZTXgr7Qe3b5WgxraQk=", "gohkEBKxAZWAwYeggEMnkbA6CM7XnSMXVBfwN82C910=", new DateTime(2021, 5, 20, 11, 13, 14, 875, DateTimeKind.Local).AddTicks(6589), "Jennifer45" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2021, 5, 20, 11, 13, 14, 885, DateTimeKind.Local).AddTicks(1450), "Kaleb27@hotmail.com", "J1uf9/PUNeKVrn7jF/Yq7m+0EwZADBlvR+cV+rtcxZQ=", "ySLHbl4+0zW3baq+7fkLbdh9zsJFD7CH2FXuO9SBx58=", new DateTime(2021, 5, 20, 11, 13, 14, 885, DateTimeKind.Local).AddTicks(1515), "Hunter.Kemmer" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 5, new DateTime(2021, 5, 20, 11, 13, 14, 894, DateTimeKind.Local).AddTicks(4593), "Brycen_Bayer@gmail.com", "aaOiiDbTIa2LHpb3qRNhL89CnRUeVJxi+tSdrX6b4OI=", "I4Gidaxl1CccNkwj4MlceIvNOPqMd17wS2LXcrlqh04=", new DateTime(2021, 5, 20, 11, 13, 14, 894, DateTimeKind.Local).AddTicks(4653), "Chelsie24" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 14, 904, DateTimeKind.Local).AddTicks(2432), "Giuseppe.Schowalter35@gmail.com", "hZ+2DYV5XXAIOVHgnWBDbfpcg8AQ4zM+9wIJLyAb918=", "hcAUmWfOD0aISKN9HfNk26g/aFy0FNDtKhd/p4b3dO0=", new DateTime(2021, 5, 20, 11, 13, 14, 904, DateTimeKind.Local).AddTicks(2515), "Gino.White66" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 15, new DateTime(2021, 5, 20, 11, 13, 14, 913, DateTimeKind.Local).AddTicks(1972), "Madge.McKenzie27@hotmail.com", "wkwbVcA0aF/VIzL/IDIjM7Azl1hRLCpn60+08IGE6BU=", "0FdI7ApNn6iiqH+JugvWa51yvP0xQNkO1rRxsvQ2Dlo=", new DateTime(2021, 5, 20, 11, 13, 14, 913, DateTimeKind.Local).AddTicks(2019), "Warren_Bernier" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2021, 5, 20, 11, 13, 14, 922, DateTimeKind.Local).AddTicks(3523), "Sandra58@hotmail.com", "k8R4dwnKEzCNF/gUJhFLkEv4xK5nI1GjvYZySMBXGfU=", "usYqevKzZb+qARv2wZCKcPL7vjZGIQf77wZaG9DWDk4=", new DateTime(2021, 5, 20, 11, 13, 14, 922, DateTimeKind.Local).AddTicks(3584), "Angelina.Krajcik76" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2021, 5, 20, 11, 13, 14, 931, DateTimeKind.Local).AddTicks(4810), "Etha.Kuhic@hotmail.com", "tUkmuUC33oqMFIku6hXOpevaYAFHpD2+MLu02CIEfYg=", "xM96YjEgTurGXzj8FfvB3DIj8YsMlioDF0vJrWGj63c=", new DateTime(2021, 5, 20, 11, 13, 14, 931, DateTimeKind.Local).AddTicks(4874), "Antonio.Kub" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 4, new DateTime(2021, 5, 20, 11, 13, 14, 940, DateTimeKind.Local).AddTicks(5517), "Reymundo.Hyatt9@hotmail.com", "0t+8Uu4780g97Q47WrMGjg4ZC2NyaZyjhrVAueDckpw=", "k+nKIvhRcAZoCTlvp4jeLaxOc6Mm7mQvpAZpwIXGiZA=", new DateTime(2021, 5, 20, 11, 13, 14, 940, DateTimeKind.Local).AddTicks(5579), "Buck_Reynolds58" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 8, new DateTime(2021, 5, 20, 11, 13, 14, 949, DateTimeKind.Local).AddTicks(9808), "Ewald_Brown15@gmail.com", "nWDeaY8L/6N+Fe0PIwDMFcbtD8CymNncpqw8sms9i7s=", "ubu59TXbBb0pWuax4nkHvFdu1BLWz6lpSf27whkn0Zw=", new DateTime(2021, 5, 20, 11, 13, 14, 949, DateTimeKind.Local).AddTicks(9852), "Nichole.Kulas" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2021, 5, 20, 11, 13, 14, 960, DateTimeKind.Local).AddTicks(4225), "Webster.Armstrong@yahoo.com", "LbmH1t3nBO0bGpMlURNDdHCbhfm4YFhBp6i8jvYW89g=", "8aLXS7QORAG4uDB+wL5UxChZxhszib/in2oWivPE3oY=", new DateTime(2021, 5, 20, 11, 13, 14, 960, DateTimeKind.Local).AddTicks(4300), "Sigurd_Koch" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 16, new DateTime(2021, 5, 20, 11, 13, 14, 970, DateTimeKind.Local).AddTicks(4430), "Chester.Gibson@yahoo.com", "VxSMljQua5wzDvMTEaHBXvqXg52XaKLJZ9FwWeAr64A=", "99Xcb7TKeygJf4WqTJHCz40J7et0ShfsSKdBaosYcIU=", new DateTime(2021, 5, 20, 11, 13, 14, 970, DateTimeKind.Local).AddTicks(4500), "Zetta_Corwin" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 9, new DateTime(2021, 5, 20, 11, 13, 14, 979, DateTimeKind.Local).AddTicks(94), "Cory22@hotmail.com", "cC/WtQdyOIXKFdNESGGD3+4le0trUPJBOjDBYWkwGSs=", "vIQ5cLovukqZYHZ7CGBut3nvr4rD4pqucGuIplghdSc=", new DateTime(2021, 5, 20, 11, 13, 14, 979, DateTimeKind.Local).AddTicks(117), "Harrison_Funk" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 14, new DateTime(2021, 5, 20, 11, 13, 14, 987, DateTimeKind.Local).AddTicks(9474), "Maximus.Schowalter@hotmail.com", "07nUGFmM3kNcnN5BVOql7SjpvK++FzyfLSDhRBW5uhc=", "AlXbT32FGJzaFlNqe7BeNZHBHbEVro2VwUaHkpWOo/k=", new DateTime(2021, 5, 20, 11, 13, 14, 987, DateTimeKind.Local).AddTicks(9547), "Magnolia_Klocko" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 19, new DateTime(2021, 5, 20, 11, 13, 14, 998, DateTimeKind.Local).AddTicks(5070), "Kathryn_Abshire82@yahoo.com", "YPW+idxIGypCR3HAHfvBYxoTJIrKQqywAgAdOTCkUDQ=", "aLSTRGtEVgAXEB7SxTJVGuz2WAyBd8+WJ2DHMPCQAaQ=", new DateTime(2021, 5, 20, 11, 13, 14, 998, DateTimeKind.Local).AddTicks(5100), "Amina.Skiles4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AvatarId", "CreatedAt", "Email", "Password", "Salt", "UpdatedAt", "UserName" },
                values: new object[] { 10, new DateTime(2021, 5, 20, 11, 13, 15, 9, DateTimeKind.Local).AddTicks(4440), "Javon.Hane5@yahoo.com", "qjQeVb5gyvGZR7JCCa3WcNpCJbbZC1msMQAAm8xzC88=", "sOIYRCoaEv1lNThIyXb7kFDIyRELtsXhnm+bAfZ5fj0=", new DateTime(2021, 5, 20, 11, 13, 15, 9, DateTimeKind.Local).AddTicks(4506), "Precious44" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Password", "Salt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 20, 11, 13, 15, 20, DateTimeKind.Local).AddTicks(3327), "UGZorU7ixmt7ZHZpwbpmfxeeDK1RdaxwQ8tmD7ojIGU=", "lAdg0m8nOXEvf6zmjZ8bbXKHhE8QfSpTUcV9L09Z+84=", new DateTime(2021, 5, 20, 11, 13, 15, 20, DateTimeKind.Local).AddTicks(3327) });
        }
    }
}
