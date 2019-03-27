﻿using Data;
using System;

namespace BluffCityCaseDay06
{
    public sealed class RandomManager : SingletonBase<RandomManager>
    {
        public Random _Randy;

        private RandomManager()
        {
            _Randy = new Random();
        }
    }
}