using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrounds : MonoBehaviour
{
    public GameObject ground;

    [SerializeField]
    private float height;
    [SerializeField]
    private float width;
    [SerializeField]
    private float minwidth;
    [SerializeField]
    private float maxTime;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newGround = Instantiate(ground);
        newGround.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        newGround.transform.localScale = transform.localScale + new Vector3(Random.Range(-minwidth, width), 0, 0);
        Destroy(newGround, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newGround = Instantiate(ground);
            newGround.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            newGround.transform.localScale = transform.localScale + new Vector3(Random.Range(-minwidth, width), 0, 0);
            Destroy(newGround, 20f);
            timer = 0;
        }

        timer += Time.deltaTime;    
    }
}
