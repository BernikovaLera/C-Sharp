using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_pr1
{
    class ClassRechnie
    {
        public static Tuple<double, double> Sfera(double R)
        {
            double V = (4 * Math.PI * Math.Pow(R, 3)) / 3;
            double S = 4 * Math.PI * Math.Pow(R, 2);
            return new Tuple<double, double>(V, S);
        }
        public static Tuple<double, double, double, double> Konus(double R, double H)
        {
            double So = Math.PI * Math.Pow(R, 2);
            double Sb = Math.PI * R * Math.Sqrt(Math.Pow(R, 2) + Math.Pow(H, 2));
            double Sob = So + Sb;
            double V = (So * H) / 3;
            return new Tuple<double, double, double, double>(So, Sb, Sob, V);
        }
        public static Tuple<double, double, double, double> YsKonus(double R1, double R2, double H)
        {
            double S1 = Math.PI * Math.Pow(R1, 2);
            double S2 = Math.PI * Math.Pow(R2, 2);
            double Sboc = Math.PI * Math.Sqrt(Math.Pow((R2 - R1), 2) + Math.Pow(H, 2)) * (R2 + R1);
            double V = (Math.PI / 3) * H * (Math.Pow(R2, 2) + R2 * R1 + Math.Pow(R1, 2));
            return new Tuple<double, double, double, double>(S1, S2, Sboc, V);
        }
        public static Tuple<double, double, double, double> Celinder(double R, double H)
        {
            double Socn = Math.PI * Math.Pow(R, 2);
            double Sboc = 2 * Math.PI * R * H;
            double Sob = Socn + Sboc;
            double V = Math.PI * Math.Pow(R, 2) * H;
            return new Tuple<double, double, double, double>(Socn, Sboc, Sob, V);
        }


    }
}
