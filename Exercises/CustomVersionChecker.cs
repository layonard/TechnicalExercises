using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /*
     * From TestGorilla assesment
     * CUSTOM VERSION FORMAT
     * Software versions are stored as a string which has 5 parts stored as the format
     * [major].[minor].[patch].[build].[compilation]. Each ersion part will always be non-negative integers.
     * You may see versions like "2", "1.5", or "2.12.4.0.6". The period is only used as a separator and 
     * does not represent a decimal point (i.e. 1.5 does not mean one and a half.)
     * 
     * ALGORITHM DETAILS
     * Your algorithm should have two string input parameters: version1 and version2. I should return -1
     * when version1 is less than version2, 0 when version1 = version2, and 1 when version1 is greater
     * than version2.
     * All inputs can be treated as valid and the maximum version part will be less than 100.
     * 
     * EXAMPLES
     * "2" == "2.0" == "2.0.0" == "2.0.0.0" == "2.0.0.0.0" (return 0 in each case)
     * "2" < "2.0.0.0.1" (returns -1)
     * "2" < "2.1" (returns -1)
     * "2.1.0" > "2.0.1" (returns 1)
     * "2.10.0.1" > "2.1.0.10" (returns 1)
     * "2.0.1" > 1.2000.1 (returns 1)
     */
    sealed class CustomVersionChecker
    {

    }
}
