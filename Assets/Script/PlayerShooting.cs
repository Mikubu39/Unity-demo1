
using UnityEngine;

public class PlayerShotting : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public float shootingInterval;
    private float lastBulletTime;
    public Vector3 bulletOffset;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            UpdateFiring();
        }
    }
    private void UpdateFiring()
    {
        if (Time.time - lastBulletTime >
            shootingInterval)
        {
            ShootBullet();
            lastBulletTime = Time.time;
        }
    }

    private void ShootBullet()
    {
        Instantiate(bulletPrefabs, transform.position + bulletOffset, transform.rotation);
    }
}


