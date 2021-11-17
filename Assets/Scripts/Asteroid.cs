using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Asteroids
{
    public class Asteroid : Enemy
    {
        public static explicit operator Asteroid(GameObject v)
        {
            throw new NotImplementedException();
        }
    }
}