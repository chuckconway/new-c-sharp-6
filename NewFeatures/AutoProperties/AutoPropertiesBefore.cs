namespace CSharp6.NewFeatures.AutoProperties
{
    public class AutoPropertiesBefore
    {
        public AutoPropertiesBefore()
        {
            LastName = "Doe";
            FirstName = "John";
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
