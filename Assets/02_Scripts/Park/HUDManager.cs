using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUDManager : MonoBehaviour
{

    public StateManager stateManager;
    public Slider HpSlider;
    public Text HpText;


    public Image DHpBar;




    //���� �Լ��� �ǰ��������� �ҷ��´�!
    private void Start()
    {
        stateManager = gameObject.GetComponent<StateManager>();
        if (stateManager.CompareTag("Player"))
        {
            HpSlider = GameObject.Find("PlayerHUD").GetComponent<Slider>(); //TODO: �ڱⰡ ���� ���� �����̴��� ������ ��!!!
            HpText = GameObject.Find("MainHP").GetComponent<Text>();
            DHpBar = GameObject.Find("DecreasePBar").GetComponent<Image>();
        }
        else
        {
            //if (stateManager.CompareTag("Boss"))
            //{
                // ������ �ش��ϴ� �͵�
            //}
            HpSlider = GameObject.Find("EnemyHUD").GetComponent<Slider>(); //TODO: �ڱⰡ ���� ���� �����̴��� ������ ��!!!
            HpText = GameObject.Find("EnemyHP").GetComponent<Text>();
            DHpBar = GameObject.Find("DecreaseEBar").GetComponent<Image>();
        }

        InitHP();
    }

    public void InitHP()
    {
        DHpBar.fillAmount = 1;
        HpSlider.value = (stateManager.hp / stateManager.maxhp);
        HpText.text = ((int)stateManager.hp + "/" + (int)stateManager.maxhp).ToString();
    }

    public void InitHPBtn()
    {
        stateManager.hp -= 20f;
        HpSlider.value = (stateManager.hp / stateManager.maxhp);
        HpText.text = ((int)stateManager.hp + "/" + (int)stateManager.maxhp).ToString();
    }
    public void ChangeUserHUD()
    {
        HpSlider.value = (stateManager.hp / stateManager.maxhp);
        HpText.text = ((int)stateManager.hp + "/" + (int)stateManager.maxhp).ToString();

        if (stateManager.hp <= 0)
        {
            Debug.Log("���⼭ ĳ���� �װ� ����ĳ���ͷ� ������ �Ѱܾ� ��!!!");
        }
    }

    private void Update()
    {
        float targetFillAmount = Mathf.InverseLerp(0, stateManager.maxhp, stateManager.hp);

        if (DHpBar.fillAmount > targetFillAmount)
        {
            DHpBar.fillAmount -= 0.2f * Time.deltaTime;
            DHpBar.fillAmount = Mathf.Max(DHpBar.fillAmount, targetFillAmount);
        }
    }
    public void ChangeMainHP()
    {

    }





}