using PatronProxy.Proxies;

APIProxy proxy = new APIProxy();
proxy.UserName = "leslie";
string result = proxy.Request("/home");
Console.WriteLine(result);
