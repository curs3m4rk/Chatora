namespace Chatora.MessageBus;

public interface IMessageBus
{
    Task PublishMessage(object message, string topicQueueName);
}