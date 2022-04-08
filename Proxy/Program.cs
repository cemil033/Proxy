using Proxy;
Client client = new Client();
RealSubject realSubject = new RealSubject();
client.ClientCode(realSubject);
Console.WriteLine();
Proxy.Proxy proxy = new Proxy.Proxy(realSubject);
client.ClientCode(proxy);
