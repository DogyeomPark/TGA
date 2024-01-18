using UnityEngine;

public class StateManager : MonoBehaviour
{
    //����� �����÷��̾� �����̴�. �̰� ������ �ڽ� ��ü�� Ŭ�������� �����´�.



    // �÷��̾��� ����!!!!
    [Header("ĳ���� ����")]
    public int level;
    public float maxhp; 
    public float hp;
    public int atk;
    public int exp;
    [Space(10)]
    [Range(0, 100)]
    public int criChance = 50; //in percentage
    public float criDamage = 1.5f;
    public int def; //�Ⱦ�
    public float gageTime1; // ��ų ��Ÿ��
    public float gageTime2;
    public float gageTime3;

    [HideInInspector]
    public HUDManager hudManager; 

    private void Start()
    {
        hudManager = GetComponent<HUDManager>(); // ������ �κ�
    }
}