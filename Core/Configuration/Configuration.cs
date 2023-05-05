
using Microsoft.Extensions.Configuration;

namespace Core.Configurations
{
    public static class Configuration
    {
        public static BrowserConfiguration Browser = BindConfiguration<BrowserConfiguration>();

        public static string CurrentDirectory => Directory.GetCurrentDirectory();

        private static T BindConfiguration<T>(IConfigurationRoot configurationRoot = null!) where T : IConfiguration
        {
            var config = Activator.CreateInstance<T>();
            (configurationRoot ?? ConfigurationRoot).GetSection(config.SectionName).Bind(config);
            return config;
        }

        public static string GetValue(string key)
        {
            return ConfigurationRoot[key];
        }

        /// <summary>
        /// Extract relative apdirectory path (e.g. path to resources or upload folder) from .json configuration file
        /// and return absolute path to the directory
        /// </summary>
        public static string GetDirectory(string key)
        {
            string directoryRelativePath = GetValue(key).Replace("/", Path.DirectorySeparatorChar.ToString());
            return GetRootPath(directoryRelativePath);
        }


        public static string GetRootPath(params string[] fileOrDirectoryNames)
        {
            List<string> paths = new List<string> { AppDomain.CurrentDomain.BaseDirectory };
            paths.AddRange(fileOrDirectoryNames);
            string rootPath = Path.Combine(paths.ToArray());

            return rootPath;
        }

        public static IConfigurationRoot ConfigurationRoot =>

             new ConfigurationBuilder()
            .SetBasePath(CurrentDirectory)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile("appsettings.custom.json", true, true)
                .Build();
    }
}