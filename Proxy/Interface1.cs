using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface ISubject
    {
        void Request();
    }
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("I am Real Subject");
        }
    }
    public class Proxy : ISubject
    {
        private RealSubject _realSubject;
        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }
        public bool CheckAccess()
        {
            Console.WriteLine("Proxy Checking");
            return true;
        }
        public void LogAccess()
        {
            Console.WriteLine("Logging");
        }
        public void Request()
        {
            if (CheckAccess())
            {
                _realSubject.Request();
                LogAccess();
            }
        }
    }
    public class Client
    {
        public void ClientCode(ISubject subject)
        { 
            subject.Request();
        }
    }
}
