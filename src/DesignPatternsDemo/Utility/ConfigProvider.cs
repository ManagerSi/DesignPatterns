using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace DesignPatternsDemo.Utility
{
    public class ConfigProvider
    {
        public static string GetConfigString(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return null;

            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            return configuration.GetSection(path).Value.ToString();
        }
    }
}
