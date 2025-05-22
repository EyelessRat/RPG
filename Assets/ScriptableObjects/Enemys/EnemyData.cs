using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Objects/EnemyData")]
public class EnemyData : ScriptableObject
{
    [Header("Properties")]

    public string enemyName;
    public int hp;
    public int maxHp;
    public int armour;
    public int str;
}
