using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform target;
    [Range(10, 75f)] public float Distance = 20.0f;
    public float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, target.position + new Vector3(0, Distance, -10), (speed * Time.deltaTime));
    }
}
