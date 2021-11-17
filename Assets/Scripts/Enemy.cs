using UnityEngine;

namespace Asteroids
{
    public abstract class Enemy : MonoBehaviour
    {
        public static IEnemyFactory Factory;

        public Health Health { get;  protected set; }

        public static Asteroid CreateAsteroidEnemy(Health hp)
        {
            
            //Debug.Log("1");
            GameObject enemy = Resources.Load<GameObject>("Asteroid");
            Debug.Log("2");
            var enemy1 = (Asteroid) Instantiate(enemy); ;
            
            enemy1.Health = hp;

            return enemy1;
        }

        public void DependencyInjectHealth(Health hp)
        {
            Health = hp;
        }

    }
}
