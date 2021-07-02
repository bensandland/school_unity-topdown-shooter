using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitReg : MonoBehaviour
{
    public int maxHp = 10;
    public int hp;
    public HealthBar healthBar;

    private void Start()
    {
        hp = maxHp;
        healthBar.UpdateHealth(hp, maxHp);
    }

    public void DamageTaken(int dmg)
    {
        hp -= dmg;
        healthBar.UpdateHealth(hp, maxHp);

        if (hp <= 0)
        {
            PointScript.instance.AddPoints(100);
            Destroy(gameObject);
        }
    }
}
