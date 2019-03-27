﻿using Data;
using System;

namespace BluffCityCaseDay10A
{
    public class RandomManager : SingletonBase<RandomManager>
    {
        public Random _Randy;

        private RandomManager()
        {
            _Randy = new Random();
        }
    }
}