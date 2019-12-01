using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform target;
    public float speed = 70;
    public GameObject impactEffect;
    //set target
    public void Seek(Transform _target)
    {
        target = _target;
    }
    void Update()
    {
        //id the target is destoryed, destroy the bullet
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;
        //when the bullet hits the target
        if(dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }
    void HitTarget()
    {
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(target.gameObject);
        PlayerStats.Money += 15;
    }
}
