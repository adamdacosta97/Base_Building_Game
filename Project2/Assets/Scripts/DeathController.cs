using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour
{
    public int health;
    public int bounty;

    //kill the enemy and add money
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            health -= 1;
        }
    }
    void Update()
    {
        if(health == 0)
        {
            PlayerStats.Money += bounty;
            Destroy(this);
        }
    }
}
