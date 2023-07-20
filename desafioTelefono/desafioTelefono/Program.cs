using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioTelefono
{
    class Program
    {
        static void Main(string[] args)
        {
            telefono t1 = new telefono("a3", "samsung");
            telefono t2 = new telefono();
             
            Console.WriteLine("este telefono es modelo: "+ t1.model + ", marca: " + t1.marc);
            Console.WriteLine("ingrese su nuevo numero de telefono");
            t1.numTel = Console.ReadLine();

            Console.WriteLine("su nuevo numero telefonico es: " + t1.numTel);
            Console.WriteLine("ingrese que desea hacer:");
            Console.WriteLine("1 - llamar a un contacto");
            Console.WriteLine("2 - cargar credito");
            Console.WriteLine("3 - apagar");
            t1.codOpe = int.Parse(Console.ReadLine());

            if (t1.codOpe == 1)
            {
                Console.WriteLine("a quien desea llamar?");
                t1.contact = Console.ReadLine();
                Console.WriteLine(t1.llamar(t1.contact));
            }

            else if (t1.codOpe == 2)
            {
                Console.WriteLine("su saldo es de: " + t1.credit);
                Console.WriteLine("ingrese el monto a cargar");
                t1.credit = int.Parse(Console.ReadLine());
                Console.WriteLine(t1.recargar(t1.credit));
                Console.WriteLine("ahora su saldo actual es de: " + t1.credit);
            }

            else if (t1.codOpe==3)
            {
                Console.WriteLine("vuelva pronto");
            }

            Console.ReadKey();
        }

        
    }
}
