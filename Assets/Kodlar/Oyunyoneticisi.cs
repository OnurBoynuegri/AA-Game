using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Oyunyoneticisi : MonoBehaviour
{  
    
    GameObject DonenCember;
    GameObject AnaCember;
    public Animator animator;
    public Text dartlevel,bir;
    public int kalandart = 5;
    bool kontrol = true;
    void Start()
    {
        PlayerPrefs.SetInt("kayit", int.Parse(SceneManager.GetActiveScene().name));
        // kaldığımız levelden devam edebilmek için bulunduğumuz sahneyi tutar. 
        DonenCember = GameObject.FindGameObjectWithTag("donencembertag");
        AnaCember = GameObject.FindGameObjectWithTag("anacembertag");
        dartlevel.text = SceneManager.GetActiveScene().name;
        
        bir.text = kalandart + "";
    }
    public void KalanDart()
    {
        kalandart--;
        bir.text = kalandart + "";
        if (kalandart == 0)
        {
            StartCoroutine(NextLevel());
        }
    }
    IEnumerator NextLevel()
    {
        DonenCember.GetComponent<Dondurne>().enabled = false;
        //Dondurne adlı scripti'in yanındaki tiki kaldırır yani skripti devre dışıı birakır.
        AnaCember.GetComponent<AnaCember>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        if (kontrol)
        {
            animator.SetTrigger("NextLevel");
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
        }
        
    }
    public void GameOver()
    {
        StartCoroutine(CagrilanMetod());
    }
    IEnumerator CagrilanMetod() 
    {
        kontrol = false;
        DonenCember.GetComponent<Dondurne>().enabled = false;
        //Dondurne adlı scripti'in yanındaki tiki kaldırır yani skripti devre dışıı birakır.
        AnaCember.GetComponent<AnaCember>().enabled = false;
        animator.SetTrigger("GameOver");//GameOver isimli animatörü oyun bittiğinde başalatan kod
        yield return new WaitForSeconds(2);// oyun bittiğinde ana menüye donmek için 1 sn gecikme sürsi sağlandı.
        SceneManager.LoadScene("AnaMenu");
    }
}
