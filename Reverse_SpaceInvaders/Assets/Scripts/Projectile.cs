using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;

    private Transform player;
    private Vector2 target;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector2(player.position.x, player.position.y);
        
    }

   
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime); // projectile movement
        if(transform.position.x == target.x && transform.position.y == target.y) // if projectile misses it destroys itsel
        {
            DestoryProjectile();
        }
    }

    
    
  

    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.CompareTag("Player"))
        {
            HealthManager healthManager = other.GetComponent<HealthManager>();
            if (healthManager != null )
            {
                healthManager.TakeDamage(1);
            }

            DestoryProjectile();
        }

      
    }

    void DestoryProjectile()
    {
        Destroy(gameObject);
    }
}
