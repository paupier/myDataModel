#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.UI;
using FTOptix.WebUI;
using FTOptix.Retentivity;
using FTOptix.NativeUI;
using FTOptix.RAEtherNetIP;
using FTOptix.CoreBase;
using FTOptix.CommunicationDriver;
using FTOptix.Core;
using FTOptix.NetLogic;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.DataLogger;
using FTOptix.Alarm;
using FTOptix.EventLogger;
#endregion

[CustomBehavior]
public class myMotorType1Behavior : BaseNetBehavior
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined behavior is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined behavior is stopped
    }

#region Auto-generated code, do not edit!
    protected new myMotorType1 Node => (myMotorType1)base.Node;
#endregion
}
