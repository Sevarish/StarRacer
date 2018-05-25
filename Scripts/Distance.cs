using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public float kmUp = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        kmUp = GameObject.Find("Player").GetComponent<PlayerMovement>().speedUp * 100 * Time.deltaTime;

    }
}
