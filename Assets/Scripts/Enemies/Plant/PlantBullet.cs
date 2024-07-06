using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBullet : MonoBehaviour
{

    public float speed = 2;

    public float lifeTime = 2;

    public bool right;

 
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (right)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else 
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        Destroy(gameObject);
    }


}
