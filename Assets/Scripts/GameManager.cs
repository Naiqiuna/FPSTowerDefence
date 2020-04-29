using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int MaxPlayerCount = 3;
    public int CurPlayerCount = 3;
    [SerializeField] private Player player = null;

    private void Awake()
    {
        CurPlayerCount = MaxPlayerCount;

    }



}
