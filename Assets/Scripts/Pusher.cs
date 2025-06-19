using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    public GameObject pusher = default;
    public Vector3 defaultPosition;
    public float pusherPower = 0f;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        defaultPosition = pusher.transform.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        float z = pusherPower * Mathf.Sin(Time.time);
        Debug.Log(z);
        pusher.transform.localPosition = new Vector3(0, 0, z) + defaultPosition;
    }
}   
        