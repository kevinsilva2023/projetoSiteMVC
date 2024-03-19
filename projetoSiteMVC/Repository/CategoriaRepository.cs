﻿using projetoSiteMVC.Context;
using projetoSiteMVC.Models;
using projetoSiteMVC.Repository.Interfaces;

namespace projetoSiteMVC.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
