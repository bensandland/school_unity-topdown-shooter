using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float playerSpeed = 6f;
    public Rigidbody2D body;
    public Camera cam;
    public Vector2 aimDir;

    Vector2 posChange;
    Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        transform.position = new Vector3(0, 0, 0);
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        posChange.x = playerSpeed * Input.GetAxis("Horizontal");
        posChange.y = playerSpeed * Input.GetAxis("Vertical");

        // convert to pixel coords from ingame units (screenPoint -> worldPoint)
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        body.MovePosition(body.position + posChange * playerSpeed * Time.fixedDeltaTime);

        aimDir = mousePos - body.position;
        float angle = Mathf.Atan2(aimDir.y, aimDir.x) * Mathf.Rad2Deg - 90f;
        body.rotation = angle;
    }
}
