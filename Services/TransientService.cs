﻿namespace TestDependencyInjection.Services
{
    public class TransientService : ITransientService
    {
       
       public string  Time { get; set; }

        public TransientService()
        {
            Time = DateTime.Now.ToString("HH:mm:ss.ffffff");        
        }
        

    }
}
