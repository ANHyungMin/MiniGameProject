using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayer : MonoBehaviour
{
    public string PlayerName; // ���� = string
    public int Score;        // ���� = int ����, float �Ҽ�
    public int Hp;
    public float GameTimer;

    public bool IsPlaying;

    private void Start()
    {

    }

    private void Update()
    {
        if (!IsPlaying)
        {
            Debug.Log("������ �������ϴ�!");
            return;
        }

        GameTimer = GameTimer - Time.deltaTime;
        if (GameTimer <= 0)
        {
            IsPlaying = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        bool isEnemy = other.gameObject.tag == "Enemy";
        bool isitem = other.gameObject.tag == "Item";

        if (isEnemy)
        {
            Debug.Log("Enemy Check");
            Hp = Hp - 1;

            if (Hp <= 0)
            {
                IsPlaying = false;
            }

            if (isitem)
            {
                Debug.Log("Item Check");
                //�������� �Ծ���.
                Score = Score + 1;

            }

            Destroy(other.gameObject);

        }

    }
}
