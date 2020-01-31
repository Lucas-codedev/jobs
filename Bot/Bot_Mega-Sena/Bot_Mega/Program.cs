using Newtonsoft.Json;
using System;
using System.Net;

namespace Bot_Mega
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informa o numero do concurso:");
            string NumeroDoConcurso = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(NumeroDoConcurso))
            {
                NumeroDoConcurso = "2229";
            }

            string url = @"http://loterias.caixa.gov.br/wps/portal/loterias/landing/megasena/!ut/p/a1/04_Sj9CPykssy0xPLMnMz0vMAfGjzOLNDH0MPAzcDbwMPI0sDBxNXAOMwrzCjA0sjIEKIoEKnN0dPUzMfQwMDEwsjAw8XZw8XMwtfQ0MPM2I02-AAzgaENIfrh-FqsQ9wNnUwNHfxcnSwBgIDUyhCvA5EawAjxsKckMjDDI9FQE-F4ca/dl5/d5/L2dBISEvZ0FBIS9nQSEh/pw/Z7_HGK818G0KO6H80AU71KG7J0072/res/id=buscaResultado/c=cacheLevelPage/=/?timestampAjax=1580403809220&concurso=" + NumeroDoConcurso;
            string json;

            using (WebClient wc = new WebClient())
            {
                wc.Headers["Cookie"] = "security=true";
                json = wc.DownloadString(url);
            }

            Resultado resultadoDaMegaSena = JsonConvert.DeserializeObject<Resultado>(json);
            Console.WriteLine("Concueso selecionado: " + NumeroDoConcurso);

            Console.WriteLine(" ");
            Console.WriteLine("Resultado");
            Console.WriteLine("----------------------");
            Console.WriteLine(resultadoDaMegaSena.resultadoOrdenado);
            Console.WriteLine("Data do Concurso: " + resultadoDaMegaSena.dataStr);


            Console.ReadKey();
        }
    }
}
