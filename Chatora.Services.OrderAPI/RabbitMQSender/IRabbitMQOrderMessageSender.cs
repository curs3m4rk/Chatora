namespace Chatora.Services.ShoppingCartAPI.RabbitMQSender
{
    public interface IRabbitMQOrderMessageSender
    {
        void SendMessage(Object message, string queueName);
    }
}
