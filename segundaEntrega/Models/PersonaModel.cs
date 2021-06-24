using System.ComponentModel;
using System.IO.Pipes;
using System.Data.Common;
using System.Security.AccessControl;
using System.Security.Permissions;
using System;
using Entidad;
using System.ComponentModel.DataAnnotations;

namespace segundaEntrega.Models
{
    public class PersonaInputModel{
        [Required (ErrorMessage = "La identificacion es requerida")]
        public string Identificacion {get;set;}
        [Required (ErrorMessage = "El nombre es requerido")]
        public string Nombres {get;set;}
        [Required (ErrorMessage = "El apellido es requerido")]
        public string Apellidos {get;set;}
        [Range (1, 100, ErrorMessage = "La edad debe estar en un rango de 0 a 100")]
        public int Edad {get;set;}
        public string Sexo {get;set;}
        [Required (ErrorMessage = "El telefono debe tener 10 digitos")]
        public string Telefono {get;set;}
        [Required (ErrorMessage = "El email es requerido")]
        public string Email {get;set;}
        [Required (ErrorMessage = "El estado civil es requerido")]
        public string EstadoCivil {get;set;}
        [Required (ErrorMessage = "El pais es requerido")]
        public string PaisProcedencia { get; set; }
        [Required (ErrorMessage = "El nivel educativo es requerido")]
        public string NivelEducativo { get; set; }
        [Required (ErrorMessage = "El NIT restaurante es requerido")]
        public string IdRestaurante { get; set; }
        public Usuario Usuario { get; set; }
    }
    
    public class PersonaViewModel : PersonaInputModel
    {
        public PersonaViewModel()
        {

        }
        public PersonaViewModel(Persona persona)
        {
            Identificacion = persona.Identificacion;
            Nombres = persona.Nombres;
            Apellidos = persona.Apellidos;
            Sexo = persona.Sexo;
            Edad = persona.Edad;
            Telefono = persona.Telefono;
            Email = persona.Email;
            EstadoCivil = persona.EstadoCivil;
            PaisProcedencia = persona.PaisProcedencia;
            NivelEducativo=persona.NivelEducativo;
            IdRestaurante = persona.Idrestaurante;
            
        }
    }
}