﻿namespace TorneioDeLutaMVC.Models
{
    public class Lutador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int ArtesMarciais { get; set; }
        public int TotalLutas { get; set; }
        public int Derrotas { get; set; }
        public int Vitorias { get; set; }
    }

}
