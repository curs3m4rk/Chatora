using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace Chatora.Services.AuthAPI.RabbitMQSender
{
    public class RabbitMQAuthMesageSender : IRabbitMQAuthMessageSender
    {
        private readonly string _hostName;
        private readonly string _userName;
        private readonly string _password;
        private IConnection _connection;

        public RabbitMQAuthMesageSender()
        {
            _hostName = "localhost";
            _userName = "guest";
            _password = "guest";
        }

        public void SendMessage(object message, string queueName)
        {
            var factory = new ConnectionFactory
            {
                HostName = _hostName,
                UserName = _userName,
                Password = _password
            };

            // establish connection to RabbitMQ
            _connection = factory.CreateConnection();

            using var channel = _connection.CreateModel();
            channel.QueueDeclare(queueName, false, false, false, null);
            var json = JsonConvert.SerializeObject(message);
            var body = Encoding.UTF8.GetBytes(json);

            channel.BasicPublish(exchange:"", routingKey: queueName, null, body: body);
        }
    }
}
