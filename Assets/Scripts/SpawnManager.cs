using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(25, 0, 0);
    public float startDelay = 2f;
    public float period = 2f;

    private PlayerController script;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBarrel", startDelay, period);
        script = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script.gameOver == true) {
            CancelInvoke();
        }
    }

    void SpawnBarrel()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
