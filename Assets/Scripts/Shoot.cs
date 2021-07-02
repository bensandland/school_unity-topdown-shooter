using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public LineRenderer aimLine;
    public float bulletForce = 20f;

    void Update()
    {
        DrawAimLine();

        if (Input.GetButtonDown("Fire1"))
            FireBullet();
    }

    void DrawAimLine()
    {
        GameObject player = GameObject.Find("Player");
        Movement movementScript = player.GetComponent<Movement>();

        aimLine.SetPosition(0, transform.position);
        aimLine.SetPosition(1, transform.position + new Vector3(movementScript.aimDir.x, movementScript.aimDir.y, 0));
    }

    void FireBullet()
    {
        SoundController.PlaySound();
        GameObject bullet = Instantiate(bulletPrefab, transform.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
