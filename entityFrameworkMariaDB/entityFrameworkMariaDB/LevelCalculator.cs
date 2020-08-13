using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityFrameworkMariaDB
{
    public static class LevelCalculator
    {



        public static int Equate(double xp)
        {
            return (int)Math.Floor(
                xp + 300 * Math.Pow(2, xp / 7));
        }

        public static int LevelToXP(this int level)
        {
            double xp = 0;

            for (int i = 1; i < level; i++)
                xp += Equate(i);

            return (int)Math.Floor(xp / 4);
        }

        public static int XPToLevel(this int xp)
        {
            int level = 1;

            while (LevelToXP(level) < xp)
                level++;

            return level;
        }

    }
}
