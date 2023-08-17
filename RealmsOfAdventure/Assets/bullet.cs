using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float lifetime = 5f;

    public int damageAmount = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            PlayerLifeSystem playerLifeSystem = collision.gameObject.GetComponent<PlayerLifeSystem>();
            if (playerLifeSystem != null)
            {
                playerLifeSystem.TakeDamage(damageAmount);
            }
        }
        else
        {
            Destroy(gameObject, lifetime);
        }
    }
}
