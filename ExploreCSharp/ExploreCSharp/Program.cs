﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExploreCSharp.SOLID;
using ExploreCSharp.DependencyInjection.VSExample;
using ExploreCSharp.Keywords;
using ExploreCSharp.Benchmark;
using ExploreCSharp.DesignPatterns.Creational.Factory;
using ExploreCSharp.DesignPatterns.Creational.Factory.DimitrySample;
using ExploreCSharp.DesignPatterns.Creational.Prototype;
using ExploreCSharp.DesignPatterns.Creational.Singleton;

namespace ExploreCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Set this to desired class
            StarterEnum starterEnum = StarterEnum.ValueRefTypes;

            switch (starterEnum)
            {
                case StarterEnum.Eq_EqToOp:
                    Equals_EqualToOperator.StarterEquals();
                    break;
                case StarterEnum.Benchmark:
                    BMStarter.Start();
                    break;
                case StarterEnum.Static:
                    StaticStarter.Start();
                    break;
                case StarterEnum.ValueRefTypes:
                    ValuevsRefTypes.ValueRefStarter();
                    break;
                case StarterEnum.DelLambda:
                    DelegatesandLambda.UsageDel();
                    DelegatesandLambda.UsageFunc();
                    DelegatesandLambda.DefaultDelUsage();
                    break;
                case StarterEnum.VarDynamic:
                    VarDynamic.Usage();
                    break;
                case StarterEnum.DP_Factory:
                    FactoryProperty.Starter();
                    break;
                case StarterEnum.DP_Factory_Dimitry:
                    Launcher LaunchOb = new();
                    LaunchOb.LaunchApp();
                    break;
                case StarterEnum.DP_Proto_IClonable:
                    UsingIClonable.Starter();
                    break;
                case StarterEnum.DP_Singleton:
                    SingletonStarter.Starter();
                    break;
                case StarterEnum.DP_Singleton_AmbientContext:
                    AmbientContextStarter.Starter();
                    break;
                default:
                    break;
            }
            return;

            //int 
            int x = 1, y = 2;
            int z = x / y;
            //Var and dynamic keyword usage
            VarDynamic.Usage();

            //2D array methods
            //TwoDArray.TwoDArray.Starter2D();

            //Various swap methods
            //int RefSample = 5;
            //Electronics.ExploreEle.Swap(ref RefSample, ref RefSample);


            //SOLIDSample sOLID = new SOLIDSample();
            //sOLID.TriggerL();

            //DIPStarter.Execute();

        }
    }
}
