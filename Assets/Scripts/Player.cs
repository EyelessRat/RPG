using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Unity Actions")]
    public static Action<int> DamagePlayerAction;

    [Header("Properties")]
    [SerializeField] private string playerName;
    [SerializeField] private int hp;
    [SerializeField] private int armour;
    [SerializeField] private int str;


    private void OnEnable()
    {
        DamagePlayerAction += Damage;
    }

    private void OnDisable()
    {
        DamagePlayerAction -= Damage;
    }

    public void Damage(int damage)
    {
        int dmg = damage - armour;
        hp -= Mathf.Max(dmg, 1);
    }

    public int GetPlayerDamage()
    {
        return str + 3;
    }

    
}
