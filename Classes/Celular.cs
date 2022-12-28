using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaDeCelular.Classes
{
    public abstract class Celular
    {
        
        public string IMEI { get; set; }
        public int Memoria { get; set; }
        public string Modelo { get; set; }
        public string Numero { get; set; }

        public void Ligar(){
            Console.WriteLine("Você ligou..... mas nínguem atendeu.");
        }
        public void Receber(){
            Console.WriteLine("Deseja atender esta ligação? s/n");
            string escolha = Console.ReadLine();
            if (escolha == "s"){
                Console.WriteLine("Você atendeu a ligação.... mas ninguém respondeu.");
            }
            else{
                Console.WriteLine("Você não atendeu a ligação.... fez bem.");
            }
        }
        public abstract void InstalarAplicativos();
        public abstract void ListarAplicativosInstalados(List<string> appIns);
        
    }
}