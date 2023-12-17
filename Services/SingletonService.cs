namespace TestDependencyInjection.Services
{
    public class ScopedService : IScopedService
    {
       
       public string  Time { get; set; }

        public ScopedService()
        {
            Time = DateTime.Now.ToString("HH:mm:ss.ffffff");        
        }
        

    }
}
