namespace ProxyPattern.SimpleProxyPattern;

internal class ProxyContainer
{
    private class ComplexProtectedExpensiveResource
    {
        internal void DoWork()
        {
            //do some heavy lifting
        }
    }

    // The Proxy
    public class SimpleProxy(string password)
    {
        private ComplexProtectedExpensiveResource? _complexProtectedResource;

        public void DoWork()
        {
            if (Authenticate())
            {
                _complexProtectedResource?.DoWork();
            }
        }

        bool Authenticate()
        {
            //authenticate request
            if (password == "password")
            {
                //create expensive object if authenticated
                _complexProtectedResource ??= new ComplexProtectedExpensiveResource();
                return true;
            }
            return false;
        }
    }
}

// The Client
internal class ProxyPattern : ProxyContainer
{
    public static void DoWork()
    {
        var simpleProxy = new SimpleProxy("password");
        simpleProxy.DoWork();
    }
}