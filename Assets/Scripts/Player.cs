using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<Token> tokens = new List<Token>();
    private Token valittu;

    public Player()
    {
        tokens.Add(new Token());
    }

    public void MoveTokens(LocationTile destination)
    {
        //foreach (Token t in tokens)
        //    if (t == valittu)
        valittu.Move(destination);

    }
}
