namespace TheSixthProgram2._1
{
    internal class CatalogOfPlanets
    {
        private List<Planet> listOfPlanets = new List<Planet>();

        public CatalogOfPlanets(params Planet[] planets)
        {
            listOfPlanets.AddRange(planets);
        }

        //Счетчик запросов.
        int i = 0;
        public Tuple<int, int, string> ToGetAplanet(string name)
        {
            i++;
            var r1 = listOfPlanets.FirstOrDefault(m => m.SerialNumberFromTheSun == 0 && m.LengthOfEquator == 0 && m.Name == name);
            var r2 = listOfPlanets.Select(m => m.Name).Contains(name);
            if (i == 3)
            {
                i = 0;
                var result = Tuple.Create(0,0,"Вы спрашиваете слишком часто!");
                return result;
            }
            if (r1 != null || !r2)
            {
                var result = Tuple.Create(0, 0, "Планета не найдена!");
                return result;
            }
            else
            {
                var result = from m in listOfPlanets where m.Name == name select new Tuple<int, int, string>(m.SerialNumberFromTheSun, m.LengthOfEquator, m.Name);
                return result.FirstOrDefault();
            }
        }
    }
}
