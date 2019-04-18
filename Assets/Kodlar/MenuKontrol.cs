using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{
     void Start()
    {
        //PlayerPrefs.DeleteAll();
        // kayıtlı yeri silmemizi sağlar fakat bu kod oyun her açıldığında bir kez çalıştırılmalı 
    }
    public void start()
    {
        int kayitliLevel = PlayerPrefs.GetInt("kayit");
        if (kayitliLevel == 0)
        {
            SceneManager.LoadScene(kayitliLevel+1);//istediğimiz sahneyi yükler. bu kodda k    ayitli sahne yükleniyor.
        }
        else
        {
            SceneManager.LoadScene(kayitliLevel);//istediğimiz sahneyi yükler
        }
        
    }
    public void exit()
    {
        Application.Quit();//oyun built edildikten sonra çalışır editörde çalışmaz.
    }
}
