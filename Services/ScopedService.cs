namespace TestDependencyInjection.Services
{
    public class SingletonService : ISingletonService
    {
       
       public string  Time { get; set; }

        public SingletonService()
        {
            Time = DateTime.Now.ToString("HH:mm:ss.ffffff");        
        }
        

    }
}
