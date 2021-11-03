using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credito : MonoBehaviour
{
    private Animator anim;
    private IEnumerator coroutine;


    void Start()
    {
        anim = GetComponent<Animator>();

        anim.SetBool("idle", false);
        coroutine = WaitAnim(4.0f);
        StartCoroutine(coroutine);
    }

    private IEnumerator WaitAnim(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            anim.SetBool("idle", true);
        }
    }
}
