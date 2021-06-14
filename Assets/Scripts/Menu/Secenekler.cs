using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Secenekler
{


    public static string Puan = "kolayPuan";
   
    public static string MuzikAcik = "MuzikAcik";



    public static void PuanDegerAta(int kolayPuan)
    {
        PlayerPrefs.SetInt(Secenekler.Puan, kolayPuan);
    }
    public static int PuanDegerOku()
    {
        return PlayerPrefs.GetInt(Secenekler.Puan);
    }
   

    public static void MuzikAcikDegerAta(int MuzikAcik)
    {
        PlayerPrefs.SetInt(Secenekler.MuzikAcik, MuzikAcik);
    }
    public static int MuzikAcikDegerOku()
    {
        return PlayerPrefs.GetInt(Secenekler.MuzikAcik);
    }



    public static bool MuzikKayitVarmi()
    {
        if (PlayerPrefs.HasKey(Secenekler.MuzikAcik))
        {
            return true;
        }
        else
        {
            return false;
        }
    }



    public static bool KayitVarmi()
    {
        if(PlayerPrefs.HasKey(Secenekler.Puan))
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}