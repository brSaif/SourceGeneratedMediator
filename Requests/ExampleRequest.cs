namespace MediatorSGSample.Requests;

public class ExampleRequest : IHttpRequest
{
    public string Name { get; set; }
    public int Age { get; set; }
}