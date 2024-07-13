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
    public GameObject audioSourceJumpPlayer;
    

    void Start()
    {
        totalFruitsInLevel = transform.childCount;
    }


    void Update()
    {
        AllFruitCollectec();
        totalFruits.text = totalFruitsInLevel.ToString();
        collectedFruits.text = transform.childCount.ToString();
    }

    public void AllFruitCollectec()
    {
        if (transform.childCount == 0)
        {

            levelCleared.gameObject.SetActive(true);
            audioSource.SetActive(false);
            Time.timeScale = 0f;
            audioSourceJumpPlayer.GetComponent<Player>().enabled = false;
            StartCoroutine(ChangeScene());
        }
    }
 

    private IEnumerator ChangeScene()
    {
        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }


}
