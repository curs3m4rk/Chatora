using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace Chatora.Services.ShoppingCartAPI.RabbitMQSender
{
    public class RabbitMQOrderMesageSender : IRabbitMQOrderMessageSender
    {
        private readonly IConfiguration _configuration;
        private readonly string _hostName;
        private readonly string _userName;
        private readonly string _password;
        private IConnection _connection;

        public RabbitMQOrderMesageSender(IConfiguration configuration)
        {
            _configuration = configuration;
            _hostName = "localhost";
            _userName = "guest";
            _password = "guest";
        }

        public void SendMessage(object message, string exchangeName)
        {
            if (ConnectionExists())
            {
                using var channel = _connection.CreateModel();
                channel.ExchangeDeclare(exchangeName, ExchangeType.Fanout, durable:false);
                channel.QueueDeclare(_configuration.GetValue<string>("TopicAndQueueNames:OrderCreated_RewardsUpdateQueue"), false, false, false, null);
                channel.QueueDeclare(_configuration.GetValue<string>("TopicAndQueueNames:OrderCreated_EmailUpdateQueue"), false, false, false, null);

                channel.QueueBind(_configuration.GetValue<string>("TopicAndQueueNames:OrderCreated_RewardsUpdateQueue"), exchangeName, "RewardsUpdate");
                channel.QueueBind(_configuration.GetValue<string>("TopicAndQueueNames:OrderCreated_EmailUpdateQueue"), exchangeName, "EmailUpdate");

                var json = JsonConvert.SerializeObject(message);
                var body = Encoding.UTF8.GetBytes(json);

                channel.BasicPublish(exchange: exchangeName, "RewardsUpdate", null, body: body);
                channel.BasicPublish(exchange: exchangeName, "EmailUpdate", null, body: body);
            }
        }

        private void CreateConnection()
        {
            try
            {
                var factory = new ConnectionFactory
                {
                    HostName = _hostName,
                    UserName = _userName,
                    Password = _password
                };

                // establish connection to RabbitMQ
                _connection = factory.CreateConnection();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool ConnectionExists()
        {
            if(_connection != null)
            {
                return true;
            }
            CreateConnection();
            return true;
        }
    }
}
