using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{

    public float maxHealth;
    public float health;
    public float attackDmg;
    public float attackSpeed;
    public float attackTime;

    HeroCombat heroCombatScript;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        heroCombatScript = GameObject.FindGameObjectWithTag("Player").GetComponent<HeroCombat>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            heroCombatScript.targetedEnemy = null;
            heroCombatScript.performMeleeAttack = false;

            Destroy(gameObject);

        }
    }
}
