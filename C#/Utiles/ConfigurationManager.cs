using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TesisApi.Utiles
{
    public class ConfigurationManager : IDisposable
    {
        private string jsonFile = string.Empty;
        public string JsonFile
        {
            get { return jsonFile; }
            private set
            {
                jsonFile = "appsettings.json";
            }
        }
        private IConfiguration ConfigurationFile { get; set; }

        public ConfigurationManager(string jsonFile)
        {
            JsonFile = jsonFile;
            InitializeComponent();
        }

        public ConfigurationManager()
        {
            JsonFile = "appsettings.json";
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            IConfigurationBuilder configurationBuild = new ConfigurationBuilder();
            configurationBuild = configurationBuild.SetBasePath(Directory.GetCurrentDirectory());
            configurationBuild = configurationBuild.AddJsonFile(JsonFile);
            ConfigurationFile = configurationBuild.Build();
        }

        /// <summary>
        /// Obtiene valor de llave ubicada en el elemento "appSettings" del archivo *.json
        /// </summary>
        /// <param name="key">Llave</param>
        /// <returns>Valor como cadena de caracteres</returns>
        public string AppSettings(string key)
        {
            try
            {
                var value = ConfigurationFile[$"{key}"];
                return value.ToString();
            }
            catch (Exception ex)
            {
                var message = $"Error al leer valor {key} del archivo {JsonFile}. \n {ex.Message}";
                throw new ArgumentException(message);
            }
        }

        /// <summary>
        /// Obtiene valor de llave ubicada en el elemento "appSettings" del archivo *.json
        /// </summary>
        /// <typeparam name="T">Tipo de dato</typeparam>
        /// <param name="key">Llave</param>
        /// <returns>Valor de tipo T</returns>
        public T AppSettings<T>(string key)
        {
            try
            {
                var value = ConfigurationFile[$"{key}"];
                if (!TryChangeType<T>(value, out T result))
                    throw new ArgumentException($"Error al convertir el valor {value} de la llave {key} a {typeof(T)}, del archivo {JsonFile}.");

                return result;
            }
            catch (Exception ex)
            {
                var message = $"Error al leer valor {key} del archivo {JsonFile}. \n {ex.Message}";
                throw new ArgumentException(message);
            }
        }

        /// <summary>
        /// Obtiene valor de llave ubicada en el elemento "appSettings" del archivo *.json
        /// </summary>
        /// <typeparam name="T">Tipo de dato</typeparam>
        /// <param name="key">Llave</param>
        /// <param name="defaultVal">Valor por defecto</param>
        /// <returns>Valor de tipo T</returns>
        public T AppSettings<T>(string key, T defaultVal)
        {
            try
            {
                var value = ConfigurationFile[$"{key}"];
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch
            {
                return defaultVal;
            }
        }

        /// <summary>
        /// Obtiene valor de llave ubicada en el elemento "configSections" del archivo *.json
        /// </summary>
        /// <param name="key">Llave</param>
        /// <returns>Cadena de conexion</returns>
        public string ConnectionStrings(string key)
        {
            try
            {
                object value = ConfigurationFile.GetConnectionString(key);
                return value.ToString();
            }
            catch (Exception ex)
            {
                var message = $"Error al leer valor {key} del archivo {JsonFile}. \n {ex.Message}";
                throw new ArgumentException(message);
            }
        }


        private static Boolean TryChangeType<T>(Object value, out T result)
        {
            result = default;

            if (!CanChangeType(value, typeof(T)))
                return false;

            result = (T)Convert.ChangeType(value, typeof(T));
            return true;
        }
        private static Boolean CanChangeType(Object value, Type conversionType)
        {
            return conversionType != null && value != null && (value is IConvertible);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                JsonFile = null;
                ConfigurationFile = null;
            }
        }
    }
}
