using System.Text;
using Azure.Messaging.ServiceBus;
using Newtonsoft.Json;

namespace Chatora.MessageBus;

public class MessageBus : IMessageBus
{
    private string connectionString =
        "Endpoint=sb://pujyapreyans.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=fC5Ljk7gZn2wHkGPis6JZojYs3NUXzre1+ASbKwDiuc=";
    public async Task PublishMessage(object message, string topicQueueName)
    {
        await using var client = new ServiceBusClient(connectionString);

        ServiceBusSender sender = client.CreateSender(topicQueueName);

        var jsonMessage = JsonConvert.SerializeObject(message);
        ServiceBusMessage finalMessage = new ServiceBusMessage(Encoding.UTF8.GetBytes(jsonMessage))
        {
            CorrelationId = Guid.NewGuid().ToString()
        };

        await sender.SendMessageAsync(finalMessage);
        await client.DisposeAsync();
    }
}