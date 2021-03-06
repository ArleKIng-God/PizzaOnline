﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PizzaOnline2.BLL.DTOEntities;

namespace PizzaOnline2.BLL.IServices
{
    public interface IIngredientsService 
    {
        Task<IEnumerable<DTOIngredients>> GetAllIngredients();
        Task<DTOIngredients> GetByIdIngredient(int id);
        Task InsertIngredient(DTOIngredients obj);
        Task UpdateIngredient(DTOIngredients obj);
        Task DeleteIngredient(int id);
        Task<DTOIngredients> GetIngredientsById(int Id);

    }
}
