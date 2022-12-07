using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Interface
{
    public interface IClinicaService : IDisposable
    {
        Task Adicionar(Clinica clinica);
        Task Atualizar(Clinica clinica);
        Task Remover(string id);
    }
}
