using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerLife : MonoBehaviour
{
    bool dead = false;
    public int Life = 3;
    int h;
    [SerializeField] AudioSource deathSound;
    private void FixedUpdate()
    {
       
        if(transform.position.y<-1f && !dead)
        {
            
            HealthManager.health--;
            if (HealthManager.health <= 0) { die(); }
               
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            HealthManager.health--;
            if (HealthManager.health <= 0) {
                GetComponent<MeshRenderer>().enabled = false;
                GetComponent<Rigidbody>().isKinematic = true;
                GetComponent<PlayerMovement>().enabled = false;
                die();
                deathSound.Play();
                
            }
            else
            {
                StartCoroutine(GetHurt());
            }
            
        }  

    }
   IEnumerator GetHurt()
    {
        Physics.IgnoreLayerCollision(7,8);
        yield return new WaitForSeconds(3);
        Physics.IgnoreLayerCollision(7, 8, false);
    }

    void die()
    {
        dead = true;
        deathSound.Play();
        Invoke(nameof(ReloadLevel), 1f);
    }
    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        HealthManager.health = h;
        Debug.Log(h);
    }
   void GameOver()
    {
        
        if (HealthManager.health<=0)
        {
            Debug.Log("life is less than zero");
            SceneManager.LoadScene(5);
        }
    }
}
