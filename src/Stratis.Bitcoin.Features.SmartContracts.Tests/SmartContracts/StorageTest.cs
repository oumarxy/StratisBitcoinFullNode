﻿using System;
using Stratis.SmartContracts;
using System.Linq;

public class StorageTest : SmartContract
{
    public StorageTest(SmartContractState state) 
        : base(state)
    {
    }

    [SmartContractInit]
    public void Init()
    {
    }
    
    public void StoreData()
    {
        PersistentState.SetObject<string>("TestKey", "TestValue");
    }

    public void GasTest()
    {
        ulong test = 1;
        while (true)
        {
            test++;
            test--;
        }
    }
}