﻿using ChainOfResponsability.Exceptions;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Validators
{
    public class SocialSecurityNumberValidator
    {
        public bool Validate(string socialSecurityNumber, RegionInfo region)
        {
            switch (region.TwoLetterISORegionName)
            {
                case "SE": return ValidateSwedishSocialSecurityNumber(socialSecurityNumber);
                case "US": return ValidateUnitedStatesSocialSecurityNumber(socialSecurityNumber);
                default: throw new UnsupportedSocialSecurityNumberException();
            }

            // C# 8.0 version
            //return region.TwoLetterISORegionName switch
            //{
            //    "SE" => ValidateSwedishSocialSecurityNumber(socialSecurityNumber),
            //    "US" => ValidateUnitedStatesSocialSecurityNumber(socialSecurityNumber),
            //    _ => throw new UnsupportedSocialSecurityNumberException()
            //};
        }

        private bool ValidateSwedishSocialSecurityNumber(string socialSecurityNumber)
        {
            // Not actually how it's done..

            return socialSecurityNumber.Length > 1;
        }

        private bool ValidateUnitedStatesSocialSecurityNumber(string socialSecurityNumber)
        {
            // Not actually how it's done..

            return socialSecurityNumber.Length > 2;
        }
    }
    }
