using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string title = "������";
    string playerName = "���˻�";
    int level = 5;
    float strength = 15.5f;
    int exp = 1500;
    int health = 30;
    int mana = 25;
    bool isFullLevel = false;

    void Start()
    {
        Debug.Log("Hello Unity!");

        //1. ����

        //2. �׸��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("��������30");

        //3. ������
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        int nextExp = 300 - (exp % 300);

        string fullName = title + " " + playerName;

        int fullLevel = 99;
        isFullLevel = level == fullLevel;

        bool isEndTutorial = level > 10;

        bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "����" : "����";

        //4. Ű����
        //int float string bool new List

        //5. ���ǹ�
        if (isBadCondition && items[0] == "������30") {
            items.RemoveAt(0);
            health += 30;
        }
        else if (isBadCondition && items[0] == "��������30") {
            items.RemoveAt(0);
            mana += 30;
        }

        string monsterAlarm;
        switch (monsters[1]) {
            case "������":
            case "�縷��":
                monsterAlarm = "���� ���Ͱ� ����!";
                break;
            case "�Ǹ�":
                monsterAlarm = "���� ���Ͱ� ����!";
                break;
            case "��":
                monsterAlarm = "���� ���Ͱ� ����!";
                break;
            default:
                monsterAlarm = "??? ���Ͱ� ����!";
                break;
        }

        //6. �ݺ���
        while (health > 0) {
            health--;

            if (health == 10) {
                break;
            }
        }

        for (int count = 0; count < 10; count++) {
            health++;
        }

        foreach (string monster in monsters) {
            //Debug.Log("�� ������ �ִ� ���� : " + monsters[index]);
        }

        //7. �Լ� (�޼ҵ�)
        Heal();

        for (int index = 0; index < monsters.Length; index++) {
            //Debug.Log("����" + monsters[index] + "����" + 
            //    Battle(monsterLevel[index]));
        }

        //8. Ŭ����
        Player player = new Player();
        player.id = 0;
        player.name = "������";
        player.title = "������";
        player.strength = 2.4f;
        player.weapon = "���� ������";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "�� ������ " + player.level + " �Դϴ�");

        Debug.Log(player.move());
    }

    void Heal()
    {
        health += 10;
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "�̰���ϴ�.";
        else
            result = "�����ϴ�.";

        return result;
    }
}
