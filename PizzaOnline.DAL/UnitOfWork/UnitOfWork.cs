﻿using PizzaOnline.DAL.Interface;
using PizzaOnline.DAL.Interface.IRepository;
using System;

namespace PizzaOnline.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {       
        private readonly IDeliveryRepository _deliveryRepository;
        private readonly IIngredientsRepository _ingredientsRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IPizzaRepository _pizzaRepository;
        private readonly IPizzeriaRepository _pizzeriaRepository;
        private readonly IUserRepository _userRepository;

        public UnitOfWork(IDeliveryRepository deliveryRepository,
             IIngredientsRepository ingredientsRepository,
             IOrderRepository orderRepository,
             IPizzaRepository pizzaRepository,
             IPizzeriaRepository pizzeriaRepository, IUserRepository userRepository )
        {           
            _deliveryRepository = deliveryRepository;
            _ingredientsRepository = ingredientsRepository;
            _orderRepository = orderRepository;
            _pizzaRepository = pizzaRepository;
            _pizzeriaRepository = pizzeriaRepository;
            _userRepository = userRepository;
        }        
        public IDeliveryRepository DeliveryRepository
        {
            get
            {
                return _deliveryRepository;
            }
        }
        public IIngredientsRepository IngredientsRepository
        {
            get
            {
                return _ingredientsRepository;
            }
        }
        public IOrderRepository OrderRepository
        {
            get
            {
                return _orderRepository;
            }
        }
        public IPizzaRepository PizzaRepository
        {
            get
            {
                return _pizzaRepository;
            }
        }
        public IPizzeriaRepository PizzeriaRepository
        {
            get
            {
                return _pizzeriaRepository;
            }
        }
        public IUserRepository UserRepository
        {
            get
            {
                return _userRepository;
            }
        }
        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
