using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraShake : MonoBehaviour {

    public static CamaraShake instancia;
    public Transform camTransform;
    public float shakeDuration = 0f;
    private float shakeAmount = 0.2f;
    private float decreaseFactor = 1.0f;

    Vector3 originalPos;

    void Awake()
    {
        instancia = this;
    }

    void OnEnable()
    {
        originalPos = camTransform.localPosition;
    }

    void Update()
    {
        if (shakeDuration > 0)
        {
            camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

            shakeDuration -= Time.deltaTime * decreaseFactor;
        }
        else
        {
            shakeDuration = 0f;
            camTransform.localPosition = originalPos;
        }
    }
}
