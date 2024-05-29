﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public interface IAnimal
    {
        string AnimalName { get; set; }
        string Age { get; set; }
        string Species { get; set; }
        string MakeSound();
    }
}
