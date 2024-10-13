using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoving : MonoBehaviour
{
    public float speed = 2.0f;
    public float moveDistance = 5.0f;

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startPosition + new Vector3(0, 0, Mathf.PingPong(Time.time * speed, moveDistance));
    }
}
