﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class stampscript : MonoBehaviour
{
    public Text stampname;

    public GameObject yoyogiuehara;
    public GameObject yoyogikouen;
    public GameObject meizizingumae;
    public GameObject omotesando;
    public GameObject nogizaka;
    public GameObject akasaka;
    public GameObject kokkaigizido;
    public GameObject kasumigaseki;
    public GameObject hibiya;
    public GameObject nizyubashimae;
    public GameObject otemachi;
    public GameObject sinotyanomizu;
    public GameObject yushima;
    public GameObject nedu;
    public GameObject sendagi;
    public GameObject nishinippori;
    public GameObject machiya;
    public GameObject kitasenzyu;
    public GameObject ayase;
    public GameObject kitaayase;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (Test.SampleGoal == "代々木上原")
        {
            yoyogiuehara.SetActive(true);
        }
        else if (Test.SampleGoal == "代々木公園")
        {
            yoyogikouen.SetActive(true);
        }
        else if (Test.SampleGoal == "明治神宮前")
        {
            meizizingumae.SetActive(true);
        }
        else if (Test.SampleGoal == "表参道")
        {
            omotesando.SetActive(true);
        }
        else if (Test.SampleGoal == "乃木坂")
        {
            nogizaka.SetActive(true);
        }
        else if (Test.SampleGoal == "赤坂")
        {
            akasaka.SetActive(true);
        }
        else if (Test.SampleGoal == "国会議事堂前")
        {
            kokkaigizido.SetActive(true);
        }
        else if (Test.SampleGoal == "霞ヶ関")
        {
            kasumigaseki.SetActive(true);
        }
        else if (Test.SampleGoal == "日比谷")
        {
            hibiya.SetActive(true);
        }
        else if (Test.SampleGoal == "二重橋前")
        {
            nizyubashimae.SetActive(true);
        }
        else if (Test.SampleGoal == "大手町")
        {
            otemachi.SetActive(true);
        }
        else if (Test.SampleGoal == "新御茶ノ水")
        {
            sinotyanomizu.SetActive(true);
        }
        else if (Test.SampleGoal == "湯島")
        {
            yushima.SetActive(true);
        }
        else if (Test.SampleGoal == "根津")
        {
            nedu.SetActive(true);
        }
        else if (Test.SampleGoal == "千駄木")
        {
            sendagi.SetActive(true);
        }
        else if (Test.SampleGoal == "西日暮里")
        {
            nishinippori.SetActive(true);
        }
        else if (Test.SampleGoal == "町屋")
        {
            machiya.SetActive(true);
        }
        else if (Test.SampleGoal == "北千住")
        {
            kitasenzyu.SetActive(true);
        }
        else if (Test.SampleGoal == "綾瀬")
        {
            ayase.SetActive(true);
        }
        else if (Test.SampleGoal == "北綾瀬")
        {
            kitaayase.SetActive(true);
        }
        else
        {
            Debug.Log("不適切なアクセスです"); 
        }

        stampname.text = Test.SampleGoal;
    }
public void PushStartButton() {
        
        SceneManager.LoadScene("StampseatScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
