namespace TheSixthProgram2._1
{
    public class Planet
    {
        public string Name{ get;set;}
        public int SerialNumberFromTheSun{ get;set;}
        public int LengthOfEquator{get;set;}
        public Planet PreviousPlanet{get; set;}

        public Planet(string name, int serialNumberFromTheSun, int lenghtOfEquator, Planet obj = null)
        {
            Name = name;
            SerialNumberFromTheSun = serialNumberFromTheSun;
            LengthOfEquator = lenghtOfEquator;
            PreviousPlanet = obj;
        }
    }
}
