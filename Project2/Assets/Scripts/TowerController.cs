using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    //variables to find target
    public Transform target;
    public float range = 15f;
    public string enemyTag = "Enemy";
    //variables to attack target
    public float fireRate = 2;
    private float fireCountdown = 0;
    public GameObject iceBullet;
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    void Update()
    {
        if(target == null)
        {
            return;
        }
        if(fireCountdown < 0)
        {
            Shoot();
            fireCountdown = 1/fireRate;
        }
        fireCountdown -= Time.deltaTime;

    }
    //finds distace to each enemy and calculates the sloset one
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach(GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if(distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if(nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }
    }
    //shoot function
    void Shoot()
    {
        GameObject bulletGO = Instantiate(iceBullet, transform.position, transform.rotation);
        BulletController bullet = bulletGO.GetComponent<BulletController>();
        if(bullet != null)
        {
            bullet.Seek(target);
        }
    }

    //draw range circle when turret is selected
    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}