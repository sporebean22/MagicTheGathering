using System;

namespace MagicTheGathering.Models
{
    public class Effect
    {
        Func<HP, int, int> Burn = (healthPoints, burnvalue) => burnvalue - healthPoints.HealthPoints;



    }
}