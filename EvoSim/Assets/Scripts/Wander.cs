using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    public GameObject avatar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveTo()
    {
        Vector3 currentPos = new Vector3Int((int)avatar.transform.position.x, (int)avatar.transform.position.y, (int)avatar.transform.position.z);

    }
}
