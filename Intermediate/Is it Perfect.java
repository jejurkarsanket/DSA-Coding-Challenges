/*Problem Description

Take T (number of test cases) as input.

For each test case, take integer N as input, you have to tell whether it is a perfect number or not.

A perfect number is a positive integer that is equal to the sum of its proper positive divisors (excluding the number itself). A positive proper divisor divides a number without leaving any remainder.



Problem Constraints

1 <= T <= 10

1 <= N <= 106



Input Format

The first line of the input contains a single integer T.

Each of the next T lines contains a single integer N.



Output Format

In a separate line, print YES if a given integer is perfect, else print NO.



Example Input

Input 1:

 2
 4
 6 
Input 2:

 1
 3 


Example Output

Output 1:

 NO
 YES 
Output 2:

 NO 


Example Explanation

Explanation 1:

 For A = 4, the answer is "NO" as sum of its proper divisors = 1 + 2 = 3, is not equal to 4. 
 For A = 6, the answer is "YES" as sum of its proper divisors = 1 + 2 + 3 = 6, is equal to 6. 
Explanation 2:

 For A = 3, the answer is "NO" as sum of its proper divisors = 1, is not equal to 3. */

 //--------------------------------------------------------------------------------------------
                                Solution(JAVA)
 //--------------------------------------------------------------------------------------------

import java.lang.*;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        // YOUR CODE GOES HERE
        // Please take input and print output to standard input/output (stdin/stdout)
        // DO NOT USE ARGUMENTS FOR INPUTS
        // E.g. 'Scanner' for input & 'System.out' for output
        int num=0;
        Scanner sc = new Scanner(System.in);
        num = sc.nextInt();
        int arr[] = new int[num];
        for(int i=0;i<num;i++)
        {
            arr[i] = sc.nextInt();
        }
        for(int i=0;i<arr.length;i++)
        {
            int nm  = arr[i];
            int sum = 0;
            for(int j=1;j<nm;j++)
            {
                if(nm%j == 0)
                {
                    sum = sum+j;
                }
            }
            if(nm == sum)
            {
                System.out.print("YES\n");
            }
            else
            {
                 System.out.print("NO\n");
            }

        }
    }
}