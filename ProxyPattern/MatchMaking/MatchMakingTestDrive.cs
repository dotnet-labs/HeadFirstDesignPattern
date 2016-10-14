using ProxyPattern.MatchMaking.ProxyHandler;
using System;

namespace ProxyPattern.MatchMaking
{
    public class MatchMakingTestDrive
    {
        public static void Run()
        {
            Console.WriteLine();
            IPersonBean foo = new PersonBean { Name = "Joe", Gender = "Male", Interests = "Skiing" };
            foo.SetHotOrNotRating(9);
            IPersonBean bar = new PersonBean { Name = "Blow", Gender = "Unknown", Interests = "Farting around" };
            bar.SetHotOrNotRating(1);

            var ownerProxy = OwnerInvocationHandler.Create(foo);

            Console.WriteLine("Name is " + ownerProxy.Name);
            Console.WriteLine("Interests were " + ownerProxy.Interests);
            ownerProxy.Interests = "Mountain Climbing";
            Console.WriteLine("Interests set from owner proxy. They are now " + ownerProxy.Interests);
            try
            {
                ownerProxy.SetHotOrNotRating(10);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Rating is " + ownerProxy.GetHotOrNotRating());

            var nonOwnerProxy = NonOwnerInvocationHandler.Create(bar);

            Console.WriteLine("Name is " + nonOwnerProxy.Name);
            Console.WriteLine("Interests were " + nonOwnerProxy.Interests);
            try
            {
                nonOwnerProxy.Interests = "Mountain Climbing";
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Rating is " + nonOwnerProxy.GetHotOrNotRating());
            nonOwnerProxy.SetHotOrNotRating(10);
            Console.WriteLine("Rating is now " + nonOwnerProxy.GetHotOrNotRating());
        }
    }
}
