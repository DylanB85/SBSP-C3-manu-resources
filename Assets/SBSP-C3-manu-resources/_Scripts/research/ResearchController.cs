﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResearchController : MonoBehaviour, ITimeable
{
    private ResearchModel researchModel;
    private RechargeTimer rechargeTimer;

    int researchLevel;
    string branch;// science branch---combat branch ----engineering branch

    /// <summary>
    /// /Science button references
    /// </summary>
    public Button scienceLv1;
    public Button scienceLv2;
    public Button scienceLv3;

    /// <summary>
    /// /Combat button references
    /// </summary>
    public Button combatLv1;
    public Button combatLv2;
    public Button combatLv3;

    /// <summary>
    /// /Engin button reference
    /// </summary>
    public Button enginLv1;
    public Button enginLv2;
    public Button enginLv3;

    // Use this for initialization
    void Awake ()
    {
        researchModel = new ResearchModel();
        rechargeTimer = new RechargeTimer();
	}

    public ResearchModel GetResearchModel()
    {
        return researchModel;
    }


    public RechargeTimer GetRechargeTimer()
    {
        return rechargeTimer;
    }
    /// <summary>
    /// timer methods called during button onclick 
    /// </summary>
    /// <returns></returns>

    public void ScienceLv1Upgrade()
    {
<<<<<<< HEAD
        researchModel.SetIronAmount(100);
        //rechargeTimer.ScienceLv1Time();//this makes system wait 10 ecounds 
        researchModel.SetScienceLvReseachedByIndex(0, true);
        Destroy(scienceLv1.gameObject);
        Debug.Log("scienceLv1 Called " + researchModel.GetIronAmount());
=======
        researchLevel = 0;
        branch = "science";
        startResearsh();
>>>>>>> upstream/master
    }

    public void ScienceLv2Upgrade()
    {
<<<<<<< HEAD
        researchModel.SetIronAmount(200);
        //rechargeTimer.ScienceLv2Time();//this makes system wait 20 ecounds 
        researchModel.SetScienceLvReseachedByIndex(1, true);
        Destroy(scienceLv2.gameObject);
        Debug.Log("scienceLv2 Called " + researchModel.GetIronAmount());
=======
        researchLevel = 1;
        branch = "science";
        startResearsh();
>>>>>>> upstream/master
    }

    public void ScienceLv3Upgrade()
    {
<<<<<<< HEAD
        researchModel.SetIronAmount(300);
        //rechargeTimer.ScienceLv3Time();//this makes system wait 30 ecounds 
        researchModel.SetScienceLvReseachedByIndex(2, true);
        Destroy(scienceLv3.gameObject);
        Debug.Log("scienceLv3 Called " + researchModel.GetIronAmount());

=======
        researchLevel = 2;
        branch = "science";
        startResearsh();
>>>>>>> upstream/master
    }

    public void CombatLv1Upgrade()
    {
<<<<<<< HEAD
        researchModel.SetIronAmount(100);
        //rechargeTimer.ScienceLv1Time();//this makes system wait 10 ecounds 
        researchModel.SetCombatLvReseachedByIndex(0, true);
        Destroy(combatLv1.gameObject);
        Debug.Log("combatLv1 Called " + researchModel.GetIronAmount());
=======
        researchLevel = 0;
        branch = "combat";
        startResearsh();

>>>>>>> upstream/master
    }

    public void CombatLv2Upgrade()
    {
<<<<<<< HEAD
        researchModel.SetIronAmount(200);
        //rechargeTimer.ScienceLv2Time();//this makes system wait 20 ecounds 
        researchModel.SetCombatLvReseachedByIndex(1, true);
        Destroy(combatLv2.gameObject);
        Debug.Log("combatLv2 Called " + researchModel.GetIronAmount());
=======
        researchLevel = 1;
        branch = "combat";
        startResearsh();
>>>>>>> upstream/master
    }

    public void CombatLv3Upgrade()
    {
<<<<<<< HEAD
        researchModel.SetIronAmount(300);
        //rechargeTimer.ScienceLv3Time();//this makes system wait 30 ecounds 
        researchModel.SetCombatLvReseachedByIndex(2, true);
        Destroy(combatLv3.gameObject);
        Debug.Log("combatLv3 Called " + researchModel.GetIronAmount());
=======
        researchLevel = 2;
        branch = "combat";
        startResearsh();
>>>>>>> upstream/master
    }

    public void EnginLv1Upgrade()
    {
<<<<<<< HEAD
        researchModel.SetIronAmount(100);//reduce iron amout
        //rechargeTimer.ScienceLv1Time();//this makes system wait 10 ecounds 
        researchModel.SetEnginLvReseachedByIndex(0, true);
        Destroy(enginLv1.gameObject);
        Debug.Log("enginLv1 Called " + researchModel.GetIronAmount());
=======
        researchLevel = 0;
        branch = "engineering";
        startResearsh();
>>>>>>> upstream/master
    }

    public void EnginLv2Upgrade()
    {
        researchLevel = 1;
        branch = "engineering";
        researchModel.SetIronAmount(200);
<<<<<<< HEAD
        //rechargeTimer.ScienceLv2Time();//this makes system wait 20 ecounds 
        researchModel.SetEnginLvReseachedByIndex(1, true);
        Destroy(enginLv2.gameObject);
        Debug.Log("enginLv2 Called " + researchModel.GetIronAmount());
=======
       
>>>>>>> upstream/master
    }

    public void EnginLv3Upgrade()
    {
        researchLevel = 2;
        branch = "engineering";
        researchModel.SetIronAmount(300);
<<<<<<< HEAD
        //rechargeTimer.ScienceLv3Time();//this makes system wait 30 ecounds 
        researchModel.SetEnginLvReseachedByIndex(2, true);
        Destroy(enginLv3.gameObject);
        Debug.Log("enginLv3 Called " + researchModel.GetIronAmount());
=======
    }

    public void startResearsh()
    {      
        if(researchLevel==0)
        {
            StartCoroutine(rechargeTimer.StartTimerCouroutine(5, this));
        }
        if(researchLevel==1)
        {
            StartCoroutine(rechargeTimer.StartTimerCouroutine(10, this));
        }
        if(researchLevel==2)
        {
            StartCoroutine(rechargeTimer.StartTimerCouroutine(15, this));
        }
    }

    public void OnStartTimer()
    {
        Debug.Log("timer is working ");
        if (researchLevel == 0)
        {
            researchModel.SetIronAmount(100);//reduce iron amout
       
        }
        if (researchLevel == 1)
        {
            researchModel.SetIronAmount(200);//reduce iron amout
        }
        if (researchLevel == 2)
        {
            researchModel.SetIronAmount(300);//reduce iron amout
        }
    }
     
    public void OnIncrementTimer()
    {
        
    }

    public void OnFinishTimer()
    {
        Debug.Log("timer is working ");
        if (researchLevel == 0)
        {
            if (branch == "science")
            {
                researchModel.SetScienceLvReseachedByIndex(0, true);
                Destroy(scienceLv1.gameObject);
                Debug.Log("scienceLv1 Called " + researchModel.GetIronAmount());
            }
            if (branch == "engineering")
            {
                researchModel.SetEnginLvReseachedByIndex(0, true);
                Destroy(enginLv1.gameObject);
                Debug.Log("enginLv1 Called " + researchModel.GetIronAmount());

            }
            if (branch == "combat")
            {
                researchModel.SetCombatLvReseachedByIndex(0, true);
                Destroy(combatLv1.gameObject);
                Debug.Log("combatLv1 Called " + researchModel.GetIronAmount());
            }
        }
        if (researchLevel == 1)
        {
            if (branch == "science")
            {
                researchModel.SetScienceLvReseachedByIndex(1, true);
                Destroy(scienceLv2.gameObject);
                Debug.Log("scienceLv2 Called " + researchModel.GetIronAmount());
            }
            if (branch == "engineering")
            {
                researchModel.SetEnginLvReseachedByIndex(1, true);
                Destroy(enginLv2.gameObject);
                Debug.Log("enginLv2 Called " + researchModel.GetIronAmount());
            }
            if (branch == "combat")
            {
                researchModel.SetCombatLvReseachedByIndex(1, true);
                Destroy(combatLv2.gameObject);
                Debug.Log("combatLv2 Called " + researchModel.GetIronAmount());
            }

        }
        if (researchLevel == 2)
        {
            if (branch == "science")
            {
                researchModel.SetScienceLvReseachedByIndex(2, true);
                Destroy(scienceLv3.gameObject);
                Debug.Log("scienceLv3 Called " + researchModel.GetIronAmount());
            }
            if (branch == "engineering")
            {
                researchModel.SetEnginLvReseachedByIndex(2, true);
                Destroy(enginLv3.gameObject);
                Debug.Log("enginLv3 Called " + researchModel.GetIronAmount());
            }
            if (branch == "combat")
            {
                researchModel.SetCombatLvReseachedByIndex(2, true);
                Destroy(combatLv3.gameObject);
                Debug.Log("combatLv3 Called " + researchModel.GetIronAmount());
            }
        }
>>>>>>> upstream/master
    }
}
