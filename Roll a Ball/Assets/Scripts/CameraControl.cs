using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject ball;
    Vector3 distence;
    // Start is called before the first frame update
    void Start()
    {
        distence = transform.position - ball.transform.position;
        //Camera ile Ball nesneleri arasındaki başlangıc mesafesini hesaplıyor.
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + distence;
        //Camera ve Ball nesneleri arasındaki mesafeyi sabit tutuyor
    }
}
