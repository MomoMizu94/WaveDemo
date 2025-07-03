using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class WaterManager : MonoBehaviour
{
    private MeshFilter meshFilter;

    private void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
    }

    private void Update()
    {
        Vector3[] verticies = meshFilter.mesh.vertices;

        for (int i = 0; i < verticies.Length; i++)
        {
            verticies[i].y = WaveManager.instance.GetWaveHeight(transform.position.x + verticies[i].x);
        }

        meshFilter.mesh.vertices = verticies;
        meshFilter.mesh.RecalculateNormals();
    }
}
