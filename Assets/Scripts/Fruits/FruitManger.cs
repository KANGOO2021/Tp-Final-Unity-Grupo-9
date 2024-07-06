using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class FruitManger : MonoBehaviour
{


    public TMP_Text levelCleared;

    public TMP_Text totalFruits;

    public TMP_Text collectedFruits;

    public int totalFruitsInLevel;

    public GameObject audioSource;



    void Start()
    {
        totalFruitsInLevel = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
      

        AllFruitCollectec();
        totalFruits.text = totalFruitsInLevel.ToString();
        collectedFruits.text = transform.childCount.ToString();

    }

    public void AllFruitCollectec()
    {
        
        if (transform.childCount==0)
        {
            
            levelCleared.gameObject.SetActive(true);
            audioSource.SetActive(false);
          
            Invoke("ChangeScene", 2);
            
        }
    }

    void ChangeScene()
    {
        //Debug.Log("TODAS LAS FRUTAS RECOLECTADAS...VICTORIA");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
