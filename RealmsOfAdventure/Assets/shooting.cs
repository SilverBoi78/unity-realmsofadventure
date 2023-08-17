using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletForce = 10f;
    public float shootingInterval = 3f;

    private bool canShoot = true;
    private Transform playerTransform; // Reference to the player's transform

    // Function for shooting
    void Shoot(Vector3 targetPosition)
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        Vector2 direction = (targetPosition - transform.position).normalized;
        rb.AddForce(direction * bulletForce, ForceMode2D.Impulse);

        // Calculate the rotation angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotate the bullet to face the shooting direction
        bullet.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    // Coroutine for shooting at intervals
    IEnumerator ShootingCoroutine()
    {
        while (true)
        {
            if (canShoot && playerTransform != null)
            {
                Shoot(playerTransform.position);
                canShoot = false;
                yield return new WaitForSeconds(shootingInterval);
                canShoot = true;
            }
            yield return null;
        }
    }

    // Start the shooting coroutine
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform; // Assuming "Player" has the tag assigned
        StartCoroutine(ShootingCoroutine());
    }
}
