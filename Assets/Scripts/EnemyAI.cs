using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 0.8f;

    private Rigidbody2D body;
    private Player player;
    private Vector3 dirToPlayer;

    private void Start()
    {
        GameObject[] edgeWalls = GameObject.FindGameObjectsWithTag("NoEnemyCollision");

        for (int i = 0; i < edgeWalls.Length; i++)
        {
            Physics2D.IgnoreCollision(edgeWalls[i].GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        
        body = GetComponent<Rigidbody2D>();
        player = FindObjectOfType(typeof(Player)) as Player;
    }

    private void FixedUpdate()
    {
        dirToPlayer = (player.transform.position - transform.position).normalized;
        body.velocity = new Vector2(dirToPlayer.x, dirToPlayer.y) * moveSpeed;
    }
}
