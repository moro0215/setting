using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManagerScript : MonoBehaviour
{
    public GameObject playerPrefab;
    int[,] map;

    //void printArray()
    //{

    //    string debugText = "";
    //    for (int i = 0; i < map.Length; i++)
    //    {
    //        debugText += map[i].ToString() + ",";
    //    }
    //    Debug.Log(debugText);
    //}

    //int GetPlayerIndex()
    //{
    //    for(int i = 0; i < map.Length; i++)
    //    {
    //        if (map[i] == 1)
    //        {
    //            return i;
    //        }
    //    }
    //    return -1;
    //}

    //bool MoveNumber(int number,int moveFrom,int moveTo)
    //{
    //    //�ړ��悪�͈͊O�Ȃ�ړ��s��
    //    if (moveTo < 0 || moveTo >= map.Length) { return false; }
    //    //�ړ����2�i���j��������
    //    if (map[moveTo] == 2)
    //    {
    //        //�ǂ̕����ֈړ����邩�Z�o
    //        int velocity = moveTo - moveFrom;
    //        //���̈ړ�����
    //        bool success = MoveNumber(2, moveTo, moveTo + velocity);
    //        //���������ړ������s������v���C���[�̈ړ������s
    //        if (!success) { return false; }
    //    }
    //    //�ړ�����
    //    map[moveTo] = number;
    //    map[moveFrom] = 0;
    //    return true;
    //}

    // Start is called before the first frame update
    void Start()
    {
       
        map = new int[,] {
            {0,0,0,0,0 },
            {0,0,1,0,0 },
            {0,0,0,0,0 },
        };

        string debugText = "";
        
        for(int y = 0; y < map.GetLength(0); y++)
        {
            for(int x = 0; x < map.GetLength(1); x++)
            {
                debugText += map[y, x].ToString() + ",";
            }
            debugText += "\n";
        }
        Debug.Log(debugText);

    }

    // Update is called once per frame
    //void Update()
    //{


    //    if (Input.GetKeyDown(KeyCode.RightArrow))
    //    {
    //        int playerIndex = GetPlayerIndex();

    //        MoveNumber(1, playerIndex, playerIndex + 1);

    //        printArray();
    //    }

    //    if (Input.GetKeyDown(KeyCode.LeftArrow))
    //    {
    //        int playerIndex = GetPlayerIndex();

    //        MoveNumber(1, playerIndex, playerIndex - 1);

    //        printArray();
    //    }


    //}

}
