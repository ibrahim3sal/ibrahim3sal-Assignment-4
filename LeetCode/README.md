LeetCode Profile: [LEETCODE_PROFILE_URL](https://leetcode.com/u/ibrahim3sal/)


-Valid Anagram Problem


Problem URL: [PROBLEM_URL](https://leetcode.com/problems/valid-anagram/)


[Valid-anagram](images/valid-anagram.png)


Explanation

The problem asks us to determine whether two strings contain the same characters with the same frequencies, regardless of their order.

First, we check whether the two strings have the same length. If their lengths are different, they cannot be anagrams.

Then, we use an integer array of size 26 to store the frequency of each lowercase English letter.

For every character in the first string, we increase its frequency by one. For every character in the second string, we decrease its frequency by one.

The expression character - 'a' is used to convert each lowercase English letter into an array index from 0 to 25.

After processing both strings, we check the frequency array. If any value is not zero, the strings contain different character frequencies, so the result is false.

If all values are zero, both strings contain exactly the same characters with the same frequencies, so the result is true.




Time Complexity

O(n)

Space Complexity

O(1)





Greatest Common Divisor of Strings Problem


Problem URL:  [PROBLEM_URL](https://leetcode.com/problems/greatest-common-divisor-of-strings/)

[greatest-common-divisor-of-strings](images/greatest-common-divisor-of-strings.png)



Explanation

The problem asks us to find the largest string that can be repeated to form both input strings.

First, we check whether the two strings are built from the same repeating pattern.

This is done by comparing:

str1 + str2

with:

str2 + str1

If they are not equal, there is no common divisor string, so we return an empty string.

If they are equal, we calculate the greatest common divisor of the two string lengths.

The GCD gives us the length of the largest common repeating pattern.

Finally, we return the prefix of str1 with the length of the calculated GCD.




Time Complexity

O(n + m)

Space Complexity

O(n + m)