using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    private int life; 
    private bool dead;

    private void Start()
    {
        life = hearts.Length;
    }

    void Update()
    {
        if (dead = true)
        {
            //Game over
        }
    }

    public void Damage(int damage) // Damage function
    {
        if (life >=1)
        {
            life -= damage;
            Destroy(hearts[life].gameObject);
            if (life < 1)
            {
                dead = true; 
            }
        }
        
    }
}
