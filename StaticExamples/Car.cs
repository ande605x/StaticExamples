namespace StaticExamples
{
    public class Car
    {
        private string _licensePlate;
        private int _price;

        private static int ObjectCount = 0;
        private static int NumGetLicensePlate = 0;
        private static int NumGetPrice = 0;



        public string LicensePlate
        {
            get { NumGetLicensePlate++; return _licensePlate; }
            set { _licensePlate = value; }
        }

        public int Price
        {
            get { NumGetPrice++; return _price; }
            set { _price = value; }
        }

        public Car(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price;
            ObjectCount++;
        }


        public static void PrintUsageStatistics()
        {
            System.Console.WriteLine("Number of carobjects: "+ObjectCount+"\nNumber of GetLicenseplate: "+NumGetLicensePlate+"\nNumber of GetPrice: "+NumGetPrice);

        }
    }
}