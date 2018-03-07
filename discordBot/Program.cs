using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;


namespace discordBot
{
    public class Program
    {



     

        public static void Main(string[] args)

            => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {


            var client = new DiscordSocketClient();

            client.Log += Log;

            string token = "NDIwOTYwOTQ0Mzk1Mzg2ODgw.DYGSog.F4RI7pes0HCUA5xmwrqO9rEQY8U";
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            Task.WaitAny();
            await Task.Delay(-1);

        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

    }
}
