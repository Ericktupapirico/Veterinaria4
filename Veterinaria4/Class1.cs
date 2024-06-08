using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria4;

namespace Veterinaria4
{
    public class Informacion
    {

        public string Nombre { get; set; }
        public string Id { get;  set; }
        public string Numeros { get;  set; }
        public string Direccion { get;  set; }
        public string Nombre_Mascota { get;  set; }
        public string Id_Mascota { get;  set; }
        public Informacion(string Nombre, string Id, string Numeros, string Direccion, string Nombre_Mascota, string Id_Mascota)
        {
            this.Nombre = Nombre;
            this.Id = Id;
            this.Numeros = Numeros;
            this.Direccion = Direccion;
            this.Nombre_Mascota = Nombre_Mascota;
            this.Id_Mascota = Id_Mascota;
        }

    }
}
public class Cliente : Informacion
{
    public string Mascota { get;  set; }
    public Cliente(string Nombre, string Id, string Numeros, string Direccion) : base(Nombre, Id, Numeros, Direccion,null, null)
    {

    }

}
public class Mascota : Informacion
{
    public string Peso { get;  set; }
    public string Raza { get;  set; }
    public string Genero { get; set; }
    public string Especie { get;  set; }
    public string fecha_Registro { get;  set; }
    public string edad_Mascota { get;  set; }
    public string Enfermedades { get; private set; }
    public Mascota(string Nombre_Mascota, string Nombre, string Id, string Direccion, string Numeros, string Peso, string Raza, string Genero,
       string Especie, string fecha_Registro, string edad_Mascota, string Enfermedades) : base(Nombre, Numeros, Id, Direccion, Nombre_Mascota, Direccion)
    {
        this.Peso = Peso;
        this.Raza = Raza;
        this.Genero = Genero;
        this.Especie = Especie;
        this.fecha_Registro = fecha_Registro;
        this.edad_Mascota = edad_Mascota;
        this.Enfermedades = Enfermedades;
    }
}
public class Consulta
{
    private string razon_Consulta { get; set; }
    private string fecha_Consulta { get; set; }
    public Consulta(string razon_Consulta, string fecha_Consulta)
    {
        this.razon_Consulta = razon_Consulta;
        this.fecha_Consulta = fecha_Consulta;
    }
}
public class Veterinario : Informacion
{
    public string Contraseña { get;  set; }
    public Veterinario(String Nombre, String Contraseña) : base(Nombre, null, null, null, null, null)
    {
        this.Contraseña = Contraseña;
    }
}

public class Vacunas
{
    public string tipo_Vacuna { get;  set; }
    public string Dosis { get;  set; }
    public string Admnistradas { get;  set; }
    public Vacunas(String Nombre, String Contraseña)
    {
        this.tipo_Vacuna = tipo_Vacuna;
        this.Dosis = Dosis;
    }
}
    

