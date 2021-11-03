using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandom : MonoBehaviour
{
    public Color startColor = Color.green;
    private Material ObjectMaterial;
    private Color colorRandom;
    private float timer;
    public float time = 1;
    public float speedColor = 5;

    // Start is called before the first frame update
    void Start()
    {
        ObjectMaterial = GetComponent<SpriteRenderer>().material;
        ObjectMaterial.color = startColor;
        timer = 0;
        colorRandom = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1);
    }

    // Update is called once per frame
    void Update()
    {
        ObjectMaterial.color = Color.Lerp(ObjectMaterial.color, colorRandom, Time.deltaTime * speedColor);
        timer += Time.deltaTime;
        if(timer > time)
        {
            timer = 0;
            colorRandom = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1);
        }
    }
}
