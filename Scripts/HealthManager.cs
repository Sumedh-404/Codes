using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthManager : MonoBehaviour
{
    public int NumOfHearts;
    public static int health;
    public Image[] hearts;
    public Sprite F_Heart;
    public Sprite E_Heart;
    private void Awake()
    {
        health = 3;
    }
    private void Update()
    {
        if (health > NumOfHearts)
        {
            health = NumOfHearts;
        }
        for (int i = 0; i < NumOfHearts; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = F_Heart;
            }
            else {
                hearts[i].sprite = E_Heart;
            }
            if (i < NumOfHearts) {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

        }
    }

}
