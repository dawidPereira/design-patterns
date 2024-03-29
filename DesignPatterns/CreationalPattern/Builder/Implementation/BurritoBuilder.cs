﻿using System;
using DesignPatterns.CreationalPattern.Builder.Entity;
using DesignPatterns.CreationalPattern.Builder.Interface;

namespace DesignPatterns.CreationalPattern.Builder.Implementation
{
    public class BurritoBuilder : IBurritoBuilder
    {
        private readonly Burrito _burrito = new Burrito();

        public IBurritoBuilder WithCheese()
        {
            _burrito.Cheese = true;
            Console.WriteLine("Cheese was added.");
            return this;
        }

        public IBurritoBuilder WithMeat(string meat)
        {
            _burrito.Meat = meat;
            Console.WriteLine($"{meat} was added.");
            return this;
        }

        public IBurritoBuilder WithNachos()
        {
            _burrito.Nachos = true;
            Console.WriteLine("Nachos was added.");
            return this;
        }

        public Burrito Build(int spiciness)
        {
            SetSpiciness(spiciness);
            AddBasicIngredients();
            Console.WriteLine("Enjoy your meal!");
            return _burrito;
        }
        private IBurritoBuilder SetSpiciness(int spiciness)
        {
            _burrito.Spiciness = spiciness;
            Console.WriteLine($"Spiciness was set up on level {spiciness}.");
            return this;
        }

        private IBurritoBuilder AddBasicIngredients()
        {
            _burrito.BasicIngredient = true;
            Console.WriteLine("Basic ingredients was added.");
            return this;
        }
    }
}
