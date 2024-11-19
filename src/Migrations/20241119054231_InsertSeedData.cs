using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DDD.Migrations
{
    /// <inheritdoc />
    public partial class InsertSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO public.""Books"" (""Id"", ""Title"", ""IsAvailable"") VALUES
                ('b4f8a1c2-1e3b-4c88-9852-7b80c1150e58', 'The Catcher in the Rye', true),
                ('a8f3d0e9-3bda-4d61-9829-1b85c77cdb3b', 'To Kill a Mockingbird', true),
                ('c9e1a345-2f7b-467e-9f9c-2d45b892de3d', '1984', false),
                ('d1b1d234-8c3e-46c4-8a0f-3c1d5c5b9d9d', 'Pride and Prejudice', true),
                ('e2f2b567-5d0c-4bfc-9e12-8c32c6c5a9d5', 'The Great Gatsby', true);
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                DELETE FROM public.""Books"" WHERE Id IN (
                    'b4f8a1c2-1e3b-4c88-9852-7b80c1150e58',
                    'a8f3d0e9-3bda-4d61-9829-1b85c77cdb3b',
                    'c9e1a345-2f7b-467e-9f9c-2d45b892de3d',
                    'd1b1d234-8c3e-46c4-8a0f-3c1d5c5b9d9d',
                    'e2f2b567-5d0c-4bfc-9e12-8c32c6c5a9d5'
                );
            ");
        }
    }
}
