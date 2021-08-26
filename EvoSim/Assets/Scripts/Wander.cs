using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    public bool isWalking = false;
    public float moveSpeed = 3.5f;
    public bool isRotR;
    public bool isRotL;
    public float rotationSpeed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(WanderAI());
        if(isRotR == true)
        {
            transform.Rotate(transform.up * rotationSpeed);
        }
        if(isRotL == true)
        {
            transform.Rotate(transform.up * -rotationSpeed);
        }
        if(isWalking == true)
        {
            transform.position += transform.forward * moveSpeed;
        }
    }

    IEnumerator WanderAI()
    {
        int rotateTime = Random.Range(1, 4);
        int rotateLoR = Random.Range(1, 2);

        int walkWait = Random.Range(1, 4);
        yield return new WaitForSeconds(walkWait);
        isWalking = true;
        yield return new WaitForSeconds(walkWait);
        isWalking = false;
        if(rotateLoR == 1)
        {
            isRotR = true;
            yield return new WaitForSeconds(rotateTime);
            isRotR = false;
        }
        if(rotateLoR == 2)
        {
            isRotL = true;
            yield return new WaitForSeconds(rotateTime);
            isRotL = false;
        }

    }
}
