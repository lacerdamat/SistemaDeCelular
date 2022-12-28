using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDeCelular.Classes
{
    public class Nokia : Celular
    {
        public Nokia (string imei, string numero, string modelo, int memoria)
        {
            IMEI = imei;
            Numero = numero;
            Modelo = modelo;
            Memoria = memoria;            
        }
        public List<string> AplicativosNokia = new List<string>();
        public List<string> AplicativosInstalados = new List<string>();
        public override void InstalarAplicativos(){
            int count = 0;
            Console.WriteLine("Aplicativos disponíveis");
            foreach(string s in AplicativosNokia){
                Console.WriteLine(count+1 + " - " + s);
                count++;
            }
            Console.WriteLine("Deseja baixar um desses ou adicionar um novo? s/n");
            string esc = Console.ReadLine();
            if (esc == "s"){
                Console.WriteLine("Qual?");
                int escAPP = Convert.ToInt32(Console.ReadLine());
                AplicativosInstalados.Add(AplicativosNokia[escAPP-1]);
            }
            else{
                Console.WriteLine("Qual é o nome do aplicativo que você deseja adicionar?");
                string newAPP = Console.ReadLine();
                AplicativosNokia.Add(newAPP);
                AplicativosInstalados.Add(newAPP);
            }
        }
        public override void ListarAplicativosInstalados(List<string> appIns){
            int count = 0;
            foreach(string s in appIns){
                Console.WriteLine(count+1 + " - " + s);
                count++;
            }
            
        }
        
        
    }
}