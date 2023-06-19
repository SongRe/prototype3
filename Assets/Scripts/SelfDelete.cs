using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDelete : MonoBehaviour
{
    private Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.position;
        Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < initPos.y - 10) {
            Destroy(gameObject);
        }
    }
}
