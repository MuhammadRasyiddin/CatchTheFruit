using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clueController : MonoBehaviour
{
    public GameObject[] menu;
    public GameObject test { get; set; }
    public int randomMenu;
    public int indexBuah = 0;
    // Start is called before the first frame update

    private void Start()
    {
        clueMenu();
    }
    public void clueMenu()
    {
        randomMenu = Random.Range(0, menu.Length);
        test = Instantiate(menu[randomMenu], new Vector2(-0.8f, 4.5f), Quaternion.identity);
    }
}
