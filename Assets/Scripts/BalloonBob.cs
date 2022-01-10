using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonBob : MonoBehaviour
{
    // "Bobbing" animation from 2D Perlin noise.

    float _counter;
    public float shakeSpeed;
    public float shakeMultiplier;
    public float shakeReduction;

    float seedX;
    float seedY;

    private void Start()
    {
        seedX = Random.Range(1, 5f);
        seedY = Random.Range(1, 5f);
    }

    private void Update()
    {
        _counter += Time.deltaTime * shakeSpeed;

        float yNoise = (Mathf.PerlinNoise(seedX, _counter) - 0.5f) * 2;
        float xNoise = (Mathf.PerlinNoise(seedY, _counter) - 0.5f) * 2;

        yNoise = yNoise / shakeReduction;
        xNoise = xNoise / shakeReduction;        


        transform.position = new Vector3(transform.position.x + xNoise, transform.position.y + yNoise, transform.position.z);
    }
}
