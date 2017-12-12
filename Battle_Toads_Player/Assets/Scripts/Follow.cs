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
        //Take the initial camera and player positions as configured in the editor
        initialCameraY = transform.position.y;
        initialPlayerY = player.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //Camera position
        Vector3 cameraPos = new Vector3(player.transform.position.x, 0, transform.position.z);

        //Change in player position this frame
        float playerDiff = (int)((player.position.y - initialPlayerY) / step) * step;
        //Target y for camera
        float targetY = initialCameraY + playerDiff;

        //smoothing camera position with SmoothDamp to get to targetY
        cameraPos.y = Mathf.SmoothDamp(transform.position.y, targetY, ref smoothVel, smoothTime);

        //Set the new camera position
        transform.position = cameraPos;
    }
}