using Enums;
using UnityEngine;

public class GameManager : Monobehaviour
{
    #region Self Veraibles

    #region Serialized Veriables

    [SerializeField] private GameStates states;

    #endregion

    #endregion


    private void Awake()
    {
        Application.targetFrameRate = 60;
    }

    private void OnEnable()
    {
        SubscribeEvents();
    }

    private void SubscribeEvents()
    {
        CoreGameSignals.Instance.onChangeGameState += OnChangeGameState;
    }
    
    private void UnSubscribeEvents()
    {
        CoreGameSignals.Instance.onChangeGameState += OnChangeGameState;
    }

    private void OnDisable()
    {
        UnSubscribeEvents();
    }

    [Button(name:"Change state")]
    private void OnChangeGameState(GameStates state)
    {
        states = state;
    }
}


