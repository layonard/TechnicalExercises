/*
 * From TestGorilla assesment
 * CUSTOM VERSION FORMAT
 * Software versions are stored as a string which has 5 parts stored as the format
 * [major].[minor].[patch].[build].[compilation]. Each version part will always be non-negative integers.
 * You may see versions like "2", "1.5", or "2.12.4.0.6". The period is only used as a separator and 
 * does not represent a decimal point (i.e. 1.5 does not mean one and a half.)
 * 
 * ALGORITHM DETAILS
 * Your algorithm should have two string input parameters: version1 and version2. It should return -1
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
namespace Exercises;
public sealed class CustomVersionChecker
{
    public int Solution(string version1, string version2)
    {
        var version1Array = version1.Split('.');
        var version2Array = version2.Split('.');

        for(var i=0; i<5; i++)
        {
            var v1part = i < version1Array.Length? Int32.Parse(version1Array[i]) : 0;
            var v2part = i < version2Array.Length? Int32.Parse(version2Array[i]) : 0;

            if (v1part > v2part)
                return 1;
            if (v1part < v2part)
                return -1;
        }

        return 0;
    }
}
