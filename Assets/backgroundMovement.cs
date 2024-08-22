using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMovement : MonoBehaviour
{

    public GameObject MC;
    Vector3 mesafe;

    void Start()
    {
        mesafe = transform.position - MC.transform.position;
    }
    void Update()
    {
        transform.position = MC.transform.position + mesafe;
    }
}
