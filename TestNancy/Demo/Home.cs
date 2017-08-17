using Nancy;
using Nancy.ModelBinding;

namespace TestNancy
{
    public class Home : NancyModule
    {
        public Home()
        {
            Get["/"] = _ => "Hello Plank";
            Get["/{name}"] = parameters => "Hi " + parameters.name;
            Post["/person"] = _ => 
            {
                var person = this.Bind<Person>();
                return Response.AsJson(new Message("Happy Birthday " + person.Name));
            };
        }
    }
}
