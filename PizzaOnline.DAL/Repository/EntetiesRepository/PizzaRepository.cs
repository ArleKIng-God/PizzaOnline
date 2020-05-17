﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaOnline.DAL.Entities;
using PizzaOnline.DAL.Helpers;
using PizzaOnline.DAL.Interface.IRepository;
using PizzaOnline.DAL.Models;
using PizzaOnline.DAL.Repository.GenericRepository;

namespace PizzaOnline.DAL.Repository.EntetiesRepository
{
    public class PizzaRepository : GenericRepository<Pizza>, IPizzaRepository
    {
        private readonly ISortHelper<Pizza> _sortHelper;
        public PizzaRepository(AplicationContext _context, ISortHelper<Pizza> sortHelper)
            : base(_context)
        {
            _sortHelper = sortHelper;
        }
        public async Task<Pizza> GetPizzaId(int id)
        {
            var res = await _context.Pizza
               .Include(i => i.Orders)
               .Include(i => i.Ingredients)               
               .Where(j => j.Id == id)
               .FirstOrDefaultAsync();
            return res;
        }

        public IEnumerable<Pizza> GetPizza(PizzaQueryParameters parameters)
        {
            return GetAll().Skip((parameters.PageNumber - 1) * parameters.PageSize)
                .Take(parameters.PageSize)
                .ToList();
            //var pizza = FindByCondition(x => x.Price >= parameters.MinPrice && x.Price <= parameters.MaxPrice);

            //SearchByBrand(ref pizza, parameters.NamePizza);

            //pizza = _sortHelper.ApplySort(pizza, parameters);

            //return  PagedList<Pizza>.ToPagedList(pizza, parameters.PageNumber, parameters.PageSize);         
        }

        private void SearchByBrand(ref IQueryable<Pizza> pizza, string NamePizza)
        {
            if (!pizza.Any() || string.IsNullOrWhiteSpace(NamePizza))
                return;

            pizza = pizza.Where(x => x.NamePizza.ToLower().Contains(NamePizza.Trim().ToLower()));
        }
        //public async Task<IEnumerable<Pizza>> GetPizzaPriceRange(int maxPrice, int minPrice)
        //{
        //    var res = _context.Pizza.Where(x => x.Price >= minPrice && x.Price <= maxPrice);
        //    return res;
        //}
        //public async Task<IEnumerable<Pizza>> GetPizzaName(string namepizza)
        //{
        //    var res = _context.Pizza.Where(x => x.NamePizza == namepizza);
        //    return res;
        //}
        //public async Task<IEnumerable<Pizza>> GetPopular()
        //{
        //    var res1 = _context.Pizza
        //        .OrderByDescending(e => e.Orders.Count());
        //    return res1;
        //}
        //public async Task<IEnumerable<Pizza>> GetPopularIngredients()
        //{
        //    var res1 = _context.Pizza
        //        .OrderByDescending(e => e.Ingredients.Count());
        //    return res1;
        //}
    }
}
