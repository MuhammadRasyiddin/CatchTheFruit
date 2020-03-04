using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ScoreController : MonoBehaviour
{
    public Text ScoreText;
    public int Score;
    public string[] fruits;
    public string fruitName;
    public int fruitIndex;
    public int totalBenar;

    // Start is called before the first frame update
    void Start()
    {
        fruits = new string[3];
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "fruit")
        {
            fruits[fruitIndex] = collision.gameObject.name;
            fruitIndex++;

            if (fruitIndex > 2)
            {
                //Debug.Log(fruitName+fruitIndex);
                checkFruit(fruits);
                fruitIndex = 0;
            }
            //fubgsi proses nyocokin buah yg ditangkap dengan array clue (fruitIndex = 0, ilangin semua isi fruits)
        }
    }

    private void checkFruit(string[] fruitName)
    {
        
        GameObject menuObject = GameObject.Find("Spawner").GetComponent<clueController>().test;
        //Debug.Log(menuObject.transform.childCount);
        for (int i = 0; i < menuObject.transform.childCount; i++)
        {
            Debug.Log(menuObject.transform.GetChild(i).name);
            if (menuObject.transform.GetChild(i).name == fruitName[i])
            {
                Debug.Log("Benar");
            }
            else
            {
                Debug.Log("Salah");
            }
        }
    }
}
