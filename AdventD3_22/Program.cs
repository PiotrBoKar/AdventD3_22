
using System.Text;

namespace AdventD3_22
{
    public class dayThre22
    {
        public static void Main()
        {
            List<string[]> input = ReadFile.getList("22D3");
            string convert;
            char[] firstComp;
            char[] secondComp;
            List<char[]> groupComp = new List<char[]>();
            int charToNum = 0;
            int check = 0;
            int groupCheck = 0;
            for (int i = 0; i < input.Count; i++)
            {
                convert = String.Join("", input[i]);
                firstComp = convert.ToCharArray(0, convert.Length/2);
                secondComp = convert.ToCharArray((convert.Length / 2), (convert.Length / 2));
                groupComp.Add(convert.ToCharArray(0, convert.Length));
                for (int j = 0; j < firstComp.Length; j++)
                {
                    check = Array.IndexOf(secondComp, firstComp[j]);
                    if (check != -1)
                    {
                        charToNum = charToNum + AssignNumber.assignNum(firstComp[j]);
                        break;
                    }
                }
            }
            Console.WriteLine("---------ANSWER TO FIRST QUESTION IS ------" + '\n' + charToNum);
            charToNum = 0;
            for (int k = 0; k < groupComp.Count-2; k++)
            {
                for (int l = 0; l < groupComp[k].Length; l++)
                {
                    check = Array.IndexOf(groupComp[k + 1], groupComp[k][l]);
                    if (check != -1)                  
                    {
                        groupCheck = Array.IndexOf(groupComp[k + 2], groupComp[k][l]);
                        if (groupCheck != -1)
                        {
                            if (groupComp[k + 1][check] == groupComp[k + 2][groupCheck])
                            {
                                charToNum = charToNum + AssignNumber.assignNum(groupComp[k][l]);
                                break;
                            }
                        }
                    }
                }
                k = k + 2;
            }
            Console.WriteLine("---------ANSWER TO SECOND QUESTION IS ------" + '\n' + charToNum);
        }
    }
}
