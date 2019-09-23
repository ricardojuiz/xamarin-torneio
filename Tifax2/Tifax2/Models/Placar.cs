﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TIFA.Models
{
    public class Placar
    {

        public Placar()
        {
            Id = Guid.NewGuid().ToString();
            Data = DateTime.Now.Date;
            DataPublicacao = DateTime.Now;
        }

        public string Id { get; set; }

        public DateTime Data { get; set; }

        public Jogador JogadorA { get; set; }

        public int? JogadorAGols { get; set; }

        public Jogador JogadorB { get; set; }

        public int? JogadorBGols { get; set; }

        public DateTime DataPublicacao { get; set; }


    }
}
