using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;

    private float movementX;

    private Rigidbody2D myBody;

    private void Awake()
    {
        myBody= GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMoveKeyboard();
    }

    private void FixedUpdate()
    {
        jump();
    }

    void playerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
    }

    void jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            myBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }
}
