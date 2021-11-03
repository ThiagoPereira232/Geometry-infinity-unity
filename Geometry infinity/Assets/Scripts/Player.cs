using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpForce;

    private Rigidbody2D rig;
    private bool isJumping;
    [SerializeField]
    private bool isModeInfinity;

    [SerializeField]
    private string scene;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isModeInfinity)
        {
            rig.velocity = new Vector2(speed, rig.velocity.y);
        }

        if((Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump")) && !isJumping)
        {
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 8)
        {
            isJumping = false;
        }
        if(!isModeInfinity)
        {
            if (collision.gameObject.tag == "GameOver")
            {
                GameController.instance.RestartGame(scene);
                Destroy(gameObject, 0.3f);
            }
        }
        else
        {
            if (collision.gameObject.tag == "GameOver")
            {
                GameController.instance.ShowGameOver();
                Destroy(gameObject);
            }
        }     
    }
}
