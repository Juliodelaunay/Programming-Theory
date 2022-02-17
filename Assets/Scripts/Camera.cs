using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform pivot;
    // Start is called before the first frame update
    void Start()
    {
        pivot=GameObject.Find("Pivot").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = pivot.transform.position;
    }
}
