using System;
using System.Collections.Generic;
using System.Text;
using RabbitMQ.Client;
using Newtonsoft.Json;

namespace GiraffeChess.DomainService
{
    public class BusCommunicator
    {
        private ConnectionFactory ConnectionFactory { get; set; }
        public BusCommunicator(string hostname, int port)
        {
            ConnectionFactory = new ConnectionFactory()
            {
                HostName = hostname,
                Port = port
            };
        }

        public void SendCommand(string exchange, string routingKey, object messageBody)
        {
            using (var connection = ConnectionFactory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: exchange,
                    type: "topic");

                var objectJsonString = JsonConvert.SerializeObject(messageBody);
                Console.Write("send");
                channel.BasicPublish(exchange: "Events",
                    routingKey: routingKey, basicProperties: null,
                    body: Encoding.UTF8.GetBytes(objectJsonString));


            }
        }

    }
}
