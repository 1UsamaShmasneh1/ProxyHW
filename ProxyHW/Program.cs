using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            InteriorOffice interiorOffice = new InteriorOffice();
            IServiceMachine interiorOfficeProxy = new InteriorOfficeProxy(interiorOffice);
                        
        }
    }
}