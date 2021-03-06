using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public  class Health
    {
        public float Max { get; }
        public float Current { get; protected set; }

        public Health(float max, float current)
        {
            Max = max;
            Current = current;
        }

        public void ChangeCurrentHealth(float hp)
        {
            Current = hp;
        }
    }

}