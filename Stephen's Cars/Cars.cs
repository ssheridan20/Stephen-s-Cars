namespace Stephen_s_Cars
{
    internal class Cars
    {
        //started out with automatic properties
        public string CarType {  get; set; }
        public string CarName { get; set; }
        public double MPG {  get; set; }

        //default constructor - no parameters
        public Cars() 
        { 
            CarType = string.Empty;
            CarName = string.Empty;
            MPG = 0;
        }
        public Cars(string type, string name, double mpg)
        {
            CarType = type;
            CarName = name;
            MPG = mpg;
        }
    }
}
