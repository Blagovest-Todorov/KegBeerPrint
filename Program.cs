using System;

namespace PrintModelKegBeer
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            float currVolumeKeg = 0.0F;
            float maxValume = float.MinValue;
            string biggestKeg = string.Empty;
           

            for (int i = 1; i <= nLines; i++)
            {
                string modelKeg = Console.ReadLine();
                float radiusKeg = float.Parse(Console.ReadLine());
                int heightKeg = int.Parse(Console.ReadLine());
                currVolumeKeg = (float)(radiusKeg * heightKeg * Math.PI);

                if (currVolumeKeg > maxValume)
                {
                    maxValume = currVolumeKeg;
                    biggestKeg = modelKeg;
                   
                }               
            }
                Console.WriteLine(biggestKeg);
                
            
            
        }
    }
}
