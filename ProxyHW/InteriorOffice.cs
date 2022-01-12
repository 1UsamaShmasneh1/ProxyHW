namespace MyApp // Note: actual namespace depends on the project name.
{
    public class InteriorOffice : IInteriorOffice, IServiceMachine
    {

        public void PassportIssuance()
        {
            Console.WriteLine("Pay for it");
        }
        public void RegistrationNewId()
        {
            Console.WriteLine("Welcome");
        }

        public void ChangePhone()
        {
            Console.WriteLine("Changed");
        }

        public void ChangeName()
        {
            Console.WriteLine("Changed");
        }
    }
}