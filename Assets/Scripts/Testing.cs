using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{

    public int generalHappiness = 0;
    public int income = 0;
    public int workersCount = 0;

    int tempHappiness;
    

    public List<Worker> workers = new List<Worker>();

    //[System.Serializable]
    

    [System.Serializable]
    public class TypesList
    {
        public enum Qualifications
        {
            Junior = 0,
            Middle = 1,
            Senior = 2
        }

        public static readonly string[] qualifications = { "Junior", "Middle", "Senior" };
    };
    

    [System.Serializable]
    public class Worker
    {
        public string name;
        public TypesList.Qualifications qualification;
        public int happiness;
        public int salary;
        public int companyIncome;
        


        public Worker(string _name, string _qualification, int _happiness, int _salary, int _companyIncome)
        {
            name = _name;
            TypesList.qualifications[(int)qualification] = _qualification;
            happiness = _happiness;
            salary = _salary;
            companyIncome = _companyIncome;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        workersCount = workers.Count;


        foreach(Worker worker in workers)
        {
            tempHappiness += worker.happiness;
            income += worker.companyIncome;
        }

        generalHappiness = tempHappiness / workers.Count;
        

        /*workers.Add(new Worker("Anton",30, 40));
        workers.Add(new Worker("Zarina",30, 40));
        workers.Add(new Worker("Judy",30, 40));*/

        foreach(Worker worker in workers)
        {
            Debug.Log("Name: " + worker.name + ";\nQualification: " + worker.qualification + 
                ";\nHappiness: " + worker.happiness + ";\nSalary (USD/hour) " + worker.salary + ";\nIncome for company: " + worker.companyIncome + "\n");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}


