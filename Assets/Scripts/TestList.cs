using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BadGuy bg1 = new BadGuy("bob", 10);
        BadGuy bg2 = new BadGuy("sue", 20);
        BadGuy bg3 = new BadGuy("raj", 30);

        List<BadGuy> badGuys = new List<BadGuy>();

        badGuys.Add(bg1);
        badGuys.Add(bg2);
        badGuys.Add(bg3);

        print("List Size: " + badGuys.Count);

        foreach (BadGuy guy in badGuys)
        {
            print(guy.name + " " + guy.power);
        }

        badGuys.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
