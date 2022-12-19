using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

[UnitTitle("ExampleNodeUnit")]
[UnitCategory("My")]
public class ExampleUnit : Unit
{
    [DoNotSerialize] public ControlInput inputTrigger;
    [DoNotSerialize] public ControlOutput outputTrigger;
    [DoNotSerialize] public ValueInput message;
    [DoNotSerialize] public ValueOutput valueOutput;

    private int random;
    
    protected override void Definition()
    {
        inputTrigger = ControlInput("Enter", Enter);
        outputTrigger = ControlOutput("Exit");

        message = ValueInput<string>("Msg");
        valueOutput = ValueOutput("Random Value", Output);
    }
    
    private ControlOutput Enter(Flow arg)
    {
        random = Random.Range(1, 20);
        Debug.Log($"I choosed {random} {message}");
        return outputTrigger;
    }

    private int Output(Flow arg)
    {
        return random;
    }
}
