namespace MyApp // Note: actual namespace depends on the project name.
{
    public class InteriorOfficeProxy : IServiceMachine
    {
        private InteriorOffice interiorOffice;

        public InteriorOfficeProxy(InteriorOffice interiorOffice)
        {
            this.interiorOffice = interiorOffice;
        }

        public void ChangePhone()
        {
            interiorOffice.ChangePhone();
        }

        public void ChangeName()
        {
            interiorOffice.ChangeName();
        }
    }
}