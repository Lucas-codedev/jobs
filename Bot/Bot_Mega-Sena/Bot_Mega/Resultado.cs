using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Bot_Mega
{
    public class Resultado
    {
        public string proximoConcurso { get; set; }
        public string concursoAnterior { get; set; }
        public object forward { get; set; }
        public IList<object> mensagens { get; set; }
        public long concurso { get; set; }
        public long data { get; set; }
        public string resultado { get; set; }
        public long ganhadores { get; set; }
        public long ganhadores_quina { get; set; }
        public long ganhadores_quadra { get; set; }
        public long valor { get; set; }
        public double valor_quina { get; set; }
        public double valor_quadra { get; set; }
        public long acumulado { get; set; }
        public double valor_acumulado { get; set; }
        public long dtinclusao { get; set; }
        public string prox_final_zero { get; set; }
        public double ac_final_zero { get; set; }
        public IList<object> proxConcursoFinal { get; set; }
        public IList<object> observacao { get; set; }
        public string rowguid { get; set; }
        public string ic_conferido { get; set; }
        public string de_local_sorteio { get; set; }
        public string no_cidade { get; set; }
        public string sg_uf { get; set; }
        public long vr_estimativa { get; set; }
        public double dt_proximo_concurso { get; set; }
        public double vr_acumulado_especial { get; set; }
        public double vr_arrecadado { get; set; }
        public bool ic_concurso_especial { get; set; }
        public bool error { get; set; }
        public bool rateioProcessamento { get; set; }
        public bool sorteioAcumulado { get; set; }
        public string concursoEspecial { get; set; }
        public IList<object> ganhadoresPorUf { get; set; }
        public string resultadoOrdenado { get; set; }
        public string dataStr { get; set; }
        public string dt_proximo_concursoStr { get; set; }
    }
}
