using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{ 

    public enum ImperialOrMetric
    {
        Imperial,
        Metric
    }

    public enum WeightUnit
    {
        lb,
        kg
    }

    public enum YesNoUnknow {
        Unknow,
        Yes,
        No        
    }

    public enum SmokingHistory {
        Unknow,
        Yes,
        No,
        Iutsbiq //used to smoke, quit 
    }

    public enum SmokingQt
    {
        Unknow,
        Fof, //14 or fewer
        Bfat,  //between 15 and 25
        Mtt  //more than 25
    }

    public enum Gender
    {
        Unknow,
        Male,
        Female        
    }
}
