﻿using System.Linq;
using System.Text;
using AgileSqlClub.SqlPackageFilter.Filter;

namespace AgileSqlClub.SqlPackageFilter.Config
{
    public class RuleDefinition
    {
        public FilterOperation Operation;
        public FilterType Type;
        public string Match;
    }


    
}