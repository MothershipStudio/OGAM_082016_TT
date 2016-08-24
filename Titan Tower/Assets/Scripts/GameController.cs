using UnityEngine;
using System.Collections;
using System;
using BaseClasses;


public class GameController : MonoBehaviour
{

    [Header("Round settings")]
    public float RoundTime = 10f;
    public int ActualTime;
    public int ActionsDone = 0;

    [Header("Player settings")]
    public PlayerController playerController;
    public int EnergyPerRound = 1;
    public int ActionsPerRound = 2;
    public int GemsPerRound = 1;

    [Header("Enenmy settings")]
    public EnemyController enemyController;
    public int AILevel = 1;

    private float endTime;
    private bool playerTurn;
    private bool gameRunnig = true;

    private Array elements = Enum.GetValues(typeof(Element));

    // Use this for initialization
    void Start()
    {
        endTime = Time.time + RoundTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameRunnig)
        {
            ActualTime = (int)(endTime - Time.time);

            if (ActualTime == 0)
            {
                EndTurn();
            }
            else if(ActionsDone >= ActionsPerRound)
            {
                EndTurn();
            }

        }

    }

    private void EndTurn()
    {
        endTime = Time.time + RoundTime;
        playerTurn = !playerTurn;

        playerController.isActiveRound = playerTurn;
        enemyController.isActiveRound = !playerTurn;

        if (playerTurn)
        {
            for (int i = 0; i < GemsPerRound; i++)
            {
                playerController.gems.Add(RandomElement());
            }
            playerController.energy += EnergyPerRound;
            enemyController.nextRoundAction = this.ActionsPerRound;
        }
        else
        {
            for (int i = 0; i < GemsPerRound * (this.AILevel); i++)
            {
                enemyController.gems.Add(RandomElement());
            }
            enemyController.energy = EnergyPerRound * (this.AILevel);
            playerController.nextRoundAction = this.ActionsPerRound;
        }
        this.ActionsDone = 0;
    }

    private Element RandomElement()
    {
        return (Element)elements.GetValue(UnityEngine.Random.Range(0, elements.Length));
    }
}
