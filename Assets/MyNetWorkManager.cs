﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetWorkManager : NetworkManager {

    public void MyStartHost()
    {
        StartHost();
        Debug.Log("Starting host at " + Time.timeSinceLevelLoad);
    }

    public override void OnStartHost()
    {
        Debug.Log("Host started at " + Time.timeSinceLevelLoad);
    }

    public override void OnStartClient(NetworkClient myClient)
    {
        Debug.Log("Client start requested at " + Time.timeSinceLevelLoad);
        InvokeRepeating("PrintDots", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("Client is connected at " + Time.timeSinceLevelLoad + " - On IP: " + conn.address);
        CancelInvoke();
    }

    void PrintDots()
    {
        Debug.Log(".");
    }
}
