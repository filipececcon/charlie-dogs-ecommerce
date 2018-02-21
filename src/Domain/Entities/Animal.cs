﻿using System;

namespace ChalieDogs.Ecommerce.Domain.Entities
{
    public class Animal : BaseEntity
    {
        public Animal()
        {
            AnimalSize = new AnimalSize();
        }

        public string Picture { get; set; }

        public decimal Price { get; set; }

        public int Age { get; set; }

        public AnimalSize AnimalSize { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Picture))
            {
                throw new Exception("Foto não informada");
            }

            if (Price < 0)
            {
                throw new Exception("Preço menor que zero");
            }

            if (Age < 0)
            {
                throw new Exception("Idade menor que zero");
            }

            AnimalSize.Validate();
        }
    }
}