using System;

namespace BuisnessLayer
{
    public class CalcularTasa
    {
        public double CalcularPres(int TipoPrestamo, int CantMeses, double ValorUser)
        {
            double ValorConvert = 0;
              
            switch (TipoPrestamo)
            {
                case (int)enumTipPres.Personal:


                    for (int v = CantMeses; v == CantMeses; v += 6)
                    {
                        double tasa = ValorUser * 0.22;
                        ValorUser = tasa + ValorUser;
                        ValorConvert = ValorUser / CantMeses;
                    }





                    break;
                case (int)enumTipPres.Automóvil:
                    for (int v = CantMeses; v == CantMeses; v += 6)
                    {
                        double tasa = ValorUser * 0.12;
                        ValorUser = tasa + ValorUser;
                        ValorConvert = ValorUser / CantMeses;
                    }
                    break;
                case (int)enumTipPres.Hipotecario:
                    for (int v = CantMeses; v == CantMeses; v += 6)
                    {
                        double tasa = ValorUser * 0.08;
                        ValorConvert = tasa + ValorUser;
                        ValorConvert = ValorUser / CantMeses;
                    }
                    break;
                default:
                    return ValorConvert;
            }



            return ValorConvert;
        }
        
    }
}
