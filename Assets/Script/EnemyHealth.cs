using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefabs;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }
    private void Die()
    {
        var expolsion = Instantiate(explosionPrefabs, transform.position, transform.rotation);
        Destroy(expolsion, 1);
        Destroy(gameObject);
    }
}
