using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialEjerEnsaladadeFrutas2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alimento2 FrutasDulces = new Frutas("Banana");
            Alimento2 FrutasAcidas = new Frutas("Piña");
            Alimento2 HeladodeLeche = new Helado2("Sabor Arequipe");
            Alimento2 tipoCrema = new Cremas("Chantilli");

            FrutasDulces.fd();
            FrutasDulces.getNombreAlimentoFD();
            FrutasDulces.combinacion1();

            Console.WriteLine("\t");

            FrutasAcidas.fa();
            FrutasAcidas.getNombreAlimentoFA();
            FrutasAcidas.combinacion2();
            Console.ReadKey();
        }



        class Alimento2
        {
            public Alimento2(String nombreAlimento)
            {
                nombrefrutadulce = nombreAlimento;
                nombrefrutaacida = nombreAlimento;
                nombreheladoleche = nombreAlimento;
                nombretipocrema = nombreAlimento;
            }
            public void combinacion1()
            {
                Console.WriteLine("fruta dulce con helado de leche, con adicion de crema Chantilly");
            }

            public void combinacion2()
            {
                Console.WriteLine("fruta acida con helado de agua, con adicion de crema de leche");
            }

            public void fd()
            {
                Console.WriteLine("la Banana combina perfecto con el helado de crema sabor a arequipe con adicion de crema chantilli");
            }

            public void fa()
            {
                Console.WriteLine("la piña combina perfecto con el helado de agua");
            }
            public void getNombreAlimentoFD()
            {
                Console.WriteLine("el nombre de la fruta dulce es: " + nombrefrutadulce);
            }
            public void getNombreAlimentoFA()
            {
                Console.WriteLine("el nombre de la fruta Acida es: " + nombrefrutaacida);
            }


            public String nombrefrutadulce;
            private String nombrefrutaacida;
            private String nombreheladoleche;
            private String nombretipocrema;

        }
    


        
        class Frutas : Alimento2
        {
            public Frutas(String nombreFrutadulce) : base(nombreFrutadulce) 
            {

            }
          

        }

        class Cremas : Alimento2
        {
            public Cremas (String tipocrema): base(tipocrema)
            {

            }
        }

        class Helado2 : Alimento2 
        {
            public Helado2(String saborheladoleche) : base(saborheladoleche)
            {

            }

        }
        class verduras : Alimento2
        {
            public verduras(string nombreAlimento) : base(nombreAlimento)
            {
            }
        }

        class FrutasDulces : Frutas
        {
            public FrutasDulces(string nombreFrutadulce) : base(nombreFrutadulce)
            {

            }

            
        }
        class FrutasAcidas : Frutas
        {
            public FrutasAcidas(string nombreFrutadulce) : base(nombreFrutadulce)
            {
            }
        }

        class Helado2deLeche : Helado2
        {
            public Helado2deLeche(string saborheladoleche) : base(saborheladoleche)
            {
            }
        }

        class Helado2deAgua : Helado2
        {
            public Helado2deAgua(string saborheladoleche) : base(saborheladoleche)
            {
            }
            
        }

    }
}
