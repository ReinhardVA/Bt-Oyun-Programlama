using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    private void OnBecameInvisible(){
        Destroy(gameObject);
    }
}
