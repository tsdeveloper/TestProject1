using Data;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Model;
using Newtonsoft.Json;
using Service;

namespace TestProject1
{
    public class UnitTest1
    {
        private ServiceProvider serviceProvider;
        private TestContext _context;
        private IPrizeRedemptionService? _IPrizeRedemptionService;

        public UnitTest1()
        {
            serviceProvider = new ServiceCollection()
           .AddEntityFrameworkSqlServer()
           .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<TestContext>();

            builder.UseSqlServer($"Server=.;Database=dotnet;Integrated Security=True;TrustServerCertificate=True")
                    .UseInternalServiceProvider(serviceProvider);

            _context = new TestContext(builder.Options);
            _context.Database.Migrate();
        }
        [Fact]
        public async Task Test1()
        {

            var body = @"{
                                          ""lottery_name"": ""Mega Sena"",
                                          ""lottery_id"": 11,
                                          ""user_code"": 9999,
                                          ""draw"": ""2022-08-05T20:00:00.000Z"",
                                          ""game"": ""pool"",
                                          ""contest_number"": 2219,
                                          ""quota_quantity"": 1,
                                          ""jackpot"": 30000,
                                          ""price"": 12,
                                          ""group_name"": ""MS-MMM-011"",
                                          ""group_code"": 2,
                                          ""award_winning_games"": 1,
                                          ""document"": ""38806459066"",
                                          ""email"": ""test-integrated@sensedia.com"",
                                          ""contest_number_ref"": 2
                                        }";

            _IPrizeRedemptionService = serviceProvider.GetService<IPrizeRedemptionService>();
            var updater = new PrizeRedemptionUpdater(_context);

            var obj = JsonConvert.DeserializeObject<PrizeRedemptionRequest>(body);

            var genericResponse = await new PrizeRedemptionService(updater).PostAsync(obj);

            genericResponse.Should().BeNegative();

        }
    }
}