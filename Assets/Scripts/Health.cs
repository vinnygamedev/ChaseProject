using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public Slider playerSlider2D;

    public Stats statsScript;

    // Start is called before the first frame update
    void Start()
    {

        statsScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Stats>();

        playerSlider2D.maxValue = statsScript.maxHealth;
        statsScript.health = statsScript.maxHealth;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
