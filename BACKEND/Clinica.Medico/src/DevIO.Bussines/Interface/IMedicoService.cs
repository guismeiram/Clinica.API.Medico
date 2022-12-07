﻿using DevIO.Bussines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Bussines.Interface
{
    public interface IMedicoService : IDisposable
    {
        Task<bool> Adicionar(Medico medico);
        Task<bool> Atualizar(Medico medico);
        Task<bool> Remover(String id);
    }
}
