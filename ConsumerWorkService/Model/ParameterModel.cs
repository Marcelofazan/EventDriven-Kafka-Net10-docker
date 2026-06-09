using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsumerWorkService.Model
{
    internal sealed class ParameterModel(IConfiguration _configuration)
    {
        public string BootstrapServers { get; set; } = _configuration["KafkaConfig:BootstrapServer"]!;
        public string TopicName { get; set; } = _configuration["KafkaConfig:TopicName"]!;
        public string GroupId { get; set; } = _configuration["KafkaConfig:GroupId"]!;
    }

}
