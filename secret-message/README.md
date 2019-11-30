# Tasks processor

## Problem

Jack and Jill developed a special encryption method, so they can enjoy conversations without worrrying about eavesdroppers. Here is how: let 𝐿 be the length of the original message, and 𝑀 be the smallest square number greater than or equal to 𝐿. Add (𝑀−𝐿) asterisks to the message, giving a padded message with length 𝑀. Use the padded message to fill a table of size 𝐾×𝐾, where 𝐾2=𝑀. Fill the table in row-major order (top to bottom row, left to right column in each row). Rotate the table 90 degrees clockwise. The encrypted message comes from reading the message in row-major order from the rotated table, omitting any asterisks.

For example, given the original message ‘iloveyouJack’, the message length is 𝐿=12. Thus the padded message is ‘iloveyouJack****’, with length 𝑀=16. Below are the two tables before and after rotation.

```
[i] [l] [o] [v]
[e] [y] [o] [u]
[J] [a] [c] [k]
[*] [*] [*] [*]
```
```
[*] [J] [e] [i]
[*] [a] [y] [l]
[*] [c] [o] [o]
[*] [k] [u] [v]
```
Then we read the secret message as ‘Jeiaylcookuv’.

## Input:
A file (input.txt) with n lines contains:

The first line of input is the number of original messages, 1≤𝑁≤100. The following 𝑁 lines each have a message to encrypt. Each message contains only characters a–z (lower and upper case), and has length 1≤𝐿≤10000.

Example of the file:
```
2
iloveyoutooJill
TheContestisOver
```

## Expected output: a file at [output.txt](output.txt) contains entry/exit status of each person

```
iteiloylloooJuv
OsoTvtnheiterseC
```
## NOTES:
### run.sh must be modified to include all steps to build, compile and run your program to produce the desired output.txt
### Character encoding of the output file should be UTF-8
### Make sure to NOT include any "redundant spaces/lines" in the output.txt as an exact comparison is going to be used for evaluation
### Linux's newline character must be used when needed
