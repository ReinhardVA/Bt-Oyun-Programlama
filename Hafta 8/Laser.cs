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
        transform.Translate(speed * Time.deltaTime * Vector2.up);
    }
    private void OnBecameInvisible(){
        
        if(transform.parent != null){
            Destroy(transform.parent.gameObject);
        }

        Destroy(gameObject);
    }
}
