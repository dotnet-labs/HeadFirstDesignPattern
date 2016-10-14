using System;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;

namespace ProxyPattern.MatchMaking.ProxyHandler
{
    public class OwnerInvocationHandler : RealProxy
    {
        private readonly IPersonBean _personBean;

        private OwnerInvocationHandler(IPersonBean personBean)
            : base(typeof(IPersonBean))
        {
            _personBean = personBean;
        }

        public static IPersonBean Create(IPersonBean personBean)
        {
            return (IPersonBean)new OwnerInvocationHandler(personBean).GetTransparentProxy();
        }

        public override IMessage Invoke(IMessage msg)
        {
            var methodCall = (IMethodCallMessage)msg;
            var method = (MethodInfo)methodCall.MethodBase;

            if (method.Name.StartsWith("Get"))
            {
                return ValidInvoke(method, methodCall);
            }
            else if (method.Name.Equals("SetHotOrNotRating"))
            {
                throw new UnauthorizedAccessException($"Can't set {method.Name} from owner proxy.");
            }
            else if (method.Name.StartsWith("Set"))
            {
                return ValidInvoke(method, methodCall);
            }
            else
            {
                return ValidInvoke(method, methodCall);
            }
        }

        private IMessage ValidInvoke(MethodInfo method, IMethodCallMessage methodCall)
        {
            var result = method.Invoke(_personBean, methodCall.InArgs);
            return new ReturnMessage(result, null, 0, methodCall.LogicalCallContext, methodCall);
        }

    }
}
