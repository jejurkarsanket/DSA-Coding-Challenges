/*Problem Description

Write a program to find sum all Natural numbers from 1 to N where you have to take N as input from user


Problem Constraints

1 <= N <= 1000



Input Format

A single line representing N



Output Format

A single integer showing sum of all Natural numbers from 1 to N



Example Input

Input 1:

5
Input 2:

10


Example Output

Output 1:

15
Output 2:

55
*/
//Solution CPP

#include<iostream>

using namespace std;

int main()  {
    // YOUR CODE GOES HERE
    // Please take input and print output to standard input/output (stdin/stdout)
    // E.g. 'cin' for input & 'cout' for output
    int n;
    cin>>n;
    int sum = 0;
    sum = n*(n+1)/2;
    cout<<sum;

    return 0;
}