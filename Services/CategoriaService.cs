﻿using Microsoft.EntityFrameworkCore;
using MipequeniaTienda.Data;
using MipequeniaTienda.Models;

namespace MipequeniaTienda.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ApplicationDbContext _context;

        public CategoriaService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Categoria>> GetCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }
    }
}
