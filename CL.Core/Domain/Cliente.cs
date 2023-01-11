﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CL.Core.Domain
{
    
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}