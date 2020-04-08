﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.DAL.Entities;

namespace PizzaOnline2.BLL.IServices
{
    public interface IIngredientsService 
    {
        Task<IEnumerable<Ingredients>> GetAllIngredients();
        Task<Ingredients> GetByIdIngredient(int id);
        Task<Ingredients> InsertIngredient(Ingredients obj);
        void UpdateIngredient(Ingredients obj);
        Task<int> DeleteIngredient(Ingredients id);
    }
}