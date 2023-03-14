# Solution created to solve randomly selected tasks. 

It consists of two projects:
- Tasks (logic of solving the selected task, identified by number),
- Tests (tests verifying the correctness of the task).

## Task 1:
Have the function stringChallenge (str) take the str parameter being passed and return a compressed version of the string using the Run-length encoding algorithm. This algorithm works by taking the occurrence of each repeating character and outputting that number along with a single character of the repeating sequence. For example: "wwwggopp" would return 3w2g102p. The string will not contain any numbers, punctuation, or symbols.\
**Examples**\
Input: "aabbcde"\
Output: 2a2b1c1dle\
Input: "wwwbbbw"\
Output: 3w3b1w

## Task 2:
Have the function StringChallenge(str) take the str parameter being passed and determine if it is possible to create a palindromic string of minimum length 3 characters by removing 1 or 2 characters.For example: if str is "abjchba" then you can remove the characters jc to produce "abhba" which is a palindrome. For this example your program should return the two characters that were removed with no delimiter and in the order they appear in the string, so jc. If 1 or 2 characters cannot be removed to produce a palindrome, then return the string not possible.
If the input string is already a palindrome, your program should return the string palindrome. Your program should always remove the characters that appear earlier in the string. In the example above, you can also remove ch to form a palindrome but jc appears first, so the correct answer is jc.
The input will only contain lowercase alphabetic characters. Your program should always attempt to create the longest palindromic substring by removing 1 or 2 characters (see second sample test case as an example). The 2 characters you remove do not have to be adjacent in the string.\
**Examples**\
Input: "mmop"\
Output: not possible\
Input: "kjjjhjjj"\
Output: k

## Task 3:
Have the function ArrayChallenge (arr) read the array of integers stored in arr which will be in the following format: [K, r1, r2, r3, ...] where K represents the number of desks in a classroom, and the rest of the integers in the array will be in sorted order and will represent the desks that are already occupied. All of the desks will be arranged in 2 columns, where desk #1 is at the top left, desk #2 is at the top right, desk #3 is below #1, desk #4 is below #2, etc. Your program should return the number of ways 2 students can be seated next to each other. This means 1 student is on the left and 1 student on the right, or 1 student is directly above or below the other student.
For example: if arr is [12, 2, 6, 7, 11] then this classrooms looks like the following picture:

![image](https://user-images.githubusercontent.com/24829262/225136642-ae71c3f2-f9e8-40f7-9301-9dae52408e48.png)

Based on above arrangement of occupied desks, there are a total of 6 ways to seat 2 new students next to each other. The combinations are: [1, 3], [3, 4], [3, 5], [8, 10], [9, 10], [10, 12]. So for this input your program should return 6. K will range from 2 to 24 and will always be an even number. After K, the number of occupied desks in the array can range from 0 to K.\
**Examples**\
Input: new int[] {6, 4}\
Output: 4

