﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsConsole
{
    public class Claim : IClaim
    {
        public int ClaimID { get; set; } = 0;
        public TypeClaim ClaimType { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; } = false;
        public enum TypeClaim { Car = 1, Home, Theft };

        public bool VaidateEnumValue(int EnumValue)
        {
            bool success = Enum.IsDefined(typeof(TypeClaim), EnumValue);
            if (success)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid entry");
                return false;
            }
        }
    }
}