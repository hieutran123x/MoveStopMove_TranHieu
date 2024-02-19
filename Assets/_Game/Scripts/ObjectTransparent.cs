using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransparent : MonoBehaviour
{
    public Transform player;
    public float transparencyDistance = 3f;

    private Renderer obstacleRender;


    // Start is called before the first frame update
    void Start()
    {
        obstacleRender = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        float transparencies = Mathf.Clamp01((distance - transparencyDistance) / transparencyDistance);

        Color materialColor = obstacleRender.material.color;
        materialColor.a = transparencies;
        obstacleRender.material.color = materialColor;
    }
}
