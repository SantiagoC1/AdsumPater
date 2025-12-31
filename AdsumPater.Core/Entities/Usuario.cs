using System;
using AdsumPater.Core.Enums;

namespace AdsumPater.Core.Entities;

public class Usuario
{
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;

        public RolUsuario Rol { get; set; } = RolUsuario.Visitante; // se inicia en visitante por seguridad, luego se le agregan permisos
}
