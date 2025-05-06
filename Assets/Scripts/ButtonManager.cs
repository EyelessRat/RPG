using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private BattleManager battleManager;

    public void OnClickDamageEnemy()
    {
        EnemyControler.DamageEnemyAction(player.GetPlayerDamage()); 
        battleManager.NextTurn();
    }


    public void OnClickDefend()
    {
        player.isDefending = true;
        battleManager.NextTurn();
        
    }


    public void OnClickUsePotion()
    {
        battleManager.NextTurn();
    }
}
