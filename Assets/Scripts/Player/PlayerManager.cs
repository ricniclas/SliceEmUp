using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private MovementController movementController;
    [SerializeField] private BladeTriggerBehaviour bladeTriggerBehaviour;


    private void Start()
    {
        bladeTriggerBehaviour.GetOnCollisionEnterEvent().AddListener(stuckBlade);
    }



    private void stuckBlade()
    {
        movementController.enterStuckState();
        Debug.Log("Stuck!");
    }
}
