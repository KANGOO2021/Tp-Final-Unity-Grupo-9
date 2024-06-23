using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantDamage : MonoBehaviour
{

    private float waitedTime;

    public float waitTimeToAttack = 3;

    public Animator animator;

    public GameObject bulletPrefeb;

    public Transform launchSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        waitedTime = waitTimeToAttack;
    }

    // Update is called once per frame
    void Update()
    {
        if (waitedTime <= 0) 
        {
            waitedTime = waitTimeToAttack;
            animator.Play("AttackPlant");
            Invoke("LaunchBullet", 0.5f);
        }
        else 
        {
            waitedTime -= Time.deltaTime;
        }
    }

    public void LaunchBullet() 
    {
        GameObject newBullet;

        newBullet = Instantiate(bulletPrefeb, launchSpawnPoint.position, launchSpawnPoint.rotation);
    }
}
