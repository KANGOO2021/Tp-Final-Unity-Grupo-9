using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEditor;


public class PlayerRespawn : MonoBehaviour
{
    public Animator animator;

    public GameObject[] hearts;
    private int life;
    public AudioSource clip;
    public AudioSource death;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        life= hearts.Length;
    }

    public void CheckLife()
    {
        if (life < 1)
        {
           
            Destroy(hearts[0].gameObject);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            animator.Play("Death");
            death.Play();
            Invoke("GameOver", 1);

        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
            animator.Play("Hit");
            clip.Play();
        }
        else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
            animator.Play("Hit");
            clip.Play();

        }

    }
    public void PlayerDamaged()
    {
        life--;
        CheckLife();

    }

    void GameOver()
    {
        player.SetActive(false);
        gameOver.SetActive(true);
    }

}
