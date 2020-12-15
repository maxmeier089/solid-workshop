using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem
{
    public class Project
    {

        private String name;
        private double asset;

        public Project(String name, double asset)
        {
            this.name = name;
            this.asset = asset;
        }

        public double GetAsset()
        {
            return asset;
        }
    }

}
