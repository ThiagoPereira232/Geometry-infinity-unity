using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameController controller;

    void Start()
    {
        controller = FindObjectOfType<GameController>(); // procurar qualquer objeto q tenha o script GameController
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        controller.Score++;
        controller.scoreText.text = controller.Score.ToString();
        Destroy(gameObject);
    }
}
