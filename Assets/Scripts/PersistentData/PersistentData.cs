using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PersistentData : MonoBehaviour
{

    

    private void Awake()
    {
        GameObject[] persistedDataObjects = GameObject.FindGameObjectsWithTag("PersistentData");

        if(persistedDataObjects.Length > 1 )
        {

            Destroy(gameObject);
        }


        DontDestroyOnLoad(gameObject);
        
    }

  
}
