﻿using EstacionamientoMVC.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamientoMVC.Models
{
    public class Telefono
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]        
        public int CodArea { get; set; }
        
        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [DataType(DataType.PhoneNumber)]
        public string Numero { get; set; }

        public bool Principal { get; set; }

        [Required(ErrorMessage = ErrMsgs.Requerido)]
        public TipoTelefono Tipo { get; set; }

        
        [Required(ErrorMessage = ErrMsgs.Requerido)]
        [Display(Name = Alias.PersonaId)]
        public int PersonaId { get; set; } 

        public Persona Persona { get; set; }

        [NotMapped]
        public string NumeroCompleto { get { return $"({CodArea}) - {Numero}"; } }
    }
}
