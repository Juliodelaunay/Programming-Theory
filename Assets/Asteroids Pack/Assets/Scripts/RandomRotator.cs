using UnityEngine;
using System.Collections;


public class RandomRotator : MonoBehaviour
{
    [SerializeField]
    private float tumble = 0.25f;
    public int speed;

    void Start()
    {   
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }

    void Update()
    {   speed = Random.Range(8,40);
        transform.Translate(Vector3.back * Time.deltaTime * speed );
        DestroyAsteroid();
    }

    private void DestroyAsteroid()
    {
        if (transform.position.z < 2f || transform.position.y > 200 || transform.position.y < -200f )
        {
            Destroy (gameObject);
        }
    }
}