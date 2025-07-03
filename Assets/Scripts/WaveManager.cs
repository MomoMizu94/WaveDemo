using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;

    public float waveAmplitude = 1f;
    public float waveLength = 2f;
    public float waveSpeed = 1f;
    public float waveOffset = 0f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("Instance already exists! Destroying object!");
            Destroy(this);
        }
    }

    void Update()
    {
        waveOffset += Time.deltaTime * waveSpeed;
    }

    public float GetWaveHeight(float _x)
    {
        return waveAmplitude * Mathf.Sin(_x / waveLength + waveOffset);
    }

}
