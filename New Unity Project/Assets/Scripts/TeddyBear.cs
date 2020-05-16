using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TeddyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
            
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(direction * magnitude, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        print("Ouch");
    }
}