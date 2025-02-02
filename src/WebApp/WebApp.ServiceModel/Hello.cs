using ServiceStack;

namespace WebApp.ServiceModel
{
    [Route("/hello")]
    [Route("/hello/{Name}")]
    [Authenticate]
    public class Hello : IReturn<HelloResponse>
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Result { get; set; }
    }
}
