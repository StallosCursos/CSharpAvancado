﻿using System;

namespace SRP___AplicandoPrincipio.Manutencao
{
    public class Backup : ITempoExecucao
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
