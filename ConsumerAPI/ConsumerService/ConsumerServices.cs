using MassTransit;
using Shared;

namespace ConsumerAPI.ConsumerService
{
    public class ConsumerServices(ILogger<ConsumerServices> logger) : IConsumer<MyMessage>
    {
        private   string _messages =string.Empty;
        async Task IConsumer<MyMessage>.Consume(ConsumeContext<MyMessage> context)
        {
            logger.LogInformation(context.Message.Content);
            _messages=context.Message.Content.ToString();
            await Task.Run(() => Console.WriteLine($"Wheather forcast Data:{context.Message.Content}"));
        }
    }
}
