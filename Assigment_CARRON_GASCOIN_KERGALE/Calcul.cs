using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Assigment_CARRON_GASCOIN_KERGALE
{
    class Calcul
    {
        public Calcul()
        {

        }
        public double moment_rectangle(double largeur, double epaisseur){
            //formule du moment
            return ((largeur*epaisseur *(Math.Pow(largeur,2) + Math.Pow(epaisseur,2)/12)));
        }
        public double moment_circulaire(double diametre)
            //formule du moment
        {
            return (3.141592* Math.Pow(diametre,4)/32);
        }

        public double fleche (double force, double longueur, int E, double moment)
            //formule de la fleche
        {
            return (-(force * Math.Pow(longueur, 3)) / (3 * E * moment));
        }
    }
   

    
}
