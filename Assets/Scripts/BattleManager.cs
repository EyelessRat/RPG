using UnityEngine;

public class BattleManager : MonoBehaviour
{
    private bool isPlayerTurn = true;

    public void NextTurn()
    {
        isPlayerTurn = !isPlayerTurn;
    }

    private void EnemyTurn()
    {
        NextTurn();
    }


}
