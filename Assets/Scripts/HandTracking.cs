using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HandTracking : MonoBehaviour {

    public UDPReceive udpReceive;
    public GameObject[] handPoints;
    [SerializeField] GameObject Player1;
    [SerializeField] GameObject laser;


    void Start()
    {
        
    }

    void Update()
    {
        string data = udpReceive.data;
        data = data.Remove(0, 1);
        data = data.Remove(data.Length - 1, 1);

        print(data);

        string[] points = data.Split(',');
        print(points[0]);

        for(int i = 0; i <21; i++)
        {
            float x = float.Parse(points[i * 3])/50-12;
            float y = float.Parse(points[i * 3 + 1])/100-6;


            handPoints[i].transform.localPosition = new Vector3(x, y, -10);
            Player1.transform.localPosition = new Vector3(x, -6,-10);
            if ((i ==8 && points[i * 3 + 2] == "-10") || (i == 12 && points[i * 3 + 2] == "-10"))
            {
                //laser
                Instantiate(laser, transform.position, Quaternion.identity);
            }
         
         }
            

     }




 }






