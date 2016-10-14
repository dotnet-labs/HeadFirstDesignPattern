using Castle.DynamicProxy;
using System;

namespace ProxyPattern.Castle
{
    public class MyInterceptorAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var methodName = invocation.Method.Name;
            Console.WriteLine($"Before {methodName}");
            invocation.Proceed();
            Console.WriteLine($"After {methodName}");
        }
    }

    public class CastleDynamicProxy
    {
        public virtual void DoStuff()
        {
            Console.WriteLine("Inside of DoStuff()");
        }
    }

    public class MyOtherClass
    {
        public virtual void DoOtherStuff()
        {
            Console.WriteLine("Inside of DoOtherStuff()");
        }
    }

    public static class CastleDynamicProxyTest
    {
        public static void Test()
        {
            var generator = new ProxyGenerator();
            var myObject = generator.CreateClassProxy<CastleDynamicProxy>(new MyInterceptorAspect());
            var myOtherObject = generator.CreateClassProxy<MyOtherClass>(new MyInterceptorAspect());

            myObject.DoStuff();
            Console.WriteLine();
            myOtherObject.DoOtherStuff();
        }
    }
}
