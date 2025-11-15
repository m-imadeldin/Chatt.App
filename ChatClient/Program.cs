using System;
using System.Threading.Tasks;

namespace ChatClientApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "Chat Client";
            Console.WriteLine("== Chat Client with Socket.IO ===");
            Console.Write("Enter username: ");
            string? username = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(username)) username = "Anonymous";

            var user = new User(username);
            user.PrintUsername();

            var history = new MessageHistory();
            history.Load();

            Console.Write("Enter server URL (e.g. http://localhost:3000 or https://api.example.com): ");
            string? serverUrl = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(serverUrl))
            {
                Console.WriteLine("No server URL provided. Exiting.");
                return;
            }

            var client = new ChatClient(user, history, serverUrl.Trim());
            var handler = new CommandHandler(client, history);

            await client.ConnectAsync();

            Console.WriteLine("Type /help for commands.");
            while (true)
            {
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;

                if (input.StartsWith("/"))
                {
                    await handler.HandleAsync(input);
                }
                else
                {
                    await client.SendMessageAsync(input);
                }
            }
        }
    }
}