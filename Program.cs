using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1,2,3,2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is : {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"
        Example 2:
        Input: s = "aeiou"
        Output: ""
        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                
                char[] c = s.ToCharArray(); // To Convert string to Characrter array
                String final_string = ""; // Empty String Further USed in the loop for Concatanation.
                for (int i = 0; i < c.Length; i++) 
                {                
                    // If Condidtion to check all lower case and upper case Vowels
                    if (c[i] != 'a' && c[i] != 'e' && c[i] != 'i' && c[i] != 'o' && c[i] != 'u' && c[i] != 'A' && c[i] != 'E' && c[i] != 'I' && c[i] != 'O' && c[i] != 'U')
                    {
                        final_string = final_string + c[i]; // to concat all characters except the vowels
                    }

                }
                
                return final_string;
                /* Self-reflection 
                 * Time Taken is 20 min
                 * Learning is difference between & and && as well as || function.
                 * Also about IndexOf.
                 */
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                string s1 = ""; // Used to Concat all String values in the Array bulls_string1
                string s2 = "";//Used to Concat all String values in the Array bulls_String2
                for (int i = 0; i < bulls_string1.Length; i++) // Running the for till the length of the array
                {
                    s1 = s1 + bulls_string1[i]; // Concating all string in the array bulls_string1
                }
                for (int i = 0; i < bulls_string2.Length; i++)// Running the for till the length of the array
                {
                    s2 = s2 + bulls_string2[i]; // Concating all string in the array bulls_string2
                }
                // Not changing the string to lower case as we are comparing with case sentivity
                if (s1 == s2) // if both the string are equal flag will return as true
                {
                    return true;
                }
                else // else that is if both the strings are not equal the flag will return as false. 
                {
                    return false;
                }
                /*Self -Reflection
                 * Time-Taken - 20 min
                 * Here we are comparing the strings with Case senstivity so we didn't use .tolower function
                 * 
                 */
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                /*
                 * In this problem verified each value whether it is unique or not by comparing with other all other value
                 * if the value unique the adding the sum of the value else ignoring the value.
                 */
                int sum = 0; // Declaration of the variable sum used further to store sum of unique values
                for (int i = 0; i < bull_bucks.Length; i++) // loop to run till the length of the array
                {
                    bool con = true; // bool flag decalaration for while loop which helps to stop the loop for condition.
                    int j = 0; // j declaration used to increment array in the loop
                    while (con == true && j < bull_bucks.Length) // To continue the loop only till flag is true and till end of the length of array
                    {
                        if (i != j) // Checking the condition so same values in the array are not checked
                        {
                            if (bull_bucks[i] == bull_bucks[j]) // checking whether the current index value is equal to any other value
                            {
                                con = false; // if we reveive any value equal then changing the bool value as false to exit from the loop.
                            }

                        }
                        j = j + 1; // incrementing the j value to verify the next element in the array
                    }
                    if (con == true) // if the flag is still true means the i th position value in the array is unique. If flag is false that means i th position value if the array is not unique
                    {
                        sum = sum + bull_bucks[i]; // adding all the unique value of the array
                    }
                }
                return sum;
                /*Self-reflection 
                 * Time Taken: 30 min
                 * Learning is the usage of all loops and flag properly in single code.
                 */


            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int n1 = bulls_grid.GetLength(0); // to get length of the matrix
                int n2 = bulls_grid.GetLength(1);
                int sum = 0;
                if (n1 == n2 && n1 != 0) // verifying whether the input is square matrix and is not an empty array
                {
                    /* Diagonal elements of the array are in the position of 
                     * [ considering n as last index of the matrix]
                     * (i,i) --> (0,0),(1,1)....(n,n) --> first diagonal
                     * (n-i,i) ---> (n,0),(n-1,1)...(1,n-1),(0,n) --> Second diagonal
                     * for example in 3x3 matrix diagonal positions are
                     * (0,0),(1,1),(2,2),(2,0),(2,2),(0,2)
                     */
                    for (int i = 0; i < n1; i++)
                    {
                        sum = sum + bulls_grid[i, i] + bulls_grid[((n1 - 1) - i), i]; // adding the values of the diagonal of the matrix
                    }
                    if (n1 % 2 != 0) // for odd length matrix middle value repeat in diagonal1 and diagonal2.So deleting the repeated value from the sum
                    {
                        int r = (n1 - 1) / 2; // for middle value index of the odd matrix
                        sum = sum - bulls_grid[r, r]; // deleting the repeative value.
                    }
                }

                return sum;
                /*Self-reflection 
                 * Time taken : 20 min
                 * Learning is multi-dimensinal array
                 */
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                /* In this Converted the string to character array then verified in the loop regarding indices position.
                 * Then Concating the string with character as per the indices index.
                 */
                char[] c = bulls_string.ToCharArray(); // Converting to character array
                string s = ""; 
                for (int i = 0; i < c.Length; i++) // for String index
                {
                    for (int j = 0; j < c.Length; j++) // for indices index

                    {
                        if (i == indices[j])  
                        /*
                         * to know the i th index value in indices array location
                         * like to know 0th value index is in which position in the indices array 
                         * for example, when i=0 then here we checking at what index value of indices array we have the value of 0.
                         * j value indicate the index position where 0 is located in indices array
                         * So we know that first character of the string is in j th index value in the character array or the string.
                         */
                        {
                            s = s + c[j]; // concating the string with the character as per the indices location

                        }

                    }
                }
                return s;
                /* Self-reflection 
                 * Time Taken : 30 min
                 */
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            /* In this problem verified the first index position of the character.
             * Then reversing the string from that position the start and storing in a string
             * Then adding the remaing character in the string post the character index position to different string
             * Then adding both first and second string to get new string
             */
            try
            {
                char[] s = bulls_string6.ToCharArray();
                bool con = true;
                int i = 0;
                int j = 0;
                while (con == true && i < bulls_string6.Length) // to continue the loop till we get the index location of the character till the length of the array
                {
                    if (s[i] == ch) 
                    {
                        con = false; // if at i th index position we get the given character then changing flag to false to end the loop
                        j = i; // storing the index value in j
                    }
                    i = i + 1;
                }
                if (con == true) // if flag is still true means there is no character "ch" in the string so we don't have reverse any string
                {
                    return bulls_string6;
                }
                else
                {
                    string s2 = ""; 
                    string s1 = "";
                    for (int z = i; z < bulls_string6.Length; z++)
                    {
                        s2 += s[z]; // Concating the character post the character index value.
                    }
                    for (int a = 0; a <= j; a++)
                    {
                        s1 += s[j - a]; // Reversing and concating the character along with the index position
                    }
                    String prefix_string = s1 + s2;
                    return prefix_string;
                }
                /* Self-reflection 
                 * Time Taken : 30 min
                 * Recommendation: Can use IndexOf(char x) for simplication instead of while and if loop.
                 * Code:
                 * int j = bulls_string6.IndexOf(ch);
                 */
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}