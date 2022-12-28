using sistemaDeCelular.Classes;

Console.WriteLine("Qual celular vocÊ deseja utilizar? Nokia/Iphone");
string esc = Console.ReadLine();

if (esc == "Nokia"){
    Console.WriteLine("\r\nDigite: IMEI, MODELO, NUMERO, MEMÓRIA");
    Nokia n1 = new Nokia(Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Convert.ToInt32(Console.ReadLine()));
    n1.AplicativosNokia.Add("Zapzap");
    n1.AplicativosNokia.Add("Youtube");
    n1.AplicativosNokia.Add("Facebook");
    Console.WriteLine("O que você deseja fazer? \r\n1 - Ligar para alguém. \r\n2 - Receber ligação.\r\n3 - Instalar aplicativos. \r\n4 - Listar aplicativos instalados.");
    int escolha = Convert.ToInt32(Console.ReadLine());
    switch(escolha){
        case 1: n1.Ligar(); break;
        case 2: n1.Receber(); break;
        case 3: n1.InstalarAplicativos(); break;
        case 4: n1.ListarAplicativosInstalados(n1.AplicativosInstalados); break;
    }
}
else if (esc == "Iphone"){
    Console.WriteLine("\r\nDigite: IMEI, MODELO, NUMERO, MEMÓRIA");
    Iphone i1 = new Iphone(Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Convert.ToInt32(Console.ReadLine()));
    i1.AplicativosIphone.Add("Itunes");
    i1.AplicativosIphone.Add("Safari");
    i1.AplicativosIphone.Add("Appstore");
    Console.WriteLine("O que você deseja fazer? \r\n1 - Ligar para alguém. \r\n2 - Receber ligação.\r\n3 - Instalar aplicativos. \r\n4 - Listar aplicativos instalados.");
    int escolha = Convert.ToInt32(Console.ReadLine());
    switch(escolha){
        case 1: i1.Ligar(); break;
        case 2: i1.Receber(); break;
        case 3: i1.InstalarAplicativos(); break;
        case 4: i1.ListarAplicativosInstalados(i1.AplicativosInstalados); break;
}
}



else{Console.WriteLine("Escolha uma opção válida!");}

