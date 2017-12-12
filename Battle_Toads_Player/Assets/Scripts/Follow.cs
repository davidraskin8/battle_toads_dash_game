using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public Transform player;

    private float initialCameraY;
    private float initialPlayerY;

    public float smoothTime = 0.5f;
    private float smoothVel = 0;

    public float step = 5;

    // Use this for initialization
    void Start()
    {
        initialCameraY = transform.position.y;
        initialPlayerY = player.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = new Vector3(player.transform.position.x, 0, transform.position.z);

        float playerDiff = (int)((player.position.y - initialPlayerY) / step) * step;
        float targetY = initialCameraY + playerDiff;

        cameraPos.y = Mathf.SmoothDamp(transform.position.y, targetY, ref smoothVel, smoothTime);


        transform.position = cameraPos;
    }
}