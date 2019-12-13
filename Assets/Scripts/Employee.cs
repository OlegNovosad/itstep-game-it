using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee : MonoBehaviour
{
    string name;
    int age;
    string rank;
    int exper, salary;

    List<Employee> employees = new List<Employee>();
    Employee(string _name, int _age, string _rank, int _exper, int _salary)
    {
        name = _name;
        age = _age;
        rank = _rank;
        exper = _exper;
        salary = _salary;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
