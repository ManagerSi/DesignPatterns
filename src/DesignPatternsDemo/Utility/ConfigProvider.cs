using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace DesignPatternsDemo.Utility
{
    public class ConfigProvider
    {
        private static IConfigurationRoot _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        private ConfigProvider()
        {
        }
        
        public static string GetConfigString(string path=null, string filePath=null)
        {
            if (string.IsNullOrWhiteSpace(path)) return null;

            if (!string.IsNullOrWhiteSpace(filePath))
            {
                IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile(filePath);
                var configuration = builder.Build();
                return configuration.GetSection(path).Value.ToString();
            }
            else
            {
                return _configuration.GetSection(path).Value.ToString();
            }
        }
    }
}
