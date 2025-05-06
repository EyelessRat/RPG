using UnityEngine;

public enum DamageType
{
    Piercing,
    Slashing,
    Bludgening
}

[CreateAssetMenu(fileName = "WeaponData", menuName = "Scriptable Objects/WeaponData")]
public class WeaponData : ItemData
{
    public int damage;
    public DamageType damageType;
}
