using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteMVVMForms
{
    public class LiteServiceLocator
    {
        private static LiteServiceLocator instance;

        private LiteServiceLocator()
        {
            services = new Dictionary<Type, object>();
        }

        public static LiteServiceLocator Current
        {
            get { return instance ?? (instance = new LiteServiceLocator()); }
        }

        /// <summary>
        /// List of services
        /// </summary>
        private readonly Dictionary<Type, object> services;

        /// <summary>
        /// Gets the first available service
        /// </summary>
        /// <typeparam name="T">Type of service to get</typeparam>
        /// <returns>First available service if there are any, otherwise null</returns>
        public T Get<T>() where T : class
        {
            object service = null;
            if (services.TryGetValue(typeof(T), out service))
                return service as T;
            throw new NotImplementedException($"Implementation not register for this Interface: {typeof(T).Name}");
        }

        /// <summary>
        /// Registers a service provider
        /// </summary>
        /// <typeparam name="T">Type of the service</typeparam>
        /// <param name="service">Service provider</param>
        public LiteServiceLocator Register<T>(T service) where T : class
        {
            var type = typeof(T);
            if (this.services.ContainsKey(type))
            {
                this.services.Remove(type);
            }

            this.services.Add(type, service);

            return this;
        }

        public LiteServiceLocator Register<T, TImpl>()
            where T : class
            where TImpl : class, T
        {
            var service = Activator.CreateInstance(typeof(TImpl)) as T;
            return Register<T>(service);
        }

    }
}
