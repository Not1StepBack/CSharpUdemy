using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class MeleeController : MonoBehaviour
{
    public CharacterStats CharacterStats;
    public GameObject scriptUser;
    public GameObject meleeWeapon;
    public GameObject hitEffect;
    public GameObject enemyHitEffect;
    public GameObject bossHitEffect;
 

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask targetLayer;

    //This is the identifier for the script user
        //Main Character  
        public bool isPlayer = false;
        public PlayerController pc;

        //Melee Enemy and Boss
        public bool isMeleeEnemy = false;
        public bool isBoss = false;
        public bool isServant = false;
        public MeleeEnemy me;
        public Boss boss;
        public ServantController sc;
        public GameObject target;
        public bool isPlayerHit;

        //Servant
      



    // Start is called before the first frame update
    void Start()
    {
        DecideUser();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}