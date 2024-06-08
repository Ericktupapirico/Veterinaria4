using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria4
{
    public class VeterinarioService
    {
        private List<Veterinario> _clientes = new List<Veterinario>();

        public void AddVeterinario(Veterinario veterinario)
        {
            _clientes.Add(veterinario);
        }

    }
    public class MascotaService
    {
        private List<Mascota> _mascotas = new List<Mascota>();

        public void addCliente(Mascota mascotas)
        {
            _mascotas.Add(mascotas);
        }
    }
    public class ConsultaService
    {
        private List<Consulta> _consultas = new List<Consulta>();

        public void addConsulta(Consulta consultas)
        {
            _consultas.Add(consultas);
        }
    }
   
    
    public class VacunasService
    {
        private List<Vacunas> _vacunas = new List<Vacunas>();

        public void addVacunas(Vacunas vacunas)
        {
            _vacunas.Add(vacunas);
        }
    }
    public class ClienteService
    {
        private List<Cliente> _clientesService = new List<Cliente>();

        public void addClientes(Cliente cliente)
        {
            _clientesService.Add(cliente);
        }
    }

}