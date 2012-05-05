using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace IocContainer
{
    public class IocContainer
    {
        private readonly Dictionary<Type, Type> _dependencyMap =
            new Dictionary<Type, Type>();

        public T Resolve<T>()
        {
            return (T) Resolve(typeof (T));
        }

        public void Register<TFrom, TTo>()
        {
            _dependencyMap.Add(typeof (TFrom), typeof (TTo));
        }

        private object Resolve(Type type)
        {
            Type resolvedType = LookUpDependency(type);
            ConstructorInfo constructor =
                resolvedType.GetConstructors().First();
            ParameterInfo[] parameters = constructor.GetParameters();

            if (!parameters.Any())
            {
                return Activator.CreateInstance(resolvedType);
            }
            else
            {
                return constructor.Invoke(
                    ResolveParameters(parameters)
                        .ToArray());
            }
        }

        private Type LookUpDependency(Type type)
        {
            return _dependencyMap[type];
        }

        private IEnumerable<object> ResolveParameters(
            IEnumerable<ParameterInfo> parameters)
        {
            return parameters
                .Select(p => Resolve(p.ParameterType))
                .ToList();
        }
    }
}