using System;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    [Header("Unity Actions")]
    public static Action<int> DamageEnemyAction;

    [SerializeField] private EnemyData enemyData;
    private int hp;
    private int maxHp;


    private void OnEnable()
    {
        DamageEnemyAction += Damage;
    }

    private void OnDisable()
    {
        DamageEnemyAction -= Damage;
    }

    private void Start()
    {
        hp = enemyData.hp;
        maxHp = enemyData.maxHp;
    }
    
    private void DamagePlayer(int damage)
    {
        Player.DamagePlayerAction(damage);
    }

    public void Damage(int damage)
    {
        int dmg = damage - enemyData.armour;
        hp -= Mathf.Max(dmg, 1);
    }
}
